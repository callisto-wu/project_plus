<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(115, 27)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(601, 33)
        TextBox1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 27)
        Label5.TabIndex = 12
        Label5.Text = "输入框"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(115, 106)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(356, 33)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(115, 184)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(356, 33)
        TextBox3.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 27)
        Label1.TabIndex = 15
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 27)
        Label2.TabIndex = 16
        Label2.Text = "Label2"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(583, 103)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 36)
        Button1.TabIndex = 17
        Button1.Text = "q test 90%"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(754, 103)
        Button2.Name = "Button2"
        Button2.Size = New Size(133, 36)
        Button2.TabIndex = 18
        Button2.Text = "q test 95%"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.CausesValidation = False
        Button3.Location = New Point(933, 104)
        Button3.Name = "Button3"
        Button3.Size = New Size(133, 36)
        Button3.TabIndex = 19
        Button3.Text = "q test 99%"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(583, 189)
        Button4.Name = "Button4"
        Button4.Size = New Size(133, 36)
        Button4.TabIndex = 20
        Button4.Text = "g test 90%"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(754, 189)
        Button5.Name = "Button5"
        Button5.Size = New Size(133, 36)
        Button5.TabIndex = 21
        Button5.Text = "g test 95%"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(933, 189)
        Button6.Name = "Button6"
        Button6.Size = New Size(133, 36)
        Button6.TabIndex = 22
        Button6.Text = "g test 99%"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(754, 334)
        Button7.Name = "Button7"
        Button7.Size = New Size(133, 68)
        Button7.TabIndex = 23
        Button7.Text = "更高级功能"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(12F, 27F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1148, 526)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Margin = New Padding(4)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
