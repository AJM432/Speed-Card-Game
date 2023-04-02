<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpeed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpeed))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.picCentreLeft = New System.Windows.Forms.PictureBox()
        Me.picCentreRight = New System.Windows.Forms.PictureBox()
        Me.picLeft = New System.Windows.Forms.PictureBox()
        Me.picRight = New System.Windows.Forms.PictureBox()
        Me.picPlayerCard3 = New System.Windows.Forms.PictureBox()
        Me.picPlayerCard0 = New System.Windows.Forms.PictureBox()
        Me.picPlayerCard2 = New System.Windows.Forms.PictureBox()
        Me.picPlayerCard1 = New System.Windows.Forms.PictureBox()
        Me.picPlayerCard4 = New System.Windows.Forms.PictureBox()
        Me.btnCannotGo = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblStats = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToPlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenFeltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueSuitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleAbstractToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        CType(Me.picCentreLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCentreRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCard0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.AutoSize = True
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BackgroundImage = Global.Speed.My.Resources.Resources.wood
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnStart.Location = New System.Drawing.Point(957, 136)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(129, 53)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'picCentreLeft
        '
        Me.picCentreLeft.BackColor = System.Drawing.Color.Transparent
        Me.picCentreLeft.Location = New System.Drawing.Point(713, 283)
        Me.picCentreLeft.Name = "picCentreLeft"
        Me.picCentreLeft.Size = New System.Drawing.Size(176, 239)
        Me.picCentreLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCentreLeft.TabIndex = 1
        Me.picCentreLeft.TabStop = False
        Me.picCentreLeft.Visible = False
        '
        'picCentreRight
        '
        Me.picCentreRight.BackColor = System.Drawing.Color.Transparent
        Me.picCentreRight.Location = New System.Drawing.Point(957, 283)
        Me.picCentreRight.Name = "picCentreRight"
        Me.picCentreRight.Size = New System.Drawing.Size(176, 239)
        Me.picCentreRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCentreRight.TabIndex = 2
        Me.picCentreRight.TabStop = False
        Me.picCentreRight.Visible = False
        '
        'picLeft
        '
        Me.picLeft.BackColor = System.Drawing.Color.Transparent
        Me.picLeft.Image = Global.Speed.My.Resources.Resources.Cardblue_back
        Me.picLeft.Location = New System.Drawing.Point(469, 283)
        Me.picLeft.Name = "picLeft"
        Me.picLeft.Size = New System.Drawing.Size(176, 239)
        Me.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLeft.TabIndex = 3
        Me.picLeft.TabStop = False
        Me.picLeft.Visible = False
        '
        'picRight
        '
        Me.picRight.BackColor = System.Drawing.Color.Transparent
        Me.picRight.Image = Global.Speed.My.Resources.Resources.Cardblue_back
        Me.picRight.Location = New System.Drawing.Point(1201, 283)
        Me.picRight.Name = "picRight"
        Me.picRight.Size = New System.Drawing.Size(176, 239)
        Me.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRight.TabIndex = 4
        Me.picRight.TabStop = False
        Me.picRight.Visible = False
        '
        'picPlayerCard3
        '
        Me.picPlayerCard3.BackColor = System.Drawing.Color.Transparent
        Me.picPlayerCard3.Location = New System.Drawing.Point(1079, 588)
        Me.picPlayerCard3.Name = "picPlayerCard3"
        Me.picPlayerCard3.Size = New System.Drawing.Size(176, 239)
        Me.picPlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayerCard3.TabIndex = 8
        Me.picPlayerCard3.TabStop = False
        Me.picPlayerCard3.Visible = False
        '
        'picPlayerCard0
        '
        Me.picPlayerCard0.BackColor = System.Drawing.Color.Transparent
        Me.picPlayerCard0.Location = New System.Drawing.Point(347, 588)
        Me.picPlayerCard0.Name = "picPlayerCard0"
        Me.picPlayerCard0.Size = New System.Drawing.Size(176, 239)
        Me.picPlayerCard0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayerCard0.TabIndex = 7
        Me.picPlayerCard0.TabStop = False
        Me.picPlayerCard0.Visible = False
        '
        'picPlayerCard2
        '
        Me.picPlayerCard2.BackColor = System.Drawing.Color.Transparent
        Me.picPlayerCard2.Location = New System.Drawing.Point(835, 588)
        Me.picPlayerCard2.Name = "picPlayerCard2"
        Me.picPlayerCard2.Size = New System.Drawing.Size(176, 239)
        Me.picPlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayerCard2.TabIndex = 6
        Me.picPlayerCard2.TabStop = False
        Me.picPlayerCard2.Visible = False
        '
        'picPlayerCard1
        '
        Me.picPlayerCard1.BackColor = System.Drawing.Color.Transparent
        Me.picPlayerCard1.Location = New System.Drawing.Point(591, 588)
        Me.picPlayerCard1.Name = "picPlayerCard1"
        Me.picPlayerCard1.Size = New System.Drawing.Size(176, 239)
        Me.picPlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayerCard1.TabIndex = 5
        Me.picPlayerCard1.TabStop = False
        Me.picPlayerCard1.Visible = False
        '
        'picPlayerCard4
        '
        Me.picPlayerCard4.BackColor = System.Drawing.Color.Transparent
        Me.picPlayerCard4.Location = New System.Drawing.Point(1323, 588)
        Me.picPlayerCard4.Name = "picPlayerCard4"
        Me.picPlayerCard4.Size = New System.Drawing.Size(176, 239)
        Me.picPlayerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayerCard4.TabIndex = 9
        Me.picPlayerCard4.TabStop = False
        Me.picPlayerCard4.Visible = False
        '
        'btnCannotGo
        '
        Me.btnCannotGo.BackColor = System.Drawing.Color.Transparent
        Me.btnCannotGo.BackgroundImage = Global.Speed.My.Resources.Resources.wood
        Me.btnCannotGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCannotGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCannotGo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnCannotGo.Location = New System.Drawing.Point(1126, 136)
        Me.btnCannotGo.Name = "btnCannotGo"
        Me.btnCannotGo.Size = New System.Drawing.Size(129, 53)
        Me.btnCannotGo.TabIndex = 10
        Me.btnCannotGo.Text = "Cannot Go"
        Me.btnCannotGo.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'lblStats
        '
        Me.lblStats.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStats.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStats.Location = New System.Drawing.Point(1424, 136)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(191, 179)
        Me.lblStats.TabIndex = 12
        Me.lblStats.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1540, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToPlayToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HowToPlayToolStripMenuItem
        '
        Me.HowToPlayToolStripMenuItem.Name = "HowToPlayToolStripMenuItem"
        Me.HowToPlayToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.HowToPlayToolStripMenuItem.Text = "How To Play"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreenFeltToolStripMenuItem, Me.BlueSuitsToolStripMenuItem, Me.PurpleAbstractToolStripMenuItem})
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'GreenFeltToolStripMenuItem
        '
        Me.GreenFeltToolStripMenuItem.Name = "GreenFeltToolStripMenuItem"
        Me.GreenFeltToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.GreenFeltToolStripMenuItem.Tag = "Green"
        Me.GreenFeltToolStripMenuItem.Text = "Green Felt"
        '
        'BlueSuitsToolStripMenuItem
        '
        Me.BlueSuitsToolStripMenuItem.Name = "BlueSuitsToolStripMenuItem"
        Me.BlueSuitsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.BlueSuitsToolStripMenuItem.Tag = "Blue"
        Me.BlueSuitsToolStripMenuItem.Text = "Blue Suits"
        '
        'PurpleAbstractToolStripMenuItem
        '
        Me.PurpleAbstractToolStripMenuItem.Name = "PurpleAbstractToolStripMenuItem"
        Me.PurpleAbstractToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PurpleAbstractToolStripMenuItem.Tag = "Purple"
        Me.PurpleAbstractToolStripMenuItem.Text = "Purple Abstract"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Speed.My.Resources.Resources.StopWatch
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(207, 153)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 164)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.Black
        Me.lblTimer.Font = New System.Drawing.Font("Cambria", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Red
        Me.lblTimer.Location = New System.Drawing.Point(242, 216)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(83, 62)
        Me.lblTimer.TabIndex = 15
        Me.lblTimer.Text = "0.0"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSpeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Speed.My.Resources.Resources.CardBoardBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1540, 753)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.btnCannotGo)
        Me.Controls.Add(Me.picPlayerCard4)
        Me.Controls.Add(Me.picPlayerCard3)
        Me.Controls.Add(Me.picPlayerCard0)
        Me.Controls.Add(Me.picPlayerCard2)
        Me.Controls.Add(Me.picPlayerCard1)
        Me.Controls.Add(Me.picRight)
        Me.Controls.Add(Me.picLeft)
        Me.Controls.Add(Me.picCentreRight)
        Me.Controls.Add(Me.picCentreLeft)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Cambria", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSpeed"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picCentreLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCentreRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCard0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCard4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents picCentreLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picCentreRight As System.Windows.Forms.PictureBox
    Friend WithEvents picLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picRight As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerCard0 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerCard4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCannotGo As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblStats As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToPlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenFeltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueSuitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurpleAbstractToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTimer As System.Windows.Forms.Label

End Class
