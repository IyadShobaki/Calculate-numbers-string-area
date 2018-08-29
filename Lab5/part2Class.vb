Public Class part2Class
    Private Property _Num1 As Integer
    Private Property _Num2 As Integer
    Public Property Num1 As Integer
        Set(value As Integer)
            _Num1 = value
        End Set
        Get
            Return _Num1
        End Get
    End Property
    Public Property Num2 As Integer
        Set(value As Integer)
            _Num2 = value
        End Set
        Get
            Return _Num2
        End Get
    End Property
    Public Overridable Function Calculate(ByVal _Num1 As Integer, ByVal _Num2 As Integer) As Integer
        Return _Num1 + _Num2
    End Function


End Class
