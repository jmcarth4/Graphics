﻿Public Class Form1
    Public newX As Single
    Public newY As Single
    Public maxAmplidue As Integer
    Public lastX As Single
    Public lastY As Single
    Public timerloop As Integer
    Public width1 As Integer
    Public width2 As Integer
    Public vPens As Pen

    Sub draw()
        'width = 500 'PictureBox1.Width

        maxAmplidue = 100   ' adjust with button later
        newY = (Rnd() * maxAmplidue) + (PictureBox1.Height / 2) - (maxAmplidue / 2)
        newX = timerloop
        'PictureBox1.CreateGraphics.DrawLine(Pens.White, 100, 100, newX, newY)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, 0, newX + 1, PictureBox1.Height)
        PictureBox1.CreateGraphics.DrawLine(Pens.White, lastX, lastY, newX, newY)
        'PictureBox1.CreateGraphics.DrawLine(Pens.Blue, 100, 100, timerloop, 200)
        lastX = newX
        lastY = newY
    End Sub


    Private Sub DrawButton_Click(sender As Object, e As EventArgs) Handles DrawButton.Click
        Timer1.Enabled = True

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If timerloop > 1000 Then
            'newX = 0
            draw()
            'Timer1.Enabled = False

            timerloop = 0
            'newX = 1
        ElseIf timerloop = width2 Or timerloop = width1 Then
            vPens = Pens.Blue
            'PictureBox1.CreateGraphics.DrawLine(Pens.Purple, newX + 1, 0, newX + 1, PictureBox1.Height)
            draw()
        ElseIf timerloop = 1 Then
            lastX = 0
            vPens = Pens.Black
            draw()
        Else
            vPens = Pens.Black
            draw()

        End If
        timerloop += 1
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerloop = 1
        width1 = PictureBox1.Width / 2
        width2 = PictureBox1.Width * 0.6

    End Sub
End Class
