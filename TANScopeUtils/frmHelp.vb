﻿Public Class frmHelp
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles Me.Load
        LinkLabel1.Links.Clear()
        LinkLabel1.Links.Add(0, 99, "https://toddnelson.net")
    End Sub
End Class