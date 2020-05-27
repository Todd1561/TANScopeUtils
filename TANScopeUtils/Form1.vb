Imports ASCOM.DeviceInterface
Imports ASCOM.DriverAccess
Imports ASCOM.Utilities
Imports Microsoft.Win32
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class Form1

    Public Scope As String
    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const MF_STRING As Integer = &H0
    Private Const MF_SEPARATOR As Integer = &H800

    ' P/Invoke declarations
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function GetSystemMenu(hWnd As IntPtr, bRevert As Boolean) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function AppendMenu(hMenu As IntPtr, uFlags As Integer, uIDNewItem As Integer, lpNewItem As String) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function InsertMenu(hMenu As IntPtr, uPosition As Integer, uFlags As Integer, uIDNewItem As Integer, lpNewItem As String) As Boolean
    End Function

    ' ID for the About item on the system menu
    Private SYSMENU_ABOUT_ID As Integer = &H1

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)

        ' Get a handle to a copy of this form's system (window) menu
        Dim hSysMenu As IntPtr = GetSystemMenu(Me.Handle, False)

        ' Add a separator
        AppendMenu(hSysMenu, MF_SEPARATOR, 0, String.Empty)

        ' Add the About menu item
        AppendMenu(hSysMenu, MF_STRING, SYSMENU_ABOUT_ID, "&About TANScopeUtils…")
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        ' Test if the About item was selected from the system menu
        If (m.Msg = WM_SYSCOMMAND) AndAlso (CInt(m.WParam) = SYSMENU_ABOUT_ID) Then
            Dim dlg As New frmHelp
            dlg.Owner = Me
            dlg.StartPosition = FormStartPosition.CenterParent
            dlg.ShowDialog()
        End If

    End Sub

    Private Sub btnGetMountTime_Click(sender As Object, e As EventArgs) Handles btnGetMountTime.Click

        Try
            Dim t = New Telescope(Scope)
            t.Connected = True
            lblMountTime.Text = "Local: " & t.UTCDate.ToLocalTime & vbCrLf & "UTC: " & t.UTCDate

        Catch ex As Exception
            Log("Failed to get time. " & ex.Message, True)
        End Try

    End Sub

    Private Sub btnSetMountTime_Click(sender As Object, e As EventArgs) Handles btnSetMountTime.Click

        Try
            Dim t = New Telescope(Scope)
            t.Connected = True
            t.UTCDate = Date.UtcNow
            lblMountTime.Text = "Local: " & t.UTCDate.ToLocalTime & vbCrLf & "UTC: " & t.UTCDate

            Log("Set mount time to: " & t.UTCDate.ToLocalTime)

        Catch ex As Exception
            Log("Failed to set time. " & ex.Message, True)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        DisableAllControls()

        Try
            Dim regKey As RegistryKey
            regKey = Registry.CurrentUser.OpenSubKey("Software\Nelonic\TANScopeUtils", True)

            If regKey IsNot Nothing Then
                Scope = regKey.GetValue("Scope")

                If Scope = "" Then
                    lblScope.Text = "No Scope Selected!"
                Else
                    lblScope.Text = Scope
                    EnableAllControls()
                    btnGetMountTime_Click(Nothing, Nothing)

                    'run any command line args
                    For Each arg As String In Environment.GetCommandLineArgs
                        arg = arg.Trim.ToLower.Replace("-", "").Replace("/", "")
                        If arg = "setmounttime" Then btnSetMountTime.PerformClick()
                    Next

                End If
            End If

            regKey.Close()
        Catch ex As Exception
            Log("Could not read registy settings! ", True)
        End Try

    End Sub

    Sub DisableAllControls()
        For Each ctl As Control In gbDateTime.Controls
            ctl.Enabled = False
        Next
        For Each ctl As Control In gbSlew.Controls
            ctl.Enabled = False
        Next
    End Sub

    Sub EnableAllControls()
        For Each ctl As Control In gbDateTime.Controls
            ctl.Enabled = True
        Next
        For Each ctl As Control In gbSlew.Controls
            ctl.Enabled = True
        Next
    End Sub

    Private Sub btnSlewToPos_Click(sender As Object, e As EventArgs) Handles btnSlewToPos.Click

        If Double.TryParse(txtSlewAlt.Text, Nothing) And Double.TryParse(txtSlewAz.Text, Nothing) Then
            Try
                Dim t = New Telescope(Scope)
                t.Connected = True
                t.SlewToAltAz(txtSlewAz.Text, txtSlewAlt.Text)
                If chkSlewStopTracking.Checked Then t.Tracking = False

                Log("Slewed to: " & txtSlewAz.Text & ", " & txtSlewAlt.Text)
            Catch ex As Exception
                Log("Failed to slew. " & ex.Message, True)
            End Try
        Else
            Log("Invalid Alt/Az coordinates!", True)
        End If

    End Sub

    Private Sub btnLoadParkCoords_Click(sender As Object, e As EventArgs) Handles btnLoadParkCoords.Click

        Try
            Dim regKey As RegistryKey
            regKey = Registry.CurrentUser.OpenSubKey("Software\Nelonic\TANScopeUtils", True)

            If regKey IsNot Nothing Then
                txtSlewAlt.Text = regKey.GetValue("ParkPosAlt").ToString.Trim
                txtSlewAz.Text = regKey.GetValue("ParkPosAz").ToString.Trim

                If txtSlewAlt.Text = "" Or txtSlewAz.Text = "" Then
                    txtSlewAlt.Text = ""
                    txtSlewAz.Text = ""
                    Log("No park position saved to registy yet!", True)
                End If
            Else
                Log("No settings saved to registy yet!", True)
            End If

            regKey.Close()
        Catch ex As Exception
            Log("Could not read registy settings! ", True)
        End Try

    End Sub

    Sub Log(msg As String, Optional ByVal isError As Boolean = False)

        If isError Then
            lvLog.Items.Add("ERROR: " & msg)
            lvLog.Items(lvLog.Items.Count - 1).ForeColor = Color.Red
        Else
            lvLog.Items.Add(msg)
        End If

        lvLog.Items(lvLog.Items.Count - 1).EnsureVisible()

    End Sub

    Private Sub btnGetCurPos_Click(sender As Object, e As EventArgs) Handles btnGetCurPos.Click

        Try
            Dim t = New Telescope(Scope)
            t.Connected = True
            txtSlewAlt.Text = t.Altitude
            txtSlewAz.Text = t.Azimuth
            Log("Loaded current pos.  Az: " & t.Azimuth & ", Alt: " & t.Altitude)
        Catch ex As Exception
            Log("Failed to load current pos. " & ex.Message, True)
        End Try

    End Sub

    Private Sub btnSaveAsPark_Click(sender As Object, e As EventArgs) Handles btnSaveAsPark.Click
        If Double.TryParse(txtSlewAlt.Text, Nothing) And Double.TryParse(txtSlewAz.Text, Nothing) Then
            Try
                Dim regKey As RegistryKey
                regKey = Registry.CurrentUser.OpenSubKey("Software", True)
                regKey.CreateSubKey("Nelonic")
                regKey = Registry.CurrentUser.OpenSubKey("Software\Nelonic", True)
                regKey.CreateSubKey("TANScopeUtils")
                regKey = Registry.CurrentUser.OpenSubKey("Software\Nelonic\TANScopeUtils", True)
                regKey.SetValue("ParkPosAz", txtSlewAz.Text)
                regKey.SetValue("ParkPosAlt", txtSlewAlt.Text)
                regKey.Close()
            Catch ex As Exception
                Log("Couldn't save to registry. " & ex.Message, True)
            End Try
        Else
            Log("Invalid Alt/Az coordinates!", True)
        End If

    End Sub

    Private Sub btnSelectScope_Click(sender As Object, e As EventArgs) Handles btnSelectScope.Click

        Dim c As New Chooser
        c.DeviceType = "Telescope"
        Dim newScope = c.Choose(Scope)

        If newScope.Trim = "" Then
            Exit Sub
        ElseIf newScope.Trim <> "" Then
            Scope = newScope
            lblScope.Text = Scope
            EnableAllControls()
            btnGetMountTime_Click(Nothing, Nothing)

            Try
                Dim regKey As RegistryKey
                regKey = Registry.CurrentUser.OpenSubKey("Software", True)
                regKey.CreateSubKey("Nelonic")
                regKey = Registry.CurrentUser.OpenSubKey("Software\Nelonic", True)
                regKey.CreateSubKey("TANScopeUtils")
                regKey = Registry.CurrentUser.OpenSubKey("Software\Nelonic\TANScopeUtils", True)
                regKey.SetValue("Scope", Scope)
                regKey.Close()
                Log("Saved '" & Scope & "' as new default scope in registry.")
            Catch ex As Exception
                Log("Couldn't save scope choice registry. " & ex.Message, True)
            End Try
        Else
            DisableAllControls()
        End If

    End Sub

End Class

