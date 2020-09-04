<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.Logoff = New System.Windows.Forms.Button()
        Me.Shutdown = New System.Windows.Forms.Button()
        Me.Restart = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Restart_Tmr = New System.Windows.Forms.Timer(Me.components)
        Me.Shutdown_Tmr = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateFinder = New System.Windows.Forms.Timer(Me.components)
        Me.TimeAndDate4 = New ClixOS.TimeAndDate()
        Me.TimeAndDate3 = New ClixOS.TimeAndDate()
        Me.TimeAndDate2 = New ClixOS.TimeAndDate()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username: "
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.BackColor = System.Drawing.Color.Transparent
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Username.Location = New System.Drawing.Point(105, 9)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(100, 20)
        Me.Username.TabIndex = 2
        Me.Username.Text = "defultuser0"
        '
        'Logoff
        '
        Me.Logoff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Logoff.Location = New System.Drawing.Point(1299, 9)
        Me.Logoff.Name = "Logoff"
        Me.Logoff.Size = New System.Drawing.Size(75, 23)
        Me.Logoff.TabIndex = 3
        Me.Logoff.Text = "Logoff"
        Me.Logoff.UseVisualStyleBackColor = True
        '
        'Shutdown
        '
        Me.Shutdown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Shutdown.Location = New System.Drawing.Point(1218, 9)
        Me.Shutdown.Name = "Shutdown"
        Me.Shutdown.Size = New System.Drawing.Size(75, 23)
        Me.Shutdown.TabIndex = 5
        Me.Shutdown.Text = "Shutdown"
        Me.Shutdown.UseVisualStyleBackColor = True
        '
        'Restart
        '
        Me.Restart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Restart.Location = New System.Drawing.Point(1137, 9)
        Me.Restart.Name = "Restart"
        Me.Restart.Size = New System.Drawing.Size(75, 23)
        Me.Restart.TabIndex = 6
        Me.Restart.Text = "Restart"
        Me.Restart.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(461, 626)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(181, 23)
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Visible = False
        '
        'Restart_Tmr
        '
        '
        'Shutdown_Tmr
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-1, 665)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ClixOS Alpha 1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 5
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(16, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "PowerCore"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.BorderSize = 5
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(16, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "UserPanel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DateLabel)
        Me.Panel1.Controls.Add(Me.Time)
        Me.Panel1.Controls.Add(Me.TimeAndDate4)
        Me.Panel1.Controls.Add(Me.TimeAndDate3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TimeAndDate2)
        Me.Panel1.Location = New System.Drawing.Point(1228, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(156, 738)
        Me.Panel1.TabIndex = 16
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.Color.Transparent
        Me.DateLabel.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.DateLabel.ForeColor = System.Drawing.Color.Black
        Me.DateLabel.Location = New System.Drawing.Point(9, 584)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(59, 27)
        Me.DateLabel.TabIndex = 18
        Me.DateLabel.Text = "date"
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Time.ForeColor = System.Drawing.Color.Black
        Me.Time.Location = New System.Drawing.Point(7, 559)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(113, 27)
        Me.Time.TabIndex = 17
        Me.Time.Text = "12:00 PM"
        '
        'Timer1
        '
        '
        'DateFinder
        '
        '
        'TimeAndDate4
        '
        Me.TimeAndDate4.AutoSize = True
        Me.TimeAndDate4.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TimeAndDate4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeAndDate4.ForeColor = System.Drawing.Color.Black
        Me.TimeAndDate4.Location = New System.Drawing.Point(27, 47)
        Me.TimeAndDate4.Name = "TimeAndDate4"
        Me.TimeAndDate4.Size = New System.Drawing.Size(97, 24)
        Me.TimeAndDate4.TabIndex = 17
        Me.TimeAndDate4.Text = "UserPanel"
        '
        'TimeAndDate3
        '
        Me.TimeAndDate3.AutoSize = True
        Me.TimeAndDate3.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TimeAndDate3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeAndDate3.ForeColor = System.Drawing.Color.Black
        Me.TimeAndDate3.Location = New System.Drawing.Point(25, 19)
        Me.TimeAndDate3.Name = "TimeAndDate3"
        Me.TimeAndDate3.Size = New System.Drawing.Size(105, 24)
        Me.TimeAndDate3.TabIndex = 15
        Me.TimeAndDate3.Text = "PowerCore"
        '
        'TimeAndDate2
        '
        Me.TimeAndDate2.AutoSize = True
        Me.TimeAndDate2.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TimeAndDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeAndDate2.ForeColor = System.Drawing.Color.Black
        Me.TimeAndDate2.Location = New System.Drawing.Point(8, 25)
        Me.TimeAndDate2.Name = "TimeAndDate2"
        Me.TimeAndDate2.Size = New System.Drawing.Size(140, 24)
        Me.TimeAndDate2.TabIndex = 16
        Me.TimeAndDate2.Text = "_____________"
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClixOS.My.Resources.Resources.BETAshell___background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Restart)
        Me.Controls.Add(Me.Shutdown)
        Me.Controls.Add(Me.Logoff)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Desktop"
        Me.ShowInTaskbar = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents Logoff As System.Windows.Forms.Button
    Friend WithEvents Shutdown As System.Windows.Forms.Button
    Friend WithEvents Restart As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Restart_Tmr As System.Windows.Forms.Timer
    Friend WithEvents Shutdown_Tmr As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TimeAndDate3 As ClixOS.TimeAndDate
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TimeAndDate2 As ClixOS.TimeAndDate
    Friend WithEvents TimeAndDate4 As ClixOS.TimeAndDate
    Friend WithEvents Time As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DateFinder As System.Windows.Forms.Timer
    Friend WithEvents DateLabel As System.Windows.Forms.Label
End Class
