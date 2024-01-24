<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question2Form
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Question2Form))
        Correct1 = New Label()
        btnNext = New Button()
        btnHome = New Button()
        Question1 = New Label()
        btnBlush = New Button()
        btnLiquidEyeLiner = New Button()
        Blush = New PictureBox()
        LiquidEyeLiner = New PictureBox()
        CType(Blush, ComponentModel.ISupportInitialize).BeginInit()
        CType(LiquidEyeLiner, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Correct1
        ' 
        Correct1.AutoSize = True
        Correct1.BackColor = Color.FromArgb(CByte(149), CByte(73), CByte(171))
        Correct1.Font = New Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Correct1.Location = New Point(328, 154)
        Correct1.Name = "Correct1"
        Correct1.Size = New Size(179, 57)
        Correct1.TabIndex = 15
        Correct1.Text = "-------"
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(149), CByte(73), CByte(171))
        btnNext.Font = New Font("Segoe Script", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.Location = New Point(639, 65)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(116, 60)
        btnNext.TabIndex = 14
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.FromArgb(CByte(149), CByte(73), CByte(171))
        btnHome.Font = New Font("Segoe Script", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnHome.Location = New Point(83, 65)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(116, 60)
        btnHome.TabIndex = 13
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' Question1
        ' 
        Question1.AutoSize = True
        Question1.BackColor = Color.FromArgb(CByte(149), CByte(73), CByte(171))
        Question1.Font = New Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Question1.Location = New Point(297, 55)
        Question1.Name = "Question1"
        Question1.Size = New Size(240, 84)
        Question1.TabIndex = 12
        Question1.Text = "What is the name of the " & vbCrLf & "makeup product used to " & vbCrLf & "add color to the cheeks?"
        ' 
        ' btnBlush
        ' 
        btnBlush.BackColor = Color.FromArgb(CByte(149), CByte(73), CByte(171))
        btnBlush.Font = New Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnBlush.Location = New Point(477, 224)
        btnBlush.Name = "btnBlush"
        btnBlush.Size = New Size(116, 39)
        btnBlush.TabIndex = 11
        btnBlush.Text = "Blush"
        btnBlush.UseVisualStyleBackColor = False
        ' 
        ' btnLiquidEyeLiner
        ' 
        btnLiquidEyeLiner.BackColor = Color.FromArgb(CByte(149), CByte(73), CByte(171))
        btnLiquidEyeLiner.Font = New Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLiquidEyeLiner.Location = New Point(224, 224)
        btnLiquidEyeLiner.Name = "btnLiquidEyeLiner"
        btnLiquidEyeLiner.Size = New Size(154, 39)
        btnLiquidEyeLiner.TabIndex = 10
        btnLiquidEyeLiner.Text = "Liquid Eyeliner"
        btnLiquidEyeLiner.UseVisualStyleBackColor = False
        ' 
        ' Blush
        ' 
        Blush.Image = CType(resources.GetObject("Blush.Image"), Image)
        Blush.Location = New Point(444, 286)
        Blush.Name = "Blush"
        Blush.Size = New Size(182, 111)
        Blush.TabIndex = 9
        Blush.TabStop = False
        ' 
        ' LiquidEyeLiner
        ' 
        LiquidEyeLiner.BackgroundImage = CType(resources.GetObject("LiquidEyeLiner.BackgroundImage"), Image)
        LiquidEyeLiner.Location = New Point(236, 286)
        LiquidEyeLiner.Name = "LiquidEyeLiner"
        LiquidEyeLiner.Size = New Size(126, 111)
        LiquidEyeLiner.TabIndex = 8
        LiquidEyeLiner.TabStop = False
        ' 
        ' Question2Form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2024_01_24_113039
        ClientSize = New Size(800, 450)
        Controls.Add(Correct1)
        Controls.Add(btnNext)
        Controls.Add(btnHome)
        Controls.Add(Question1)
        Controls.Add(btnBlush)
        Controls.Add(btnLiquidEyeLiner)
        Controls.Add(Blush)
        Controls.Add(LiquidEyeLiner)
        Name = "Question2Form"
        Text = "Question2Form"
        CType(Blush, ComponentModel.ISupportInitialize).EndInit()
        CType(LiquidEyeLiner, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Correct1 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Question1 As Label
    Friend WithEvents btnBlush As Button
    Friend WithEvents btnLiquidEyeLiner As Button
    Friend WithEvents Blush As PictureBox
    Friend WithEvents LiquidEyeLiner As PictureBox
End Class
