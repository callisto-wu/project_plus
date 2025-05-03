Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = TextBox1.Text
        Dim string_array() As String = input.Split(",")
        Dim a(string_array.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        Dim q As Double = Form1.Q_test(a, 90)
        If q = 0 Then
            TextBox2.Text = "在置信度为90%时没有可疑值"
        Else
            TextBox2.Text = "在置信度为90%时可疑值为" & q
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim input As String = TextBox1.Text
        Dim string_array() As String = input.Split(",")
        Dim a(string_array.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        Dim q As Double = Form1.Q_test(a, 95)
        If q = 0 Then
            TextBox2.Text = "在置信度为95%没有可疑值"
        Else
            TextBox2.Text = "在置信度为95%时可疑值为" & q
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim input As String = TextBox1.Text
        Dim string_array() As String = input.Split(",")
        Dim a(string_array.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        Dim q As Double = Form1.Q_test(a, 99)
        If q = 0 Then
            TextBox2.Text = "在置信度为99%时没有可疑值"
        Else
            TextBox2.Text = "在置信度为99%时可疑值为" & q
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim input As String = TextBox1.Text
        Dim string_array() As String = input.Split(",")
        Dim a(string_array.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        Dim q As Double = Form1.Grubbs_test(a, 90)
        If q = 0 Then
            TextBox3.Text = "在置信度为90%时没有可疑值"
        Else
            TextBox3.Text = "在置信度为90%时可疑值为" & q
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim input As String = TextBox1.Text
        Dim string_array() As String = input.Split(",")
        Dim a(string_array.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        Dim q As Double = Form1.Grubbs_test(a, 95)
        If q = 0 Then
            TextBox3.Text = "在置信度为95%时没有可疑值"
        Else
            TextBox3.Text = "在置信度为95%时可疑值为" & q
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim input As String = TextBox1.Text
        Dim string_array() As String = input.Split(",")
        Dim a(string_array.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next
        Dim q As Double = Form1.Grubbs_test(a, 99)
        If q = 0 Then
            TextBox3.Text = "在置信度为99%时没有可疑值"
        Else
            TextBox3.Text = "在置信度为99%时可疑值为" & q
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form3.Show()
        Form3.TextBox1.Text = TextBox1.Text
        Me.Hide()
    End Sub
End Class