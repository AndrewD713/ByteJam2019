Public Class Story3

    Dim ctr3 As Integer
    Private Sub Cont_Click(sender As Object, e As EventArgs) Handles Cont.Click
        Select Case [ctr3]
            Case 0
                TextBox1.Text = "Worried for her safety, you leave the clinic. Hopefully no one knows you stopped there"
                'TextBox1.Location = New Point(50, 100)
                'TextBox1.Height = 200
                PictureBox1.Hide()
                ctr3 += 1
                'Case 1
                '   TextBox1.Text = "I’ve been following you, the rest of the gang should be here soon. I challenge you to a duel to avenge Big Hex!"
                '  TextBox1.Location = New Point(50, 250)
                ' TextBox1.Height = 100
                'PictureBox1.Show()
                'PictureBox1.BackColor = Color.Blue
                'PictureBox1.Image = Image.FromFile("..\..\..\Assets\Enemies\Enemy.gif")
                'ctr3 += 1
            Case 1
                Dim frmTravel2 As New Travel_2
                frmTravel2.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub Story3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.SelectionStart = 0
    End Sub
End Class