Public Class Credits
    Dim time As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("..\..\..\Assets\sound-effects\The Gunfight - Everet Almond.wav", AudioPlayMode.BackgroundLoop)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time + 1
        Select Case (time)
            Case 1
                lbl2.Text = "Andrew"
                lbl3.Text = "Robbie"
                lbl6.Text = "David"
                PictureBox2.Image = Image.FromFile("..\..\..\Assets\Wanted\Andrew_Wanted.jpg")
                PictureBox3.Image = Image.FromFile("..\..\..\Assets\Wanted\Robbie_Wanted.jpg")
                PictureBox6.Image = Image.FromFile("..\..\..\Assets\Wanted\David_Wanted.jpg")
            Case 10
                lbl2.Text = "Natnail"
                lbl3.Text = "Heather"
                lbl6.Text = "Benjamin"
                PictureBox2.Image = Image.FromFile("..\..\..\Assets\Wanted\Natnail_Wanted.jpg")
                PictureBox3.Image = Image.FromFile("..\..\..\Assets\Wanted\Heather_Wanted.jpg")
                PictureBox6.Image = Image.FromFile("..\..\..\Assets\Wanted\Ben.jpg")
            Case 20
                lbl2.Text = "Big Hex"
                lbl3.Text = "Billy the Code"
                lbl6.Text = "Bandana Bandit"
                PictureBox2.Image = Image.FromFile("..\..\..\Assets\Enemies\Big_Hex_Head_Loud.gif")
                PictureBox3.Image = Image.FromFile("..\..\..\Assets\Enemies\Billy_The_Code_Loud.gif")
                PictureBox6.Image = Image.FromFile("..\..\..\Assets\Enemies\Enemy_Loud.gif")
            Case 30
                lbl2.Text = "Dr.Bonnie"
                lbl3.Text = "Code Draw McGraw"
                lbl6.Text = "Nimbi"
                PictureBox2.Image = Image.FromFile("..\..\..\Assets\NPC\Dr.Bonnie_Loud.gif")
                PictureBox3.Image = Image.FromFile("..\..\..\Assets\Player\Horse_Trot.gif")
                PictureBox6.Image = Image.FromFile("..\..\..\Assets\Player\Horse_Trot_End.gif")
            Case 40
                lbl2.Text = "Cactus"
                lbl3.Text = "Coyote"
                lbl6.Text = "Rock"
                PictureBox2.Image = Image.FromFile("..\..\..\Assets\Entity\Cactus.gif")
                PictureBox3.Image = Image.FromFile("..\..\..\Assets\Entity\Cyote.gif")
                PictureBox6.Image = Image.FromFile("..\..\..\Assets\Entity\Rock.gif")
            Case 50
                lbl2.Text = "Sassy Saloon"
                lbl3.Text = "Bonnie's Clinic"
                lbl6.Text = "Code Canyon"
                PictureBox2.Image = Image.FromFile("..\..\..\Assets\Backgrounds\Bar_Scene.gif")
                PictureBox3.Image = Image.FromFile("..\..\..\Assets\Backgrounds\Clinic_Scene.gif")
                PictureBox6.Image = Image.FromFile("..\..\..\Assets\Backgrounds\Street_Scene.gif")
            Case 60
                My.Computer.Audio.Play("..\..\..\Assets\sound-effects\The Gunfight - Everet Almond.wav", AudioPlayMode.BackgroundLoop)
                Me.Close()

        End Select
    End Sub

    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        My.Computer.Audio.Play("..\..\..\Assets\sound-effects\Firefly - Chris Haugen.wav", AudioPlayMode.BackgroundLoop)
    End Sub
End Class