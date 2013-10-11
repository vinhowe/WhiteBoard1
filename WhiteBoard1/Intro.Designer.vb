<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Intro))
        Me.BeginLabel = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.specialInfo = New System.Windows.Forms.Label()
        Me.LogoBox = New System.Windows.Forms.PictureBox()
        Me.Backpanelintro = New System.Windows.Forms.Panel()
        Me.DividerIntro = New System.Windows.Forms.Label()
        Me.About_Button_Main = New System.Windows.Forms.Button()
        Me.BoardsButton = New System.Windows.Forms.Button()
        Me.BoardsPanel = New System.Windows.Forms.Panel()
        Me.Boardlistbox = New System.Windows.Forms.ListBox()
        Me.NewBoardButton = New System.Windows.Forms.Button()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Backpanelintro.SuspendLayout()
        Me.BoardsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BeginLabel
        '
        Me.BeginLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BeginLabel.BackColor = System.Drawing.Color.Transparent
        Me.BeginLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginLabel.Location = New System.Drawing.Point(3, 289)
        Me.BeginLabel.Name = "BeginLabel"
        Me.BeginLabel.Size = New System.Drawing.Size(501, 25)
        Me.BeginLabel.TabIndex = 4
        Me.BeginLabel.Text = "Online Note board collaboration application" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BeginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Copyright.Location = New System.Drawing.Point(3, 424)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(51, 13)
        Me.Copyright.TabIndex = 5
        Me.Copyright.Text = "Copyright"
        '
        'specialInfo
        '
        Me.specialInfo.AutoSize = True
        Me.specialInfo.BackColor = System.Drawing.Color.Transparent
        Me.specialInfo.Font = New System.Drawing.Font("Consolas", 7.25!)
        Me.specialInfo.Location = New System.Drawing.Point(3, 11)
        Me.specialInfo.Name = "specialInfo"
        Me.specialInfo.Size = New System.Drawing.Size(60, 12)
        Me.specialInfo.TabIndex = 7
        Me.specialInfo.Text = "specialInfo"
        '
        'LogoBox
        '
        Me.LogoBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoBox.Image = Global.SparkONCA.My.Resources.Resources.SparkDefault
        Me.LogoBox.Location = New System.Drawing.Point(0, 27)
        Me.LogoBox.Name = "LogoBox"
        Me.LogoBox.Size = New System.Drawing.Size(507, 259)
        Me.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoBox.TabIndex = 8
        Me.LogoBox.TabStop = False
        '
        'Backpanelintro
        '
        Me.Backpanelintro.Controls.Add(Me.BoardsPanel)
        Me.Backpanelintro.Controls.Add(Me.DividerIntro)
        Me.Backpanelintro.Controls.Add(Me.About_Button_Main)
        Me.Backpanelintro.Controls.Add(Me.BoardsButton)
        Me.Backpanelintro.Controls.Add(Me.Copyright)
        Me.Backpanelintro.Controls.Add(Me.BeginLabel)
        Me.Backpanelintro.Controls.Add(Me.specialInfo)
        Me.Backpanelintro.Controls.Add(Me.LogoBox)
        Me.Backpanelintro.Location = New System.Drawing.Point(130, -2)
        Me.Backpanelintro.Name = "Backpanelintro"
        Me.Backpanelintro.Size = New System.Drawing.Size(507, 447)
        Me.Backpanelintro.TabIndex = 9
        '
        'DividerIntro
        '
        Me.DividerIntro.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DividerIntro.Location = New System.Drawing.Point(78, 327)
        Me.DividerIntro.Name = "DividerIntro"
        Me.DividerIntro.Size = New System.Drawing.Size(350, 1)
        Me.DividerIntro.TabIndex = 15
        '
        'About_Button_Main
        '
        Me.About_Button_Main.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.About_Button_Main.BackColor = System.Drawing.SystemColors.Control
        Me.About_Button_Main.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.About_Button_Main.FlatAppearance.BorderSize = 0
        Me.About_Button_Main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.About_Button_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.About_Button_Main.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.About_Button_Main.Location = New System.Drawing.Point(255, 343)
        Me.About_Button_Main.Name = "About_Button_Main"
        Me.About_Button_Main.Size = New System.Drawing.Size(103, 29)
        Me.About_Button_Main.TabIndex = 14
        Me.About_Button_Main.Text = "About"
        Me.About_Button_Main.UseVisualStyleBackColor = False
        '
        'BoardsButton
        '
        Me.BoardsButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoardsButton.BackColor = System.Drawing.SystemColors.Control
        Me.BoardsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BoardsButton.FlatAppearance.BorderSize = 0
        Me.BoardsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.BoardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BoardsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.BoardsButton.Location = New System.Drawing.Point(151, 343)
        Me.BoardsButton.Name = "BoardsButton"
        Me.BoardsButton.Size = New System.Drawing.Size(98, 29)
        Me.BoardsButton.TabIndex = 12
        Me.BoardsButton.Text = "Boards"
        Me.BoardsButton.UseVisualStyleBackColor = False
        '
        'BoardsPanel
        '
        Me.BoardsPanel.Controls.Add(Me.NewBoardButton)
        Me.BoardsPanel.Controls.Add(Me.Boardlistbox)
        Me.BoardsPanel.Location = New System.Drawing.Point(0, 0)
        Me.BoardsPanel.Name = "BoardsPanel"
        Me.BoardsPanel.Size = New System.Drawing.Size(507, 447)
        Me.BoardsPanel.TabIndex = 16
        Me.BoardsPanel.Visible = False
        '
        'Boardlistbox
        '
        Me.Boardlistbox.FormattingEnabled = True
        Me.Boardlistbox.Location = New System.Drawing.Point(23, 45)
        Me.Boardlistbox.Name = "Boardlistbox"
        Me.Boardlistbox.Size = New System.Drawing.Size(461, 381)
        Me.Boardlistbox.TabIndex = 0
        '
        'NewBoardButton
        '
        Me.NewBoardButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewBoardButton.BackColor = System.Drawing.SystemColors.Control
        Me.NewBoardButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.NewBoardButton.FlatAppearance.BorderSize = 0
        Me.NewBoardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.NewBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewBoardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.NewBoardButton.Location = New System.Drawing.Point(23, 10)
        Me.NewBoardButton.Name = "NewBoardButton"
        Me.NewBoardButton.Size = New System.Drawing.Size(98, 29)
        Me.NewBoardButton.TabIndex = 13
        Me.NewBoardButton.Text = "New board"
        Me.NewBoardButton.UseVisualStyleBackColor = False
        '
        'Intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SparkONCA.My.Resources.Resources.IntroBackgroundImage1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(767, 444)
        Me.Controls.Add(Me.Backpanelintro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Intro"
        Me.Text = "Spark"
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Backpanelintro.ResumeLayout(False)
        Me.Backpanelintro.PerformLayout()
        Me.BoardsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BeginLabel As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents specialInfo As System.Windows.Forms.Label
    Friend WithEvents LogoBox As System.Windows.Forms.PictureBox
    Friend WithEvents Backpanelintro As System.Windows.Forms.Panel
    Friend WithEvents BoardsButton As System.Windows.Forms.Button
    Friend WithEvents About_Button_Main As System.Windows.Forms.Button
    Friend WithEvents DividerIntro As System.Windows.Forms.Label
    Friend WithEvents BoardsPanel As System.Windows.Forms.Panel
    Friend WithEvents Boardlistbox As System.Windows.Forms.ListBox
    Friend WithEvents NewBoardButton As System.Windows.Forms.Button

End Class
