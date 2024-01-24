<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuestionForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Foundation = New PictureBox()
        Mascara = New PictureBox()
        btnFoundation = New Button()
        btnMascara = New Button()
        Question1 = New Label()
        btnHome = New Button()
        btnNext = New Button()
        Correct1 = New Label()
        CType(Foundation, ComponentModel.ISupportInitialize).BeginInit()
        CType(Mascara, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Foundation
        ' 
        Foundation.BackgroundImage = My.Resources.Resources.Screenshot_2024_01_24_113356
        Foundation.Location = New Point(243, 288)
        Foundation.Name = "Foundation"
        Foundation.Size = New Size(116, 111)
        Foundation.TabIndex = 0
        Foundation.TabStop = False
        ' 
        ' Mascara
        ' 
        Mascara.Image = My.Resources.Resources.Screenshot_2024_01_24_113516
        Mascara.Location = New Point(499, 288)
        Mascara.Name = "Mascara"
        Mascara.Size = New Size(74, 111)
        Mascara.TabIndex = 1
        Mascara.TabStop = False
        ' 
        ' btnFoundation
        ' 
        btnFoundation.BackColor = Color.FromArgb(149, 73, 171)
        btnFoundation.Font = New Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnFoundation.Location = New Point(243, 226)
        btnFoundation.Name = "btnFoundation"
        btnFoundation.Size = New Size(116, 39)
        btnFoundation.TabIndex = 2
        btnFoundation.Text = "Foundation"
        btnFoundation.UseVisualStyleBackColor = False
        ' 
        ' btnMascara
        ' 
        btnMascara.BackColor = Color.FromArgb(149, 73, 171)
        btnMascara.Font = New Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnMascara.Location = New Point(478, 226)
        btnMascara.Name = "btnMascara"
        btnMascara.Size = New Size(116, 39)
        btnMascara.TabIndex = 3
        btnMascara.Text = "Mascara"
        btnMascara.UseVisualStyleBackColor = False
        ' 
        ' Question1
        ' 
        Question1.AutoSize = True
        Question1.BackColor = Color.FromArgb(149, 73, 171)
        Question1.Font = New Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Question1.Location = New Point(268, 55)
        Question1.Name = "Question1"
        Question1.Size = New Size(315, 84)
        Question1.TabIndex = 4
        Question1.Text = "     Which makeup product " + vbCrLf + "is used to even out the skin tone " + vbCrLf + "   and create a smooth base?"
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.FromArgb(149, 73, 171)
        btnHome.Font = New Font("Segoe Script", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnHome.Location = New Point(84, 67)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(116, 60)
        btnHome.TabIndex = 5
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(149, 73, 171)
        btnNext.Font = New Font("Segoe Script", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.Location = New Point(638, 67)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(116, 60)
        btnNext.TabIndex = 6
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Correct1
        ' 
        Correct1.AutoSize = True
        Correct1.BackColor = Color.FromArgb(149, 73, 171)
        Correct1.Font = New Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Correct1.Location = New Point(325, 156)
        Correct1.Name = "Correct1"
        Correct1.Size = New Size(179, 57)
        Correct1.TabIndex = 7
        Correct1.Text = "-------"
        ' 
        ' QuestionForm1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2024_01_24_113039
        ClientSize = New Size(833, 455)
        Controls.Add(Correct1)
        Controls.Add(btnNext)
        Controls.Add(btnHome)
        Controls.Add(Question1)
        Controls.Add(btnMascara)
        Controls.Add(btnFoundation)
        Controls.Add(Mascara)
        Controls.Add(Foundation)
        Name = "QuestionForm1"
        Text = "Question 1"
        CType(Foundation, ComponentModel.ISupportInitialize).EndInit()
        CType(Mascara, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Foundation As PictureBox
    Friend WithEvents Mascara As PictureBox
    Friend WithEvents btnFoundation As Button
    Friend WithEvents btnMascara As Button
    Friend WithEvents Question1 As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Correct1 As Label
End Class
