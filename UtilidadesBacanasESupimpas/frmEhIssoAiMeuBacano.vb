Public Class frmEhIssoAiMeuBacano

    Private Sub frmIBUtil_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub frmIBUtil_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
        Else
            Me.ShowInTaskbar = True
        End If
    End Sub

    Private Sub btnMINIZAPROTRAYMEUBACANO_Click(sender As Object, e As EventArgs) Handles btnMINIZAPROTRAYMEUBACANO.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
    End Sub

    Private Sub btnMatarJavaw_Click(sender As Object, e As EventArgs) Handles btnMatarJavaw.Click
        For Each p In Process.GetProcesses
            If p.ProcessName.ToUpper.Contains("JAVAW") Then
                p.Kill()
            End If
        Next
    End Sub

    Private Sub notifyIcon_Click(sender As Object, e As EventArgs) Handles notifyIcon.Click
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
            Me.BringToFront()
        Else
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
        End If
    End Sub

End Class
