﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox5 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox6 = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(634, 91)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 35)
        Button1.TabIndex = 0
        Button1.Text = "基础功能"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(130, 13)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(554, 30)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(130, 119)
        TextBox2.Margin = New Padding(4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(152, 30)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(130, 182)
        TextBox3.Margin = New Padding(4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(152, 30)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(130, 244)
        TextBox4.Margin = New Padding(4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(152, 30)
        TextBox4.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(634, 182)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 35)
        Button2.TabIndex = 5
        Button2.Text = "高级功能"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(130, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 24)
        Label1.TabIndex = 6
        Label1.Text = "Average"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(130, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(241, 24)
        Label2.TabIndex = 7
        Label2.Text = "Relative Average Deviation"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(130, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 24)
        Label3.TabIndex = 8
        Label3.Text = "Standard Deviation"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(130, 305)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(152, 30)
        TextBox5.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(130, 278)
        Label4.Name = "Label4"
        Label4.Size = New Size(249, 24)
        Label4.TabIndex = 10
        Label4.Text = "Relative Standard Deviation"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(46, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 24)
        Label5.TabIndex = 11
        Label5.Text = "输入框"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(130, 365)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(152, 30)
        TextBox6.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(130, 338)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 24)
        Label6.TabIndex = 13
        Label6.Text = "Range Value"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1078, 544)
        Controls.Add(Label6)
        Controls.Add(TextBox6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Font = New Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label

End Class
