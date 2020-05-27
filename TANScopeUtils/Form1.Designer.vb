<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnGetMountTime = New System.Windows.Forms.Button()
        Me.lblMountTime = New System.Windows.Forms.Label()
        Me.btnSetMountTime = New System.Windows.Forms.Button()
        Me.btnSlewToPos = New System.Windows.Forms.Button()
        Me.txtSlewAz = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSlewAlt = New System.Windows.Forms.TextBox()
        Me.chkSlewStopTracking = New System.Windows.Forms.CheckBox()
        Me.gbSlew = New System.Windows.Forms.GroupBox()
        Me.btnGetCurPos = New System.Windows.Forms.Button()
        Me.btnSaveAsPark = New System.Windows.Forms.Button()
        Me.btnLoadParkCoords = New System.Windows.Forms.Button()
        Me.gbDateTime = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvLog = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSelectScope = New System.Windows.Forms.Button()
        Me.lblScope = New System.Windows.Forms.Label()
        Me.gbSlew.SuspendLayout()
        Me.gbDateTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetMountTime
        '
        Me.btnGetMountTime.Location = New System.Drawing.Point(6, 19)
        Me.btnGetMountTime.Name = "btnGetMountTime"
        Me.btnGetMountTime.Size = New System.Drawing.Size(100, 23)
        Me.btnGetMountTime.TabIndex = 0
        Me.btnGetMountTime.Text = "Get Mount Time"
        Me.btnGetMountTime.UseVisualStyleBackColor = True
        '
        'lblMountTime
        '
        Me.lblMountTime.AutoSize = True
        Me.lblMountTime.Location = New System.Drawing.Point(122, 19)
        Me.lblMountTime.Name = "lblMountTime"
        Me.lblMountTime.Size = New System.Drawing.Size(0, 13)
        Me.lblMountTime.TabIndex = 1
        '
        'btnSetMountTime
        '
        Me.btnSetMountTime.Location = New System.Drawing.Point(6, 48)
        Me.btnSetMountTime.Name = "btnSetMountTime"
        Me.btnSetMountTime.Size = New System.Drawing.Size(99, 23)
        Me.btnSetMountTime.TabIndex = 2
        Me.btnSetMountTime.Text = "Set Mount Time"
        Me.btnSetMountTime.UseVisualStyleBackColor = True
        '
        'btnSlewToPos
        '
        Me.btnSlewToPos.Location = New System.Drawing.Point(7, 20)
        Me.btnSlewToPos.Name = "btnSlewToPos"
        Me.btnSlewToPos.Size = New System.Drawing.Size(99, 23)
        Me.btnSlewToPos.TabIndex = 3
        Me.btnSlewToPos.Text = "Slew To Position"
        Me.btnSlewToPos.UseVisualStyleBackColor = True
        '
        'txtSlewAz
        '
        Me.txtSlewAz.Location = New System.Drawing.Point(163, 22)
        Me.txtSlewAz.Name = "txtSlewAz"
        Me.txtSlewAz.Size = New System.Drawing.Size(131, 20)
        Me.txtSlewAz.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Azimuth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Altitude"
        '
        'txtSlewAlt
        '
        Me.txtSlewAlt.Location = New System.Drawing.Point(163, 48)
        Me.txtSlewAlt.Name = "txtSlewAlt"
        Me.txtSlewAlt.Size = New System.Drawing.Size(131, 20)
        Me.txtSlewAlt.TabIndex = 6
        '
        'chkSlewStopTracking
        '
        Me.chkSlewStopTracking.AutoSize = True
        Me.chkSlewStopTracking.Location = New System.Drawing.Point(12, 48)
        Me.chkSlewStopTracking.Name = "chkSlewStopTracking"
        Me.chkSlewStopTracking.Size = New System.Drawing.Size(93, 17)
        Me.chkSlewStopTracking.TabIndex = 8
        Me.chkSlewStopTracking.Text = "Stop Tracking"
        Me.chkSlewStopTracking.UseVisualStyleBackColor = True
        '
        'gbSlew
        '
        Me.gbSlew.Controls.Add(Me.btnGetCurPos)
        Me.gbSlew.Controls.Add(Me.btnSaveAsPark)
        Me.gbSlew.Controls.Add(Me.btnLoadParkCoords)
        Me.gbSlew.Controls.Add(Me.btnSlewToPos)
        Me.gbSlew.Controls.Add(Me.chkSlewStopTracking)
        Me.gbSlew.Controls.Add(Me.txtSlewAz)
        Me.gbSlew.Controls.Add(Me.Label2)
        Me.gbSlew.Controls.Add(Me.Label1)
        Me.gbSlew.Controls.Add(Me.txtSlewAlt)
        Me.gbSlew.Location = New System.Drawing.Point(12, 149)
        Me.gbSlew.Name = "gbSlew"
        Me.gbSlew.Size = New System.Drawing.Size(302, 105)
        Me.gbSlew.TabIndex = 9
        Me.gbSlew.TabStop = False
        Me.gbSlew.Text = "Slewing"
        '
        'btnGetCurPos
        '
        Me.btnGetCurPos.Location = New System.Drawing.Point(199, 71)
        Me.btnGetCurPos.Name = "btnGetCurPos"
        Me.btnGetCurPos.Size = New System.Drawing.Size(95, 23)
        Me.btnGetCurPos.TabIndex = 11
        Me.btnGetCurPos.Text = "Get Current Pos."
        Me.btnGetCurPos.UseVisualStyleBackColor = True
        '
        'btnSaveAsPark
        '
        Me.btnSaveAsPark.Location = New System.Drawing.Point(111, 71)
        Me.btnSaveAsPark.Name = "btnSaveAsPark"
        Me.btnSaveAsPark.Size = New System.Drawing.Size(82, 23)
        Me.btnSaveAsPark.TabIndex = 10
        Me.btnSaveAsPark.Text = "Save As Park"
        Me.btnSaveAsPark.UseVisualStyleBackColor = True
        '
        'btnLoadParkCoords
        '
        Me.btnLoadParkCoords.Location = New System.Drawing.Point(7, 71)
        Me.btnLoadParkCoords.Name = "btnLoadParkCoords"
        Me.btnLoadParkCoords.Size = New System.Drawing.Size(98, 23)
        Me.btnLoadParkCoords.TabIndex = 9
        Me.btnLoadParkCoords.Text = "Load Park Pos."
        Me.btnLoadParkCoords.UseVisualStyleBackColor = True
        '
        'gbDateTime
        '
        Me.gbDateTime.Controls.Add(Me.btnGetMountTime)
        Me.gbDateTime.Controls.Add(Me.lblMountTime)
        Me.gbDateTime.Controls.Add(Me.btnSetMountTime)
        Me.gbDateTime.Location = New System.Drawing.Point(12, 47)
        Me.gbDateTime.Name = "gbDateTime"
        Me.gbDateTime.Size = New System.Drawing.Size(302, 80)
        Me.gbDateTime.TabIndex = 10
        Me.gbDateTime.TabStop = False
        Me.gbDateTime.Text = "Date and Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Output Log"
        '
        'lvLog
        '
        Me.lvLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvLog.Location = New System.Drawing.Point(12, 289)
        Me.lvLog.MultiSelect = False
        Me.lvLog.Name = "lvLog"
        Me.lvLog.ShowItemToolTips = True
        Me.lvLog.Size = New System.Drawing.Size(302, 115)
        Me.lvLog.TabIndex = 12
        Me.lvLog.TileSize = New System.Drawing.Size(338, 30)
        Me.lvLog.UseCompatibleStateImageBehavior = False
        Me.lvLog.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 280
        '
        'btnSelectScope
        '
        Me.btnSelectScope.Location = New System.Drawing.Point(12, 12)
        Me.btnSelectScope.Name = "btnSelectScope"
        Me.btnSelectScope.Size = New System.Drawing.Size(87, 23)
        Me.btnSelectScope.TabIndex = 13
        Me.btnSelectScope.Text = "Select Scope"
        Me.btnSelectScope.UseVisualStyleBackColor = True
        '
        'lblScope
        '
        Me.lblScope.AutoSize = True
        Me.lblScope.Location = New System.Drawing.Point(120, 17)
        Me.lblScope.Name = "lblScope"
        Me.lblScope.Size = New System.Drawing.Size(103, 13)
        Me.lblScope.TabIndex = 14
        Me.lblScope.Text = "No Scope Selected!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 419)
        Me.Controls.Add(Me.lblScope)
        Me.Controls.Add(Me.btnSelectScope)
        Me.Controls.Add(Me.lvLog)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbDateTime)
        Me.Controls.Add(Me.gbSlew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "TAN Scope Utilities"
        Me.gbSlew.ResumeLayout(False)
        Me.gbSlew.PerformLayout()
        Me.gbDateTime.ResumeLayout(False)
        Me.gbDateTime.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGetMountTime As Button
    Friend WithEvents lblMountTime As Label
    Friend WithEvents btnSetMountTime As Button
    Friend WithEvents btnSlewToPos As Button
    Friend WithEvents txtSlewAz As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSlewAlt As TextBox
    Friend WithEvents chkSlewStopTracking As CheckBox
    Friend WithEvents gbSlew As GroupBox
    Friend WithEvents gbDateTime As GroupBox
    Friend WithEvents btnLoadParkCoords As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lvLog As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btnGetCurPos As Button
    Friend WithEvents btnSaveAsPark As Button
    Friend WithEvents btnSelectScope As Button
    Friend WithEvents lblScope As Label
End Class
