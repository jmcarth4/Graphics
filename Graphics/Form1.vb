Public Class Form1
    Public newX As Single
    Public newY As Single
    Public maxAmplidue As Integer
    Public lastX As Single
    Public lastY As Single
    Public timerloop As Integer
    Public width1 As Integer
    Public width2 As Integer
    Public width3 As Integer
    Public width4 As Integer
    Public width5 As Integer
    Public width6 As Integer
    Public width7 As Integer
    Public width8 As Integer
    Public width9 As Integer
    Dim gndHieght As Integer
    Public vPens As Pen

    Sub draw()


        gndHieght = GndTrackBar.Value
        VRefValueLabel.Text = GndTrackBar.Value

        maxAmplidue = AmpTrackBar.Value
        MaxAmVLabel.Text = AmpTrackBar.Value

        'newY = (Rnd() * maxAmplidue) + (PictureBox1.Height / 2) - (maxAmplidue / 2)
        'newY = (Rnd() * maxAmplidue) + (gndHieght) '- (maxAmplidue / 2)
        newY = (Rnd() * maxAmplidue) + gndHieght - (maxAmplidue / 2)
        newX = timerloop

        'PictureBox1.CreateGraphics.DrawLine(Pens.White, 100, 100, newX, newY)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, 0, newX + 1, PictureBox1.Height)
        PictureBox1.CreateGraphics.DrawLine(Pens.White, lastX, lastY, newX, newY)

        'PictureBox1.CreateGraphics.DrawLine(Pens.Blue, 100, 100, timerloop, 200)



        lastX = newX
        lastY = newY


    End Sub

    'Draw horizontal division every 12.5 % of picture box hieght (7 markers)
    Sub HDiv()
        Dim hieght1 As Integer
        Dim hieght2 As Integer
        Dim hieght3 As Integer
        Dim hieght4 As Integer
        Dim hieght5 As Integer
        Dim hieght6 As Integer
        Dim hieght7 As Integer


        hieght1 = PictureBox1.Height * 0.125
        hieght2 = PictureBox1.Height * 0.25
        hieght3 = PictureBox1.Height * 0.375
        hieght4 = PictureBox1.Height * 0.5
        hieght5 = PictureBox1.Height * 0.625
        hieght6 = PictureBox1.Height * 0.75
        hieght7 = PictureBox1.Height * 0.875

        vPens = Pens.Blue

        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght1, PictureBox1.Width, hieght1)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght2, PictureBox1.Width, hieght2)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght3, PictureBox1.Width, hieght3)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght4, PictureBox1.Width, hieght4)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght5, PictureBox1.Width, hieght5)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght6, PictureBox1.Width, hieght6)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght7, PictureBox1.Width, hieght7)
    End Sub
    'Sub VRef()
    '    Dim gndHieght As Integer

    '    gndHieght = GndTrackBar.Value
    '    TrackBarValueLabel.Text = GndTrackBar.Value
    '    vPens = Pens.Orange
    '    PictureBox1.CreateGraphics.DrawLine(vPens, 0, gndHieght, PictureBox1.Width, gndHieght)
    'End Sub

    Private Sub UpButton_Click(sender As Object, e As EventArgs) Handles UpButton.Click
        If maxAmplidue > 1000 Then
            maxAmplidue = +100
        ElseIf maxAmplidue = 1000 Then

        End If
    End Sub

    Private Sub DownButton_Click(sender As Object, e As EventArgs) Handles DownButton.Click

    End Sub

    Private Sub DrawButton_Click(sender As Object, e As EventArgs) Handles DrawButton.Click
        Timer1.Enabled = True

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If timerloop > 1000 Then
            draw()
            HDiv()
            ' VRef()
            timerloop = 0
        ElseIf timerloop = width2 Or timerloop = width1 Or timerloop = width3 Or timerloop = width4 Or
            timerloop = width5 Or timerloop = width6 Or timerloop = width7 Or timerloop = width8 Or
             timerloop = width9 Then
            vPens = Pens.Blue
            draw()
            HDiv()
            ' VRef()
        ElseIf timerloop = 1 Then
            lastX = 0
            vPens = Pens.Black
            draw()
            HDiv()
            ' VRef()
        Else
            vPens = Pens.Black

            draw()
            ' VRef()
            HDiv()


        End If
        timerloop += 1
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        timerloop = 1
        width1 = PictureBox1.Width * 0.1
        width2 = PictureBox1.Width * 0.2
        width3 = PictureBox1.Width * 0.3
        width4 = PictureBox1.Width * 0.4
        width5 = PictureBox1.Width * 0.5
        width6 = PictureBox1.Width * 0.6
        width7 = PictureBox1.Width * 0.7
        width8 = PictureBox1.Width * 0.8
        width9 = PictureBox1.Width * 0.9
        GndTrackBar.Value = 160
        GndTrackBar.Maximum = PictureBox1.Height
        AmpTrackBar.Value = 100
    End Sub


End Class
