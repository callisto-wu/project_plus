Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input1 As String = TextBox1.Text
        'Dim input2 As String = TextBox2.Text
        Dim string_array() As String = input1.Split(",")
        Dim a(string_array.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        Dim u As Double = Val(TextBox3.Text)
        Dim p As Integer = 90
        Dim t As Double = Form1.single_sample_t_test(a, u, p)
        If t = 0 Then
            TextBox4.Text = "在置信度为90%时没有显著性差异，t值为" & t
        Else
            TextBox4.Text = "在置信度为90%时有显著性差异，t值为" & t
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim input1 As String = TextBox1.Text
        'Dim input2 As String = TextBox2.Text
        Dim string_array() As String = input1.Split(",")
        Dim a(string_array.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        Dim u As Double = Val(TextBox3.Text)
        Dim p As Integer = 95
        Dim t As Double = Form1.single_sample_t_test(a, u, p)
        If t = 0 Then
            TextBox4.Text = "在置信度为95%时没有显著性差异，t值为" & t
        Else
            TextBox4.Text = "在置信度为95%时有显著性差异，t值为" & t
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim input1 As String = TextBox1.Text
        'Dim input2 As String = TextBox2.Text
        Dim string_array() As String = input1.Split(",")
        Dim a(string_array.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        Dim u As Double = Val(TextBox3.Text)
        Dim p As Integer = 99
        Dim t As Double = Form1.single_sample_t_test(a, u, p)
        If t = 0 Then
            TextBox4.Text = "在置信度为99%时没有显著性差异，t值为" & t
        Else
            TextBox4.Text = "在置信度为99%时有显著性差异，t值为" & t
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim input1 As String = TextBox1.Text
        Dim input2 As String = TextBox2.Text
        Dim string_array() As String = input1.Split(",")
        Dim string_array2() As String = input2.Split(",")
        Dim a(string_array.Length - 1) As Double
        Dim b(string_array2.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        For i As Integer = 0 To string_array2.Length - 1
            b(i) = Convert.ToDouble(string_array2(i))
        Next
        Dim p As Integer = 90
        Dim t As Double = Form1.paired_sample_t_test(a, b, p)
        If p = 0 Then
            TextBox4.Text = "在置信度为90%时没有显著性差异，t值为" & t
        Else
            TextBox4.Text = "在置信度为90%时有显著性差异，t值为" & t
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim input1 As String = TextBox1.Text
        Dim input2 As String = TextBox2.Text
        Dim string_array() As String = input1.Split(",")
        Dim string_array2() As String = input2.Split(",")
        Dim a(string_array.Length - 1) As Double
        Dim b(string_array2.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        For i As Integer = 0 To string_array2.Length - 1
            b(i) = Convert.ToDouble(string_array2(i))
        Next
        Dim p As Integer = 95
        Dim t As Double = Form1.paired_sample_t_test(a, b, p)
        If p = 0 Then
            TextBox4.Text = "在置信度为95%时没有显著性差异，t值为" & t
        Else
            TextBox4.Text = "在置信度为95%时有显著性差异，t值为" & t
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim input1 As String = TextBox1.Text
        Dim input2 As String = TextBox2.Text
        Dim string_array() As String = input1.Split(",")
        Dim string_array2() As String = input2.Split(",")
        Dim a(string_array.Length - 1) As Double
        Dim b(string_array2.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        For i As Integer = 0 To string_array2.Length - 1
            b(i) = Convert.ToDouble(string_array2(i))
        Next
        Dim p As Integer = 99
        Dim t As Double = Form1.paired_sample_t_test(a, b, p)
        If p = 0 Then
            TextBox4.Text = "在置信度为99%时没有显著性差异，t值为" & t
        Else
            TextBox4.Text = "在置信度为99%时有显著性差异，t值为" & t
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim input1 As String = TextBox1.Text
        Dim input2 As String = TextBox2.Text
        Dim string_array() As String = input1.Split(",")
        Dim string_array2() As String = input2.Split(",")
        Dim a(string_array.Length - 1) As Double
        Dim b(string_array2.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        For i As Integer = 0 To string_array2.Length - 1
            b(i) = Convert.ToDouble(string_array2(i))
        Next
        Dim p As Integer = 90
        Dim x As Integer = 0
        Dim F As Double = Form1.F_test(a, b, x)
        If x = 0 Then
            TextBox4.Text = "通过方差齐性检验，F值为" & "F" & vbCrLf
            Dim t As Double = Form1.independent_sample_t_test(a, b, p)
            If p = 0 Then
                TextBox4.Text = "在置信度为90%时没有显著性差异，t值为" & t
            Else
                TextBox4.Text = "在置信度为90%时有显著性差异，t值为" & t
            End If
        Else
            TextBox4.Text = "未通过方差齐性检验，F值为" & "F" & vbCrLf & "无法进行t检验"

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim input1 As String = TextBox1.Text
        Dim input2 As String = TextBox2.Text
        Dim string_array() As String = input1.Split(",")
        Dim string_array2() As String = input2.Split(",")
        Dim a(string_array.Length - 1) As Double
        Dim b(string_array2.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        For i As Integer = 0 To string_array2.Length - 1
            b(i) = Convert.ToDouble(string_array2(i))
        Next
        Dim p As Integer = 95
        Dim x As Integer = 0
        Dim F As Double = Form1.F_test(a, b, x)
        If x = 0 Then
            TextBox4.Text = "通过方差齐性检验，F值为" & "F" & vbCrLf
            Dim t As Double = Form1.independent_sample_t_test(a, b, p)
            If p = 0 Then
                TextBox4.Text = "在置信度为95%时没有显著性差异，t值为" & t
            Else
                TextBox4.Text = "在置信度为95%时有显著性差异，t值为" & t
            End If
        Else
            TextBox4.Text = "未通过方差齐性检验，F值为" & "F" & vbCrLf & "无法进行t检验"

        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim input1 As String = TextBox1.Text
        Dim input2 As String = TextBox2.Text
        Dim string_array() As String = input1.Split(",")
        Dim string_array2() As String = input2.Split(",")
        Dim a(string_array.Length - 1) As Double
        Dim b(string_array2.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        For i As Integer = 0 To string_array2.Length - 1
            b(i) = Convert.ToDouble(string_array2(i))
        Next
        Dim p As Integer = 99
        Dim x As Integer = 0
        Dim F As Double = Form1.F_test(a, b, x)
        If x = 0 Then
            TextBox4.Text = "通过方差齐性检验，F值为" & "F" & vbCrLf
            Dim t As Double = Form1.independent_sample_t_test(a, b, p)
            If p = 0 Then
                TextBox4.Text = "在置信度为99%时没有显著性差异，t值为" & t
            Else
                TextBox4.Text = "在置信度为99%时有显著性差异，t值为" & t
            End If
        Else
            TextBox4.Text = "未通过方差齐性检验，F值为" & "F" & vbCrLf & "无法进行t检验"

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
        Form4.TextBox1.Text = TextBox1.Text
        Form4.TextBox2.Text = TextBox2.Text
        Me.Hide()
    End Sub
End Class