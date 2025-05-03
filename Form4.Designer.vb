<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(137, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(756, 37)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(137, 113)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(756, 37)
        TextBox2.TabIndex = 1
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(14F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1244, 675)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Font = New Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
