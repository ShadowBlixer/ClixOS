Public Class TimeAndDate
    Inherits Label
    Friend WithEvents FadeButton As System.Windows.Forms.Button
    Private timer As Timer
    Dim Calibri As Drawing.Font

    Public Sub New()
        timer = New Timer
        timer.Interval = 1
        AddHandler timer.Tick, AddressOf Timer_Tick
        Me.BackColor = Color.Transparent
        Me.ForeColor = Color.White
    End Sub
    Public Sub Timer_Tick()
        Dim DateAndTime As Date = Date.Now.ToString("dd/MM/yyyy  hh:mm:ss tt")
        Me.Text = DateAndTime
    End Sub
    Public Sub StartConsept()
        timer.Enabled = True
        timer.Start()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.ResumeLayout(False)

    End Sub
End Class