<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Travel_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Travel_1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.picFinishLine = New System.Windows.Forms.PictureBox()
        Me.picObj1 = New System.Windows.Forms.PictureBox()
        Me.picChar = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picObj2 = New System.Windows.Forms.PictureBox()
        Me.picObj6 = New System.Windows.Forms.PictureBox()
        Me.picObj3 = New System.Windows.Forms.PictureBox()
        Me.picObj4 = New System.Windows.Forms.PictureBox()
        Me.picObj5 = New System.Windows.Forms.PictureBox()
        Me.picBackround = New System.Windows.Forms.PictureBox()
        CType(Me.picFinishLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObj5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackround, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.BackColor = System.Drawing.Color.Black
        Me.lblGameOver.Font = New System.Drawing.Font("Castellar", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.White
        Me.lblGameOver.Location = New System.Drawing.Point(748, 9)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(409, 78)
        Me.lblGameOver.TabIndex = 7
        Me.lblGameOver.Text = "      GAME OVER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press 'R' to restart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblGameOver.Visible = False
        '
        'picFinishLine
        '
        Me.picFinishLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picFinishLine.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.picFinishLine.Location = New System.Drawing.Point(2870, 557)
        Me.picFinishLine.Name = "picFinishLine"
        Me.picFinishLine.Size = New System.Drawing.Size(34, 438)
        Me.picFinishLine.TabIndex = 6
        Me.picFinishLine.TabStop = False
        '
        'picObj1
        '
        Me.picObj1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picObj1.BackColor = System.Drawing.Color.Goldenrod
        Me.picObj1.Image = Global.CodeDrawMcGraw.My.Resources.Resources.Cactus
        Me.picObj1.Location = New System.Drawing.Point(1040, 538)
        Me.picObj1.Name = "picObj1"
        Me.picObj1.Size = New System.Drawing.Size(85, 127)
        Me.picObj1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picObj1.TabIndex = 1
        Me.picObj1.TabStop = False
        '
        'picChar
        '
        Me.picChar.BackColor = System.Drawing.Color.Goldenrod
        Me.picChar.Image = Global.CodeDrawMcGraw.My.Resources.Resources.Horse_Trot
        Me.picChar.Location = New System.Drawing.Point(274, 902)
        Me.picChar.Name = "picChar"
        Me.picChar.Size = New System.Drawing.Size(139, 94)
        Me.picChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChar.TabIndex = 0
        Me.picChar.TabStop = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.Goldenrod
        Me.picGround.Location = New System.Drawing.Point(0, 555)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(2916, 457)
        Me.picGround.TabIndex = 5
        Me.picGround.TabStop = False
        '
        'picObj2
        '
        Me.picObj2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picObj2.BackColor = System.Drawing.Color.Goldenrod
        Me.picObj2.Image = Global.CodeDrawMcGraw.My.Resources.Resources.Rock
        Me.picObj2.Location = New System.Drawing.Point(1187, 868)
        Me.picObj2.Name = "picObj2"
        Me.picObj2.Size = New System.Drawing.Size(128, 127)
        Me.picObj2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picObj2.TabIndex = 11
        Me.picObj2.TabStop = False
        '
        'picObj6
        '
        Me.picObj6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picObj6.BackColor = System.Drawing.Color.Goldenrod
        Me.picObj6.Image = Global.CodeDrawMcGraw.My.Resources.Resources.Cyote
        Me.picObj6.Location = New System.Drawing.Point(1640, 680)
        Me.picObj6.Name = "picObj6"
        Me.picObj6.Size = New System.Drawing.Size(138, 80)
        Me.picObj6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picObj6.TabIndex = 12
        Me.picObj6.TabStop = False
        '
        'picObj3
        '
        Me.picObj3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picObj3.BackColor = System.Drawing.Color.Goldenrod
        Me.picObj3.Image = Global.CodeDrawMcGraw.My.Resources.Resources.Cactus
        Me.picObj3.Location = New System.Drawing.Point(2098, 521)
        Me.picObj3.Name = "picObj3"
        Me.picObj3.Size = New System.Drawing.Size(85, 127)
        Me.picObj3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picObj3.TabIndex = 14
        Me.picObj3.TabStop = False
        '
        'picObj4
        '
        Me.picObj4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picObj4.BackColor = System.Drawing.Color.Goldenrod
        Me.picObj4.Image = Global.CodeDrawMcGraw.My.Resources.Resources.Cactus
        Me.picObj4.Location = New System.Drawing.Point(2098, 851)
        Me.picObj4.Name = "picObj4"
        Me.picObj4.Size = New System.Drawing.Size(85, 127)
        Me.picObj4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picObj4.TabIndex = 15
        Me.picObj4.TabStop = False
        '
        'picObj5
        '
        Me.picObj5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picObj5.BackColor = System.Drawing.Color.Goldenrod
        Me.picObj5.Image = Global.CodeDrawMcGraw.My.Resources.Resources.Rock
        Me.picObj5.Location = New System.Drawing.Point(2506, 680)
        Me.picObj5.Name = "picObj5"
        Me.picObj5.Size = New System.Drawing.Size(128, 127)
        Me.picObj5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picObj5.TabIndex = 16
        Me.picObj5.TabStop = False
        '
        'picBackround
        '
        Me.picBackround.BackColor = System.Drawing.Color.Goldenrod
        Me.picBackround.BackgroundImage = Global.CodeDrawMcGraw.My.Resources.Resources.Background1
        Me.picBackround.Location = New System.Drawing.Point(0, -2)
        Me.picBackround.Name = "picBackround"
        Me.picBackround.Size = New System.Drawing.Size(2916, 570)
        Me.picBackround.TabIndex = 17
        Me.picBackround.TabStop = False
        '
        'Travel_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.picObj5)
        Me.Controls.Add(Me.picObj4)
        Me.Controls.Add(Me.picObj3)
        Me.Controls.Add(Me.picObj6)
        Me.Controls.Add(Me.picObj2)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.picFinishLine)
        Me.Controls.Add(Me.picObj1)
        Me.Controls.Add(Me.picChar)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picBackround)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Travel_1"
        Me.Text = "Code Draw McGraw"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picFinishLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObj5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackround, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picChar As PictureBox
    Friend WithEvents picObj1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picGround As PictureBox
    Friend WithEvents picFinishLine As PictureBox
    Friend WithEvents lblGameOver As Label
    Friend WithEvents picObj2 As PictureBox
    Friend WithEvents picObj6 As PictureBox
    Friend WithEvents picObj3 As PictureBox
    Friend WithEvents picObj4 As PictureBox
    Friend WithEvents picObj5 As PictureBox
    Friend WithEvents picBackround As PictureBox
End Class
