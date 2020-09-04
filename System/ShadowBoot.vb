Public Class ShadowBoot
    Dim OSName As String
    Private Reverse As Boolean = False
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 5 Then
            Panel1.Visible = True
            While (Panel1.Height < 420)
                Panel1.Height += 0.6
            End While
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.ShowInTaskbar = False
        End If
        If ProgressBar1.Value = 250 Then
            Me.BackColor = Color.LightBlue
            Label4.Text = "Welcome to ClixOS."
            Timer2.Interval = 50
            Timer2.Start()

        End If
        If ProgressBar1.Value = 300 Then
            Form1.Show()
            Me.Close()

        End If
    End Sub

    Private Sub ShadowBoot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OSName = "ClixOS Bootloader"
        Label2.Text = OSName
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Reverse Then
            Label4.Left -= 5
            If Label4.Left <= Me.ClientRectangle.Left Then Reverse = False
        Else
            Label4.Left += 5
            If Label4.Right >= Me.ClientRectangle.Right Then Reverse = True
        End If

    End Sub
End Class
