<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        btnStart = New Button()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.FromArgb(CByte(149), CByte(73), CByte(171))
        btnStart.Font = New Font("Segoe Script", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnStart.Location = New Point(359, 366)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(211, 102)
        btnStart.TabIndex = 6
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' HomeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2024_01_24_120102
        ClientSize = New Size(927, 503)
        Controls.Add(btnStart)
        Name = "HomeForm"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnStart As Button
End Class
