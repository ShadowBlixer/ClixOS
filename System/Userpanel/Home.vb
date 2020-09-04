Public Class Home
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim Pos As Integer
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = 1
    Const HTCAPTION As Integer = 2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)

        Select Case m.Msg
            Case WM_NCHITTEST
                If m.Result = CType(HTCLIENT, IntPtr) Then
                    m.Result = CType(HTCAPTION, IntPtr)

                End If
        End Select
    End Sub

    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or &H40000
            Return cp
        End Get
    End Property

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Desktop.Show()
        Me.Close()
        Area1.Close()
    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Pos = Me.StartPosition
        Area1.StartPosition = Pos
        Area1.Show()
        Me.Hide()
    End Sub

    Private Sub Restart_Tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Restart_Tmr.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 50 Then
            Me.Hide()
        End If
        If ProgressBar1.Value = 100 Then
            ShadowBoot.Show()
            Me.Close()
            Desktop.Close()
            Area1.Close()

        End If
    End Sub

    Private Sub Shutdown_Tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shutdown_Tmr.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Restart_Tmr.Start()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Shutdown_Tmr.Start()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()
        Desktop.Close()
        Area1.Close()
    End Sub

    Private Sub Panel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub
End Class