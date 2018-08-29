Public Class Hypotenuse
    Private Property _Num1 As Single
    Private Property _Num2 As Single
    Public Function Calculate(ByVal _Num1 As Single, ByVal _Num2 As Single) As Single
        Return Math.Round(Math.Sqrt(Math.Pow(_Num1, 2) + Math.Pow(_Num2, 2)), 2)
    End Function
End Class
