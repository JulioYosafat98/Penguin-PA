Public Class Form1
    Dim PengCount As Integer = 1
    Private Sub tmrAnimation_Tick(sender As Object, e As EventArgs) Handles tmrAnimation.Tick
        Select Case PengCount
            Case 1
                PicPenguin.Image = My.Resources.Intro_1
                PengCount += 1
            Case 2
                PicPenguin.Image = My.Resources.Intro_2
                PengCount += 1
            Case 3
                PicPenguin.Image = My.Resources.Intro_3
                PengCount += 1
            Case 4
                PicPenguin.Image = My.Resources.Intro_4
                PengCount += 1
            Case 5
                PicPenguin.Image = My.Resources.Intro_4
                PengCount = 1

        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrAnimation.Start()
        Me.tmrAnimation.Interval = 3

        PicPenguin.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PicPenguin_Click(sender As Object, e As EventArgs) Handles PicPenguin.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PicPenguin.Click

    End Sub
End Class
