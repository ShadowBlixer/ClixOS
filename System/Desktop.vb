Public Class Desktop
    Dim DateAndTime As Date
    Private Sub Desktop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Username.Text = Form1.TextBox1.Text
        Timer1.Start()
        DateFinder.Start()
    End Sub

    Private Sub Restart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Restart.Click
        Restart_Tmr.Start()

    End Sub

    Private Sub Restart_Tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Restart_Tmr.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 50 Then
            Me.Hide()
        End If
        If ProgressBar1.Value = 100 Then
            ShadowBoot.Show()
            Me.Close()
            Home.Close()
            Area1.Close()
        End If
    End Sub

    Private Sub Shutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shutdown.Click
        Shutdown_Tmr.Start()
    End Sub

    Private Sub Shutdown_Tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shutdown_Tmr.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Application.Exit()
        End If
    End Sub

    Private Sub Logoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logoff.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Home.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub TimeAndDate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Home.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DateAndTime = Date.Now.ToString("hh:mm:ss tt")
        Time.Text = DateAndTime
    End Sub

    Private Sub DateFinder_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateFinder.Tick
        Dim EndSOD As Date = Date.Now.ToString("dd/MM/yyyy")
        DateLabel.Text = EndSOD
    End Sub
End Class