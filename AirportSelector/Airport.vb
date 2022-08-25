Public Class Airport
    Private name As String   ' Name of airport
    Private city As String   ' Location
    Private shortName As String    ' Short name

    Public Sub New()

    End Sub

    Public Sub New(ByVal n As String, ByVal c As String, ByVal shrt As String)
        name = n
        city = c
        shortName = shrt
    End Sub

    Public Function toString() As String
        Return String.Format("{0} - {1} - {2}", shortName, name, city)
    End Function

    Public Function getName() As String
        Return name
    End Function

    Public Function getCity() As String
        Return city
    End Function

    Public Function getShortName() As String
        Return shortName
    End Function

    Public Sub setName(ByVal n As String)
        name = n
    End Sub

    Public Sub setCity(ByVal c As String)
        city = c
    End Sub

    Public Sub setShortName(ByVal sh As String)
        shortName = sh
    End Sub
End Class
