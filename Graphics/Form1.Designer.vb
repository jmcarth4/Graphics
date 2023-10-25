<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AmpButton = New System.Windows.Forms.Button()
        Me.GndTrackBar = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBarValueLabel = New System.Windows.Forms.Label()
        Me.TDLabel = New System.Windows.Forms.Label()
        Me.VDLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GndTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuitButton
        '
        Me.QuitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QuitButton.Location = New System.Drawing.Point(1078, 593)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(74, 48)
        Me.QuitButton.TabIndex = 1
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(20, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 500)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'DrawButton
        '
        Me.DrawButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DrawButton.Location = New System.Drawing.Point(20, 555)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(74, 48)
        Me.DrawButton.TabIndex = 3
        Me.DrawButton.Text = "Draw"
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'AmpButton
        '
        Me.AmpButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AmpButton.Location = New System.Drawing.Point(1038, 324)
        Me.AmpButton.Name = "AmpButton"
        Me.AmpButton.Size = New System.Drawing.Size(99, 44)
        Me.AmpButton.TabIndex = 4
        Me.AmpButton.Text = "Amplitude"
        Me.AmpButton.UseVisualStyleBackColor = True
        '
        'GndTrackBar
        '
        Me.GndTrackBar.Location = New System.Drawing.Point(633, 555)
        Me.GndTrackBar.Maximum = 500
        Me.GndTrackBar.Name = "GndTrackBar"
        Me.GndTrackBar.Size = New System.Drawing.Size(181, 69)
        Me.GndTrackBar.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(708, 525)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Voltage Reference"
        '
        'TrackBarValueLabel
        '
        Me.TrackBarValueLabel.AutoSize = True
        Me.TrackBarValueLabel.Location = New System.Drawing.Point(857, 583)
        Me.TrackBarValueLabel.Name = "TrackBarValueLabel"
        Me.TrackBarValueLabel.Size = New System.Drawing.Size(126, 20)
        Me.TrackBarValueLabel.TabIndex = 7
        Me.TrackBarValueLabel.Text = "tracker bar value"
        '
        'TDLabel
        '
        Me.TDLabel.AutoSize = True
        Me.TDLabel.Location = New System.Drawing.Point(465, 525)
        Me.TDLabel.Name = "TDLabel"
        Me.TDLabel.Size = New System.Drawing.Size(109, 20)
        Me.TDLabel.TabIndex = 8
        Me.TDLabel.Text = "Time / Division"
        '
        'VDLabel
        '
        Me.VDLabel.AutoSize = True
        Me.VDLabel.Location = New System.Drawing.Point(1026, 280)
        Me.VDLabel.Name = "VDLabel"
        Me.VDLabel.Size = New System.Drawing.Size(111, 20)
        Me.VDLabel.TabIndex = 9
        Me.VDLabel.Text = "Volts / Division"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1038, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 44)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(491, 583)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Voltage reference"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 653)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VDLabel)
        Me.Controls.Add(Me.TDLabel)
        Me.Controls.Add(Me.TrackBarValueLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GndTrackBar)
        Me.Controls.Add(Me.AmpButton)
        Me.Controls.Add(Me.DrawButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.QuitButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GndTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuitButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DrawButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AmpButton As Button
    Friend WithEvents GndTrackBar As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBarValueLabel As Label
    Friend WithEvents TDLabel As Label
    Friend WithEvents VDLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
