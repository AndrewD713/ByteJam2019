Public Class Story5
    Dim ctr As Integer
    Private Sub Cont_Click(sender As Object, e As EventArgs) Handles Cont.Click
        Select Case [ctr]
            Case 0
                TextBox1.Text = "I’m one of Big Hex’s men. I’m here to shut you up!"

                ctr += 1
            Case 1
                TextBox1.Text = "You reply: How do you plan to do that? I’ve already killed one of you!"

                ctr += 1
            Case 2
                TextBox1.Text = "If I don’t kill you, the rest of my gang will! We have that doctor of yours captured... You’ll have to come to us!"
                ctr += 1
            Case 3
                TextBox1.Text = "You reply: You Monster!"
                ctr += 1
            Case 4
                Dim frmQuickDraw2 As New quickdraw2
                frmQuickDraw2.Show()
                Me.Close()

        End Select
    End Sub

    Private Sub Story5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.SelectionStart = 0
    End Sub
End Class