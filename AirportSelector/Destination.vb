Public Class Destination
    Private name As String
    Private length As Integer
    Private price As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal n As String, ByVal l As Integer, ByVal p As Integer)
        name = n
        length = l
        price = p
    End Sub

    Public Function toString() As String
        Return String.Format("{0}\t{1}km - {2}EUR", name, length, price)
    End Function

    Public Function getName() As String
        Return name
    End Function

    Public Function getLength() As Integer
        Return length
    End Function

    Public Function getPrice() As Integer
        Return price
    End Function

    Public Sub setName(ByVal n As String)
        name = n
    End Sub

    Public Sub setLength(ByVal l As Integer)
        length = l
    End Sub

    Public Sub setPrice(ByVal p As Integer)
        price = p
    End Sub
End Class
