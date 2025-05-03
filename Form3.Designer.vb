<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        TextBox4 = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(152, 26)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(818, 37)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(152, 104)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(818, 37)
        TextBox2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 30)
        Label1.TabIndex = 2
        Label1.Text = "数据组1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 30)
        Label2.TabIndex = 3
        Label2.Text = "数据组2"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(152, 190)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(164, 37)
        TextBox3.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 30)
        Label3.TabIndex = 5
        Label3.Text = "真值"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(468, 191)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 36)
        Button1.TabIndex = 6
        Button1.Text = "真值t test 90%"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(468, 291)
        Button2.Name = "Button2"
        Button2.Size = New Size(182, 36)
        Button2.TabIndex = 7
        Button2.Text = "配对t test 90%"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(468, 391)
        Button3.Name = "Button3"
        Button3.Size = New Size(182, 36)
        Button3.TabIndex = 8
        Button3.Text = "独立t test 90%"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(152, 337)
        Button4.Name = "Button4"
        Button4.Size = New Size(167, 90)
        Button4.TabIndex = 9
        Button4.Text = "更更高级功能"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(698, 190)
        Button5.Name = "Button5"
        Button5.Size = New Size(182, 36)
        Button5.TabIndex = 10
        Button5.Text = "真值t test 95%"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(925, 191)
        Button6.Name = "Button6"
        Button6.Size = New Size(182, 36)
        Button6.TabIndex = 11
        Button6.Text = "真值t test 99%"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(698, 291)
        Button7.Name = "Button7"
        Button7.Size = New Size(182, 36)
        Button7.TabIndex = 12
        Button7.Text = "配对t test 95%"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(698, 391)
        Button8.Name = "Button8"
        Button8.Size = New Size(182, 36)
        Button8.TabIndex = 13
        Button8.Text = "独立t test 95%"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(925, 291)
        Button9.Name = "Button9"
        Button9.Size = New Size(182, 36)
        Button9.TabIndex = 14
        Button9.Text = "配对t test 99%"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(925, 391)
        Button10.Name = "Button10"
        Button10.Size = New Size(182, 36)
        Button10.TabIndex = 15
        Button10.Text = "独立t test 99%"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(152, 470)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(818, 37)
        TextBox4.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 470)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 30)
        Label4.TabIndex = 17
        Label4.Text = "输出"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(14F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1244, 675)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Font = New Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
End Class
