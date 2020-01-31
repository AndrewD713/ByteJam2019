<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class quickdraw3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quickdraw3))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.picbox_Bad2 = New System.Windows.Forms.PictureBox()
        Me.picbox_Bad1 = New System.Windows.Forms.PictureBox()
        CType(Me.picbox_Bad2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_Bad1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
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
        Me.lblGameOver.TabIndex = 8
        Me.lblGameOver.Text = "      GAME OVER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press 'R' to restart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblGameOver.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 750
        '
        'Timer4
        '
        Me.Timer4.Interval = 400
        '
        'picbox_Bad2
        '
        Me.picbox_Bad2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picbox_Bad2.BackColor = System.Drawing.Color.Transparent
        Me.picbox_Bad2.Image = Global.CodeDrawMcGraw.My.Resources.Resources.Bandana_Bandit_Static
        Me.picbox_Bad2.Location = New System.Drawing.Point(1001, 346)
        Me.picbox_Bad2.Name = "picbox_Bad2"
        Me.picbox_Bad2.Size = New System.Drawing.Size(401, 698)
        Me.picbox_Bad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox_Bad2.TabIndex = 9
        Me.picbox_Bad2.TabStop = False
        '
        'picbox_Bad1
        '
        Me.picbox_Bad1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picbox_Bad1.BackColor = System.Drawing.Color.Transparent
        Me.picbox_Bad1.Image = Global.CodeDrawMcGraw.My.Resources.Resources.Bandana_Bandit_Static
        Me.picbox_Bad1.Location = New System.Drawing.Point(503, 346)
        Me.picbox_Bad1.Name = "picbox_Bad1"
        Me.picbox_Bad1.Size = New System.Drawing.Size(401, 698)
        Me.picbox_Bad1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox_Bad1.TabIndex = 4
        Me.picbox_Bad1.TabStop = False
        '
        'quickdraw3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CodeDrawMcGraw.My.Resources.Resources.Background_Night
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.picbox_Bad2)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.picbox_Bad1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "quickdraw3"
        Me.Text = "Code Draw McGraw"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picbox_Bad2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_Bad1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picbox_Bad1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblGameOver As Label
    Friend WithEvents picbox_Bad2 As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
End Class
