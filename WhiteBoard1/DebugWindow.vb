Public Class DebugWindow

    Private Sub IntroDebugButton_Click(sender As Object, e As EventArgs) Handles IntroDebugButton.Click
        Dim IntroD As New Intro
        IntroD.Show()
    End Sub

    Private Sub SplashDebugButton_Click(sender As Object, e As EventArgs) Handles SplashDebugButton.Click
        Dim SplashSparkD As New SplashSpark
        SplashSparkD.Show()
    End Sub

    Private Sub BoardDebugButton_Click(sender As Object, e As EventArgs) Handles BoardDebugButton.Click
        Dim ParentBoardD As New ParentBoard
        ParentBoardD.Show()
    End Sub

    Private Sub AboutDebugButton_Click(sender As Object, e As EventArgs) Handles AboutDebugButton.Click
        Dim AboutSparkD As New AboutSpark
        AboutSparkD.Show()
    End Sub

    Private Sub LogInDebugButton_Click(sender As Object, e As EventArgs) Handles LogInDebugButton.Click
        Dim SparkLoginD As New SparkLogin
        SparkLoginD.Show()
    End Sub
End Class