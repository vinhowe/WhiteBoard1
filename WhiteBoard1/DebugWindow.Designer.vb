<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebugWindow
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
        Me.IntroDebugButton = New System.Windows.Forms.Button()
        Me.SplashDebugButton = New System.Windows.Forms.Button()
        Me.BoardDebugButton = New System.Windows.Forms.Button()
        Me.AboutDebugButton = New System.Windows.Forms.Button()
        Me.LogInDebugButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IntroDebugButton
        '
        Me.IntroDebugButton.Location = New System.Drawing.Point(12, 12)
        Me.IntroDebugButton.Name = "IntroDebugButton"
        Me.IntroDebugButton.Size = New System.Drawing.Size(92, 23)
        Me.IntroDebugButton.TabIndex = 0
        Me.IntroDebugButton.Text = "Intro"
        Me.IntroDebugButton.UseVisualStyleBackColor = True
        '
        'SplashDebugButton
        '
        Me.SplashDebugButton.Location = New System.Drawing.Point(12, 41)
        Me.SplashDebugButton.Name = "SplashDebugButton"
        Me.SplashDebugButton.Size = New System.Drawing.Size(92, 23)
        Me.SplashDebugButton.TabIndex = 1
        Me.SplashDebugButton.Text = "Splash"
        Me.SplashDebugButton.UseVisualStyleBackColor = True
        '
        'BoardDebugButton
        '
        Me.BoardDebugButton.Location = New System.Drawing.Point(12, 70)
        Me.BoardDebugButton.Name = "BoardDebugButton"
        Me.BoardDebugButton.Size = New System.Drawing.Size(92, 23)
        Me.BoardDebugButton.TabIndex = 2
        Me.BoardDebugButton.Text = "Board Container"
        Me.BoardDebugButton.UseVisualStyleBackColor = True
        '
        'AboutDebugButton
        '
        Me.AboutDebugButton.Location = New System.Drawing.Point(12, 99)
        Me.AboutDebugButton.Name = "AboutDebugButton"
        Me.AboutDebugButton.Size = New System.Drawing.Size(92, 23)
        Me.AboutDebugButton.TabIndex = 3
        Me.AboutDebugButton.Text = "About"
        Me.AboutDebugButton.UseVisualStyleBackColor = True
        '
        'LogInDebugButton
        '
        Me.LogInDebugButton.Location = New System.Drawing.Point(12, 128)
        Me.LogInDebugButton.Name = "LogInDebugButton"
        Me.LogInDebugButton.Size = New System.Drawing.Size(92, 23)
        Me.LogInDebugButton.TabIndex = 4
        Me.LogInDebugButton.Text = "Log In Form"
        Me.LogInDebugButton.UseVisualStyleBackColor = True
        '
        'DebugWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(116, 187)
        Me.Controls.Add(Me.LogInDebugButton)
        Me.Controls.Add(Me.AboutDebugButton)
        Me.Controls.Add(Me.BoardDebugButton)
        Me.Controls.Add(Me.SplashDebugButton)
        Me.Controls.Add(Me.IntroDebugButton)
        Me.Name = "DebugWindow"
        Me.Text = "Debug Window"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IntroDebugButton As System.Windows.Forms.Button
    Friend WithEvents SplashDebugButton As System.Windows.Forms.Button
    Friend WithEvents BoardDebugButton As System.Windows.Forms.Button
    Friend WithEvents AboutDebugButton As System.Windows.Forms.Button
    Friend WithEvents LogInDebugButton As System.Windows.Forms.Button
End Class
