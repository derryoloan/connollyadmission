Public Class Person
    Private sName As String
    Private sLocation As String
    Private sID As String

    Public Property Name As String
        Get
            Return sName
        End Get
        Set(value As String)
            sName = value
        End Set
    End Property
    Public Property Location As String
        Get
            Return sLocation
        End Get
        Set(value As String)
            sLocation = value
        End Set
    End Property
    Public Property ID As String
        Get
            Return sID
        End Get
        Set(value As String)
            sID = value
        End Set
    End Property
End Class
