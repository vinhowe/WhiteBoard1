Public Class Intro
    Dim GeneratorL As System.Random = New System.Random()
    Dim LogoRandomNumber As Integer = GeneratorL.Next(0, 13)

    Private Sub Intro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Copyright.Text = My.Application.Info.Copyright
        Me.specialInfo.Text = GlobalFunctions.ExInfo
        Random_Logo()
    End Sub

    Public Sub Random_Logo()
        If LogoRandomNumber = 0 Then
            LogoBox.Image = My.Resources.SparkDefault
        ElseIf LogoRandomNumber = 1 Then
            LogoBox.Image = My.Resources.SparkCubistRotate
        ElseIf LogoRandomNumber = 2 Then
            LogoBox.Image = My.Resources.SparkGlitch
        ElseIf LogoRandomNumber = 3 Then
            LogoBox.Image = My.Resources.SparkGlow
        ElseIf LogoRandomNumber = 4 Then
            LogoBox.Image = My.Resources.SparkAngleCut
        ElseIf LogoRandomNumber = 5 Then
            LogoBox.Image = My.Resources.SparkPixels
        ElseIf LogoRandomNumber = 6 Then
            LogoBox.Image = My.Resources.SparkRotate
        ElseIf LogoRandomNumber = 7 Then
            LogoBox.Image = My.Resources.SparkShadow
        ElseIf LogoRandomNumber = 8 Then
            LogoBox.Image = My.Resources.SparkSparkGlow
        ElseIf LogoRandomNumber = 9 Then
            LogoBox.Image = My.Resources.SparkSparks
        ElseIf LogoRandomNumber = 10 Then
            LogoBox.Image = My.Resources.SparkStarsColors
        ElseIf LogoRandomNumber = 11 Then
            LogoBox.Image = My.Resources.SparkStarsDistant
        ElseIf LogoRandomNumber = 12 Then
            LogoBox.Image = My.Resources.SparkStripes
        ElseIf LogoRandomNumber = 13 Then
            LogoBox.Image = My.Resources.SparkWithered
        End If
    End Sub

    Private Sub About_Button_Main_Click(sender As Object, e As EventArgs) Handles About_Button_Main.Click
        AboutSpark.Show()
    End Sub

    Private Sub NewBoardButton_Click(sender As Object, e As EventArgs) Handles NewBoardButton.Click
        ParentBoard.Show()
        BoardsPanel.Hide()
    End Sub

    Private Sub BoardsButton_Click(sender As Object, e As EventArgs) Handles BoardsButton.Click
        BoardsPanel.Show()
    End Sub
End Class
