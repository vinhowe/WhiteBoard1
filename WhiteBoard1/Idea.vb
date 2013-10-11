Public Class Tile
    'Declare the variables
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim NameInfoEn As Boolean = False
    Dim UserInfoEn As Boolean = False
    Dim LdescboxEn As Boolean = False
    Dim SdescboxEn As Boolean = False
    Dim currentTime As String = System.DateTime.Now.ToString("hh:mm:ss")
    Dim expand As Integer = 1
    Dim expandsix As Integer = 6
    Dim decreasefive As Integer = 5
    Dim expandtwo As Integer = 2
    Dim RandomLocation As System.Random = New System.Random
    Dim RandomLocationNum As Integer = RandomLocation.Next(0, 500)

    Public Overloads Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
        Dim sColor As Color = Color.FromArgb(50, 153, 153, 153)
        Dim g As Graphics = e.Graphics

        Dim b As New SolidBrush(sColor)
        Dim p As New Pen(b, 3)

        g.DrawLine(p, 0, 0 + (Me.Height - 3), 0 + (Me.Width - 3), 0 + (Me.Height - 3))
        g.DrawLine(p, 0 + (Me.Width - 3), 0, 0 + (Me.Width - 3), 0 + (Me.Height - 3))
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TopPanel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TopPanel.MouseDown, TileNameLabel.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
        Me.BringToFront()
    End Sub

    Private Sub TopPanel_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TopPanel.MouseMove, TileNameLabel.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub TopPanel_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TopPanel.MouseUp, TileNameLabel.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub


    Private Sub Tile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler MyBase.Paint, AddressOf OnPaint
        DateInfo.Text = Now.Month & "/" & Now.Day & "/" & Now.Year
        TimeInfo.Text = currentTime
        TileNameLabel.Text = ""
        Me.ClientSize = New System.Drawing.Size(240, 310)
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub ImageAddDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ImageAddDialog.FileOk
        IdeaBox.ImageLocation = ImageAddDialog.FileName
    End Sub

    Private Sub IdeaBox_Click(sender As Object, e As EventArgs) Handles IdeaBox.Click
        OpenImage()
    End Sub

    Private Sub OpenImage()
        ImageAddDialog.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExpandButton.Click
        If Me.Size.Width = 240 And Me.Size.Height = 310 Then
            expand = 2
            SweepingTimer.Enabled = True
            ExpandButton.Text = "<"
        ElseIf Me.Size.Width = 480 And Me.Size.Height = 310 Then
            expand = 1
            SweepingTimer.Enabled = True
            ExpandButton.Text = ">"
        End If
    End Sub


    Private Sub SweepingTimer_Tick(sender As Object, e As EventArgs) Handles SweepingTimer.Tick
        If expand = 1 Then
            If Me.Size.Width = 240 And Me.Size.Height = 310 Then
                decreasefive = 5
                SweepingTimer.Enabled = False
            Else
                Me.ClientSize = New System.Drawing.Size(Me.Size.Width - expandsix, 310)
            End If
        ElseIf expand = 2 Then
            If Me.Size.Width = 480 And Me.Size.Height = 310 Then
                SweepingTimer.Enabled = False
            Else
                Me.ClientSize = New System.Drawing.Size(Me.Size.Width + expandsix, 310)
            End If
        End If
    End Sub

    Private Sub Ldescbox_MouseLeave(sender As Object, e As EventArgs) Handles Ldescbox.MouseLeave
        Ldescbox.ReadOnly = True
    End Sub

    Private Sub Sdescbox_DoubleClick(sender As Object, e As EventArgs) Handles Sdescbox.DoubleClick
        If SdescboxEn = False Then
            Sdescbox.ReadOnly = False
        Else
            Sdescbox.ReadOnly = True
        End If
    End Sub

    Private Sub Sdescbox_MouseLeave(sender As Object, e As EventArgs) Handles Sdescbox.MouseLeave
        Sdescbox.ReadOnly = True
    End Sub

    Private Sub Sdescbox_TextChanged(sender As Object, e As EventArgs) Handles Sdescbox.TextChanged
        Ldescbox.Text = Sdescbox.Text
    End Sub

    Private Sub Ldescbox_TextChanged(sender As Object, e As EventArgs) Handles Ldescbox.TextChanged
        Sdescbox.Text = Ldescbox.Text
    End Sub

    Private Sub NameUpdateTimer_Tick(sender As Object, e As EventArgs) Handles NameUpdateTimer.Tick
        Me.Name = NameInfo.Text
        Me.Text = NameInfo.Text
        If String.IsNullOrEmpty(NameInfo.Text) Or String.IsNullOrWhiteSpace(NameInfo.Text) Then
            Me.TileNameLabel.Text = ""
        Else
            Me.TileNameLabel.Text = NameInfo.Text & " " & "-" & " " & GlobalFunctions.Username
        End If
    End Sub
End Class