<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizEND
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
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(149), CByte(73), CByte(171))
        Button1.Font = New Font("Segoe Script", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(247, 220)
        Button1.Name = "Button1"
        Button1.Size = New Size(345, 68)
        Button1.TabIndex = 0
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' QuizEND
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2024_01_24_152956
        ClientSize = New Size(838, 450)
        Controls.Add(Button1)
        Name = "QuizEND"
        Text = "QuizEND"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
End Class
