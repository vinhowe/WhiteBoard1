Public Class ParentBoard
    Dim Note As New Tile
    Dim x, y As Integer

    Private Sub ParentBoard_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.MouseDoubleClick
        Note = New Tile
        Note.TopLevel = False
        Note.Visible = True
        Me.Controls.Add(Note)
    End Sub

    Private Sub ParentBoard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs)
        AboutSpark.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddTileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTileToolStripMenuItem.Click
        Note = New Tile
        Note.TopLevel = False
        Note.Visible = True
        Me.Controls.Add(Note)
    End Sub

End Class