<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tile))
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TopBorder = New System.Windows.Forms.Panel()
        Me.TileNameLabel = New System.Windows.Forms.Label()
        Me.RightTopBorderButton = New System.Windows.Forms.Panel()
        Me.ImageAddDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BasicDesc = New System.Windows.Forms.Panel()
        Me.ExpandButton = New System.Windows.Forms.Button()
        Me.Sdescbox = New System.Windows.Forms.TextBox()
        Me.ExpandedInfo = New System.Windows.Forms.Panel()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.Ldescbox = New System.Windows.Forms.TextBox()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.TimeInfo = New System.Windows.Forms.TextBox()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.DateInfo = New System.Windows.Forms.TextBox()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.UserInfo = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameInfo = New System.Windows.Forms.TextBox()
        Me.SweepingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LeftmostLowerUpperPanel = New System.Windows.Forms.Panel()
        Me.RightMostPanelLowerUpper = New System.Windows.Forms.Panel()
        Me.BottomMostPanel = New System.Windows.Forms.Panel()
        Me.NameUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ExpandImageButton = New System.Windows.Forms.Button()
        Me.IdeaBox = New System.Windows.Forms.PictureBox()
        Me.TopPanel.SuspendLayout()
        Me.BasicDesc.SuspendLayout()
        Me.ExpandedInfo.SuspendLayout()
        CType(Me.IdeaBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.TopBorder)
        Me.TopPanel.Controls.Add(Me.TileNameLabel)
        Me.TopPanel.Controls.Add(Me.RightTopBorderButton)
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(480, 22)
        Me.TopPanel.TabIndex = 0
        '
        'TopBorder
        '
        Me.TopBorder.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TopBorder.Location = New System.Drawing.Point(1, 0)
        Me.TopBorder.Name = "TopBorder"
        Me.TopBorder.Size = New System.Drawing.Size(480, 1)
        Me.TopBorder.TabIndex = 10
        '
        'TileNameLabel
        '
        Me.TileNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.TileNameLabel.Location = New System.Drawing.Point(6, 0)
        Me.TileNameLabel.Name = "TileNameLabel"
        Me.TileNameLabel.Size = New System.Drawing.Size(240, 22)
        Me.TileNameLabel.TabIndex = 9
        Me.TileNameLabel.Text = "Name"
        Me.TileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RightTopBorderButton
        '
        Me.RightTopBorderButton.BackColor = System.Drawing.Color.Black
        Me.RightTopBorderButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightTopBorderButton.Location = New System.Drawing.Point(479, 0)
        Me.RightTopBorderButton.Name = "RightTopBorderButton"
        Me.RightTopBorderButton.Size = New System.Drawing.Size(1, 22)
        Me.RightTopBorderButton.TabIndex = 9
        '
        'ImageAddDialog
        '
        Me.ImageAddDialog.DefaultExt = "*.svg"
        Me.ImageAddDialog.Filter = "Image Files| *.jpg; *.png; *.svg; *.gif|All Files|*.*"
        '
        'BasicDesc
        '
        Me.BasicDesc.BackColor = System.Drawing.SystemColors.Control
        Me.BasicDesc.Controls.Add(Me.ExpandButton)
        Me.BasicDesc.Controls.Add(Me.Sdescbox)
        Me.BasicDesc.Location = New System.Drawing.Point(1, 239)
        Me.BasicDesc.Name = "BasicDesc"
        Me.BasicDesc.Size = New System.Drawing.Size(238, 70)
        Me.BasicDesc.TabIndex = 5
        '
        'ExpandButton
        '
        Me.ExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ExpandButton.FlatAppearance.BorderSize = 0
        Me.ExpandButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ExpandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExpandButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandButton.Image = Global.SparkONCA.My.Resources.Resources.BarOpen
        Me.ExpandButton.Location = New System.Drawing.Point(224, -1)
        Me.ExpandButton.Name = "ExpandButton"
        Me.ExpandButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExpandButton.Size = New System.Drawing.Size(14, 72)
        Me.ExpandButton.TabIndex = 1
        Me.ExpandButton.UseVisualStyleBackColor = False
        '
        'Sdescbox
        '
        Me.Sdescbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Sdescbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sdescbox.Location = New System.Drawing.Point(-1, -1)
        Me.Sdescbox.Multiline = True
        Me.Sdescbox.Name = "Sdescbox"
        Me.Sdescbox.Size = New System.Drawing.Size(225, 72)
        Me.Sdescbox.TabIndex = 0
        '
        'ExpandedInfo
        '
        Me.ExpandedInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ExpandedInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ExpandedInfo.Controls.Add(Me.DescriptionLabel)
        Me.ExpandedInfo.Controls.Add(Me.Ldescbox)
        Me.ExpandedInfo.Controls.Add(Me.TimeLabel)
        Me.ExpandedInfo.Controls.Add(Me.TimeInfo)
        Me.ExpandedInfo.Controls.Add(Me.DateLabel)
        Me.ExpandedInfo.Controls.Add(Me.DateInfo)
        Me.ExpandedInfo.Controls.Add(Me.UserLabel)
        Me.ExpandedInfo.Controls.Add(Me.UserInfo)
        Me.ExpandedInfo.Controls.Add(Me.NameLabel)
        Me.ExpandedInfo.Controls.Add(Me.NameInfo)
        Me.ExpandedInfo.Location = New System.Drawing.Point(240, 22)
        Me.ExpandedInfo.Name = "ExpandedInfo"
        Me.ExpandedInfo.Size = New System.Drawing.Size(241, 288)
        Me.ExpandedInfo.TabIndex = 6
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(6, 111)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        Me.DescriptionLabel.TabIndex = 8
        Me.DescriptionLabel.Text = "Description:"
        '
        'Ldescbox
        '
        Me.Ldescbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Ldescbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ldescbox.Location = New System.Drawing.Point(5, 127)
        Me.Ldescbox.Multiline = True
        Me.Ldescbox.Name = "Ldescbox"
        Me.Ldescbox.Size = New System.Drawing.Size(230, 156)
        Me.Ldescbox.TabIndex = 1
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(6, 84)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(33, 13)
        Me.TimeLabel.TabIndex = 7
        Me.TimeLabel.Text = "Time:"
        '
        'TimeInfo
        '
        Me.TimeInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TimeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeInfo.Location = New System.Drawing.Point(50, 81)
        Me.TimeInfo.Name = "TimeInfo"
        Me.TimeInfo.ReadOnly = True
        Me.TimeInfo.Size = New System.Drawing.Size(132, 20)
        Me.TimeInfo.TabIndex = 6
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(6, 58)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(33, 13)
        Me.DateLabel.TabIndex = 5
        Me.DateLabel.Text = "Date:"
        '
        'DateInfo
        '
        Me.DateInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DateInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateInfo.Location = New System.Drawing.Point(50, 55)
        Me.DateInfo.Name = "DateInfo"
        Me.DateInfo.ReadOnly = True
        Me.DateInfo.Size = New System.Drawing.Size(132, 20)
        Me.DateInfo.TabIndex = 4
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Location = New System.Drawing.Point(6, 32)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(32, 13)
        Me.UserLabel.TabIndex = 3
        Me.UserLabel.Text = "User:"
        '
        'UserInfo
        '
        Me.UserInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.UserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserInfo.Location = New System.Drawing.Point(50, 29)
        Me.UserInfo.Name = "UserInfo"
        Me.UserInfo.Size = New System.Drawing.Size(132, 20)
        Me.UserInfo.TabIndex = 2
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 6)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(38, 13)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name:"
        '
        'NameInfo
        '
        Me.NameInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.NameInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameInfo.Location = New System.Drawing.Point(50, 3)
        Me.NameInfo.Name = "NameInfo"
        Me.NameInfo.Size = New System.Drawing.Size(132, 20)
        Me.NameInfo.TabIndex = 0
        '
        'SweepingTimer
        '
        Me.SweepingTimer.Interval = 1
        '
        'LeftmostLowerUpperPanel
        '
        Me.LeftmostLowerUpperPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LeftmostLowerUpperPanel.Location = New System.Drawing.Point(1, -1)
        Me.LeftmostLowerUpperPanel.Name = "LeftmostLowerUpperPanel"
        Me.LeftmostLowerUpperPanel.Size = New System.Drawing.Size(1, 310)
        Me.LeftmostLowerUpperPanel.TabIndex = 7
        '
        'RightMostPanelLowerUpper
        '
        Me.RightMostPanelLowerUpper.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RightMostPanelLowerUpper.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightMostPanelLowerUpper.Location = New System.Drawing.Point(479, 0)
        Me.RightMostPanelLowerUpper.Name = "RightMostPanelLowerUpper"
        Me.RightMostPanelLowerUpper.Size = New System.Drawing.Size(1, 310)
        Me.RightMostPanelLowerUpper.TabIndex = 8
        '
        'BottomMostPanel
        '
        Me.BottomMostPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BottomMostPanel.Location = New System.Drawing.Point(1, 309)
        Me.BottomMostPanel.Name = "BottomMostPanel"
        Me.BottomMostPanel.Size = New System.Drawing.Size(480, 1)
        Me.BottomMostPanel.TabIndex = 10
        '
        'NameUpdateTimer
        '
        Me.NameUpdateTimer.Enabled = True
        Me.NameUpdateTimer.Interval = 500
        '
        'ExpandImageButton
        '
        Me.ExpandImageButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpandImageButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ExpandImageButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.ExpandImageButton.FlatAppearance.BorderSize = 0
        Me.ExpandImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.ExpandImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExpandImageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ExpandImageButton.Image = Global.SparkONCA.My.Resources.Resources.ExpandImage
        Me.ExpandImageButton.Location = New System.Drawing.Point(207, 25)
        Me.ExpandImageButton.Name = "ExpandImageButton"
        Me.ExpandImageButton.Size = New System.Drawing.Size(32, 32)
        Me.ExpandImageButton.TabIndex = 14
        Me.ExpandImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ExpandImageButton.UseVisualStyleBackColor = False
        '
        'IdeaBox
        '
        Me.IdeaBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.IdeaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdeaBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.IdeaBox.InitialImage = Global.SparkONCA.My.Resources.Resources.Backimage
        Me.IdeaBox.Location = New System.Drawing.Point(1, 22)
        Me.IdeaBox.Name = "IdeaBox"
        Me.IdeaBox.Size = New System.Drawing.Size(240, 217)
        Me.IdeaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IdeaBox.TabIndex = 4
        Me.IdeaBox.TabStop = False
        '
        'Tile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(480, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.ExpandImageButton)
        Me.Controls.Add(Me.RightMostPanelLowerUpper)
        Me.Controls.Add(Me.IdeaBox)
        Me.Controls.Add(Me.BottomMostPanel)
        Me.Controls.Add(Me.LeftmostLowerUpperPanel)
        Me.Controls.Add(Me.ExpandedInfo)
        Me.Controls.Add(Me.BasicDesc)
        Me.Controls.Add(Me.TopPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(300, 300)
        Me.MaximizeBox = False
        Me.Name = "Tile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopPanel.ResumeLayout(False)
        Me.BasicDesc.ResumeLayout(False)
        Me.BasicDesc.PerformLayout()
        Me.ExpandedInfo.ResumeLayout(False)
        Me.ExpandedInfo.PerformLayout()
        CType(Me.IdeaBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TopPanel As System.Windows.Forms.Panel
    Friend WithEvents IdeaBox As System.Windows.Forms.PictureBox
    Friend WithEvents ImageAddDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BasicDesc As System.Windows.Forms.Panel
    Friend WithEvents ExpandedInfo As System.Windows.Forms.Panel
    Friend WithEvents NameInfo As System.Windows.Forms.TextBox
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents DateInfo As System.Windows.Forms.TextBox
    Friend WithEvents UserLabel As System.Windows.Forms.Label
    Friend WithEvents UserInfo As System.Windows.Forms.TextBox
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents TimeInfo As System.Windows.Forms.TextBox
    Friend WithEvents SweepingTimer As System.Windows.Forms.Timer
    Friend WithEvents Sdescbox As System.Windows.Forms.TextBox
    Friend WithEvents LeftmostLowerUpperPanel As System.Windows.Forms.Panel
    Friend WithEvents RightMostPanelLowerUpper As System.Windows.Forms.Panel
    Friend WithEvents TopBorder As System.Windows.Forms.Panel
    Friend WithEvents BottomMostPanel As System.Windows.Forms.Panel
    Friend WithEvents DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents Ldescbox As System.Windows.Forms.TextBox
    Friend WithEvents ExpandButton As System.Windows.Forms.Button
    Friend WithEvents RightTopBorderButton As System.Windows.Forms.Panel
    Friend WithEvents NameUpdateTimer As System.Windows.Forms.Timer
    Friend WithEvents TileNameLabel As System.Windows.Forms.Label
    Friend WithEvents ExpandImageButton As System.Windows.Forms.Button
End Class
