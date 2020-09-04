Public Class Form1
    Dim User As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimeAndDate1.StartConsept()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel1.Visible = True
        PictureBox1.Hide()
        TextBox1.Hide()
        Button2.Hide()
        While (Panel1.Height < 420)
            Panel1.Height += 10
        End While
        PictureBox1.Show()
        TextBox1.Show()
        Button2.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub FadeForm(ByVal TotalSeconds As Single)
        If TotalSeconds = 0 Then
            Me.Opacity = 1
            Exit Sub
        End If
        Dim [then] As Double = DateAndTime.Timer
        Dim difference As Double = 0
        'difference is the percentage of the total seconds elapsed
        Do While difference < 1
            Me.Opacity = difference

            difference = (DateAndTime.Timer - [then]) / TotalSeconds
            System.Threading.Thread.Sleep(10)
        Loop
        Me.Opacity = 1
    End Sub
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FadeForm(1.5)
        Button1.Visible = True
        TimeAndDate1.Visible = True
    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Desktop.Show()
        Me.Close()
    End Sub
End Class
