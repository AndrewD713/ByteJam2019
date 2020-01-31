Public Class Story1
    Dim ctr As Integer
    Private Sub Story1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.SelectionStart = 0
    End Sub

    Private Sub Cont_Click(sender As Object, e As EventArgs) Handles Cont.Click
        Select Case [ctr]
            Case 0
                TextBox1.Text = "You have no idea who you just messed with!"
                'TextBox1.Location = New Point(50, 250)
                'TextBox1.Height = 40
                PictureBox1.Image = Image.FromFile("..\..\..\Assets\Enemies\Billy_The_Code_Loud.gif")
                PictureBox2.Image = Image.FromFile("..\..\..\Assets\Enemies\Big_Hex_Head_Quiet.gif")
                ctr += 1
            Case 1
                TextBox1.Text = "Billy, I’ll handle this! *He looks at you* The name is Big Hex. I can't have you ruining my reputation like that. Meet me at high noon on main street. We’ll settle this with a duel."
                'TextBox1.Location = New Point(50, 220)
                'TextBox1.Height = 180
                PictureBox1.Image = Image.FromFile("..\..\..\Assets\Enemies\Billy_The_Code_Quiet.gif")
                PictureBox2.Image = Image.FromFile("..\..\..\Assets\Enemies\Big_Hex_Head_Loud.gif")
                ctr += 1
            Case 2
                Dim frmQuickDraw1 As New quickdraw1
                frmQuickDraw1.Show()
                Me.Close()
        End Select
    End Sub
End Class