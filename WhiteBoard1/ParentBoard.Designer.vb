<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentBoard))
        Me.SparkMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.BoardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenExistingBoardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToBoardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBoardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SparkMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SparkMenuStrip
        '
        Me.SparkMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoardToolStripMenuItem, Me.AddTileToolStripMenuItem})
        Me.SparkMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.SparkMenuStrip.Name = "SparkMenuStrip"
        Me.SparkMenuStrip.Size = New System.Drawing.Size(884, 24)
        Me.SparkMenuStrip.TabIndex = 1
        Me.SparkMenuStrip.Text = "MenuStrip1"
        '
        'BoardToolStripMenuItem
        '
        Me.BoardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenExistingBoardToolStripMenuItem, Me.ConnectToBoardToolStripMenuItem, Me.NewBoardToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.BoardToolStripMenuItem.Name = "BoardToolStripMenuItem"
        Me.BoardToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.BoardToolStripMenuItem.Text = "Board"
        '
        'OpenExistingBoardToolStripMenuItem
        '
        Me.OpenExistingBoardToolStripMenuItem.Name = "OpenExistingBoardToolStripMenuItem"
        Me.OpenExistingBoardToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenExistingBoardToolStripMenuItem.Text = "Open existing board"
        '
        'ConnectToBoardToolStripMenuItem
        '
        Me.ConnectToBoardToolStripMenuItem.Name = "ConnectToBoardToolStripMenuItem"
        Me.ConnectToBoardToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConnectToBoardToolStripMenuItem.Text = "Connect to board"
        '
        'NewBoardToolStripMenuItem
        '
        Me.NewBoardToolStripMenuItem.Name = "NewBoardToolStripMenuItem"
        Me.NewBoardToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewBoardToolStripMenuItem.Text = "New board"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddTileToolStripMenuItem
        '
        Me.AddTileToolStripMenuItem.Name = "AddTileToolStripMenuItem"
        Me.AddTileToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.AddTileToolStripMenuItem.Text = "Add Tile"
        '
        'ParentBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 762)
        Me.Controls.Add(Me.SparkMenuStrip)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.SparkMenuStrip
        Me.Name = "ParentBoard"
        Me.Text = "Spark"
        Me.SparkMenuStrip.ResumeLayout(False)
        Me.SparkMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SparkMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents BoardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenExistingBoardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectToBoardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewBoardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
