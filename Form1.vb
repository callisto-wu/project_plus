Public Class Form1
    Public Function absolute_error(ByVal a As Double, ByVal b As Double) As Double
        Return Math.Abs(a - b)
    End Function
    Public Function relative_error(ByVal a As Double, ByVal b As Double,
                                   Optional ByVal epsilon As Double = 0.000000000001) As Double
        If Math.Abs(b) < epsilon Then
            Return If(Math.Abs(a) < epsilon, 0, Double.PositiveInfinity)
        End If
        Return Math.Abs((a - b) / b)
    End Function

    Public Function average(ByVal a() As Double) As Double
        If a Is Nothing OrElse a.Length = 0 Then
            Throw New ArgumentException("Invalid array input")
        End If

        Dim sum As Double = 0.0
        For Each num As Double In a
            sum += num
        Next
        Return sum / a.Length
    End Function

    Public Function range(ByVal a As Double()) As Double
        Return Math.Abs(a.Max() - a.Min())
    End Function

    Public Function relative_average_deviation(ByVal a() As Double) As Double
        Dim sum As Double = 0.0
        Dim mean As Double = average(a) ' 调用之前转换的平均值函数
        For i As Integer = 0 To a.Length - 1
            sum += Math.Abs(a(i) - mean)
        Next
        If a.Length = 0 Then
            Throw New ArgumentException("Invalid array input")
        Else
            Return sum / a.Length
        End If

    End Function
    Public Function StandardDeviation(a() As Double) As Double
        If a Is Nothing OrElse a.Length = 0 Then
            Throw New ArgumentException("Invalid array input")
        End If

        Dim mean As Double = average(a)
        Dim sumSquaredDiffs As Double = 0.0

        For Each num As Double In a
            sumSquaredDiffs += (num - mean) * (num - mean)
        Next

        Dim denominator As Integer = a.Length
        If denominator <= 20 Then
            If denominator = 1 Then
                Return 0
            End If
            denominator -= 1
        End If

        Return Math.Sqrt(sumSquaredDiffs / denominator)
    End Function

    Public Function RelativeStandardDeviation(a() As Double) As Double
        Dim mean As Double = average(a)
        Dim stdDev As Double = StandardDeviation(a)
        If mean = 0 Then Return 0 ' 避免除以零错误
        Return stdDev / mean
    End Function
    Public Function pooled_standard_deviation(a() As Double, b() As Double) As Double
        Dim n1 As Integer = a.Length
        Dim n2 As Integer = b.Length
        Dim s1 As Double = StandardDeviation(a)
        Dim s2 As Double = StandardDeviation(b)
        Return Math.Sqrt(((n1 - 1) * s1 * s1 + (n2 - 1) * s2 * s2) / (n1 + n2 - 2))
    End Function
    Public Function q_test_list(a As Integer, b As Integer) As Double
        Dim a1(,) As Double = {
        {0.9, 0.76, 0.64, 0.56, 0.51, 0.47, 0.44, 0.41},
        {0.97, 0.84, 0.73, 0.64, 0.59, 0.54, 0.51, 0.49},
        {0.99, 0.93, 0.82, 0.74, 0.68, 0.63, 0.6, 0.57}
    }

        If a = 90 Then
            Return a1(0, b - 3)
        ElseIf a = 95 Then
            Return a1(1, b - 3)
        ElseIf a = 99 Then
            Return a1(2, b - 3)
        Else
            Console.WriteLine("Error: Invalid significance level.")
            Return 0
        End If
    End Function

    Public Function Grubbs_test_list(a As Integer, b As Integer) As Double
        Dim a1(,) As Double = {
        {1.15, 1.46, 1.67, 1.82, 1.94, 2.03, 2.11, 2.18},
        {1.15, 1.48, 1.71, 1.89, 2.02, 2.13, 2.21, 2.29},
        {1.15, 1.5, 1.76, 1.97, 2.14, 2.27, 2.39, 2.48}
    }

        If a = 90 Then
            Return a1(0, b - 3)
        ElseIf a = 95 Then
            Return a1(1, b - 3)
        ElseIf a = 99 Then
            Return a1(2, b - 3)
        Else
            Return 0
        End If
    End Function
    Public Function F_test_list(a As Integer, b As Integer) As Double
        Dim a1(,) As Double = {
        {161.4, 199.5, 215.7, 224.6, 230.2, 234.0, 236.8, 238.9, 240.5, 241.9, 243.9},
        {18.51, 19.0, 19.16, 19.25, 19.3, 19.33, 19.35, 19.37, 19.38, 19.4, 19.41},
        {10.13, 9.55, 9.28, 9.12, 9.01, 8.94, 8.89, 8.85, 8.81, 8.79, 8.74},
        {7.71, 6.94, 6.59, 6.39, 6.26, 6.16, 6.09, 6.04, 6.0, 5.96, 5.91},
        {6.61, 5.79, 5.41, 5.19, 5.05, 4.95, 4.88, 4.82, 4.77, 4.74, 4.68},
        {5.99, 5.14, 4.76, 4.53, 4.39, 4.28, 4.21, 4.15, 4.1, 4.06, 4.0},
        {5.59, 4.74, 4.35, 4.17, 3.97, 3.87, 3.79, 3.73, 3.68, 3.64, 3.57},
        {5.32, 4.46, 4.07, 3.84, 3.69, 3.58, 3.5, 3.44, 3.39, 3.35, 3.28},
        {5.12, 4.26, 3.86, 3.63, 3.48, 3.37, 3.29, 3.23, 3.18, 3.14, 3.07},
        {4.96, 4.1, 3.71, 3.48, 3.33, 3.22, 3.14, 3.0, 3.02, 2.98, 2.91},
        {4.84, 3.96, 3.59, 3.36, 3.2, 3.09, 3.01, 2.95, 2.9, 2.85, 2.7},
        {4.75, 3.89, 3.49, 3.26, 3.11, 3.0, 2.91, 2.85, 2.8, 2.75, 2.69}
    }

        If a <= 13 AndAlso b <= 12 Then
            Return a1(a - 1, b - 1)
        Else
            Return -1
        End If
    End Function
    Public Function T_test_list(a As Integer, b As Integer) As Double
        Dim a1(,) As Double = {
        {6.31, 2.92, 2.35, 2.13, 2.02, 1.94, 1.9, 1.86, 1.83, 1.81},
        {12.71, 4.3, 3.18, 2.78, 2.57, 2.45, 2.37, 2.31, 2.26, 2.23},
        {63.66, 9.93, 5.84, 4.6, 4.03, 3.71, 3.5, 3.36, 3.25, 3.17}
    }

        If a = 90 Then
            Return a1(0, b)
        ElseIf a = 95 Then
            Return a1(1, b)
        ElseIf a = 99 Then
            Return a1(2, b)
        Else
            Return 0
        End If
    End Function
    Public Function Q_test(ByRef a() As Double, ByVal b As Integer) As Double
        Dim n As Integer = a.Length
        Dim ran As Double = range(a)
        Array.Sort(a)
        Dim x1 As Double = Math.Abs(a(0) - a(1))
        Dim x2 As Double = Math.Abs(a(n - 1) - a(n - 2))
        Dim Q1 As Double = x1 / ran
        Dim Q2 As Double = x2 / ran
        If x1 > x2 Then
            If x1 > q_test_list(b, a.Length) Then
                Return a(0)
            Else
                Return 0
            End If
        Else
            If x2 > q_test_list(b, a.Length) Then
                Return a(n - 1)
            Else
                Return 0
            End If
        End If



    End Function
    Public Function Grubbs_test(ByRef a() As Double, ByVal b As Integer) As Double
        Dim n As Integer = a.Length
        Dim mean As Double = average(a)
        Dim stdDev As Double = StandardDeviation(a)
        Dim maxDiff As Double = Math.Abs(a.Max() - mean)
        Dim minDiff As Double = Math.Abs(a.Min() - mean)
        Dim G1 As Double = maxDiff / stdDev
        Dim G2 As Double = minDiff / stdDev
        If G1 > G2 Then
            Dim G As Double = G1
            If G > Grubbs_test_list(b, n) Then
                Return a.Max()
            Else
                Return 0
            End If
        Else
            Dim G As Double = G2
            If G > Grubbs_test_list(b, n) Then
                Return a.Min()
            Else
                Return 0
            End If
        End If

    End Function
    Public Function F_test(ByRef a() As Double, ByVal b（） As Double, ByRef x As Integer) As Double
        Dim n As Integer = a.Length
        Dim mean As Double = average(a)

        Dim F1 As Double = StandardDeviation(a) * StandardDeviation(a)
        Dim F2 As Double = StandardDeviation(b) * StandardDeviation(b)
        If F1 > F2 Then
            Dim F As Double = F1 / F2
            If F > F_test_list(n - 1, b.Length - 1) Then
                x = 1
                Return F
            Else
                x = 0
                Return F
            End If
        Else
            Dim F As Double = F2 / F1
            If F > F_test_list(b.Length - 1, n - 1) Then
                x = 1
                Return F
            Else
                x = 0
                Return 0
            End If
        End If

    End Function
    Public Function independent_sample_t_test(ByRef a() As Double, ByRef b() As Double, ByRef p As Integer) As Double
        Dim n1 As Integer = a.Length
        Dim n2 As Integer = b.Length
        Dim mean1 As Double = average(a)
        Dim mean2 As Double = average(b)
        Dim stdDev1 As Double = StandardDeviation(a)
        Dim stdDev2 As Double = StandardDeviation(b)
        Dim t As Double = Math.Abs(mean1 - mean2) / (pooled_standard_deviation(a, b) * Math.Sqrt(1 / n1 + 1 / n2))

        If t > T_test_list(p, n1 + n2 - 2) Then
            p = 1
            Return t
        Else
            p = 0
            Return t
        End If
    End Function
    Public Function paired_sample_t_test(ByRef a() As Double, ByRef b() As Double, ByRef p As Integer) As Double
        Dim n As Integer = a.Length
        Dim c1(n - 1) As Double
        For i As Integer = 0 To n - 1
            c1(i) = a(i) - b(i)
        Next
        Dim mean As Double = average(c1)
        Dim stdDev As Double = StandardDeviation(c1)
        Dim t As Double = Math.Abs(mean) / (stdDev / Math.Sqrt(n))
        If t > T_test_list(p, n - 1) Then
            p = 1
            Return t
        Else
            p = 0
            Return t
        End If
    End Function
    Public Function single_sample_t_test(ByRef a() As Double, ByRef u As Double, ByRef p As Integer) As Double
        Dim mean As Double = average(a)
        Dim stdDev As Double = StandardDeviation(a)
        Dim n As Integer = a.Length
        Dim t As Double = Math.Abs(mean - u) / (stdDev / Math.Sqrt(n))
        If t > T_test_list(p, n - 1) Then
            p = 1
            Return t

        Else
            p = 0
            Return t

        End If
    End Function
    Public Function correlation_coefficient(ByRef a() As Double, ByRef b() As Double) As Double
        Dim n As Integer = a.Length
        Dim average_a As Double = average(a)
        Dim average_b As Double = average(b)
        Dim sum_ab As Double = 0.0
        Dim sum_a2 As Double = 0.0
        Dim sum_b2 As Double = 0.0
        For i As Integer = 0 To n - 1
            sum_ab += (a(i) - average_a) * (b(i) - average_b)
            sum_a2 += (a(i) - average_a) * (a(i) - average_a)
            sum_b2 += (b(i) - average_b) * (b(i) - average_b)
        Next
        Return sum_ab / Math.Sqrt(sum_a2 * sum_b2)

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim input As String = TextBox1.Text
        Dim string_array() As String = input.Split(",")
        Dim a(string_array.Length - 1) As Double
        For i As Integer = 0 To string_array.Length - 1
            a(i) = Convert.ToDouble(string_array(i))
        Next

        Dim avg As Double = average(a)
        Dim relAvgDev As Double = relative_average_deviation(a)
        Dim stdDev As Double = StandardDeviation(a)
        Dim relStdDev As Double = RelativeStandardDeviation(a)
        Dim rangeValue As Double = range(a)

        TextBox2.Text = avg
        TextBox3.Text = relAvgDev
        TextBox4.Text = stdDev
        TextBox5.Text = relStdDev
        TextBox6.Text = rangeValue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Form2.TextBox1.Text = TextBox1.Text
        Me.Hide()
    End Sub
End Class
