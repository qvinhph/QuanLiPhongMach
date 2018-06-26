Public Class CachDungDTO

#Region "Fields"

    Private strMaCachDung As String
    Private strCachDung As String

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaCachDung As String, strCachDung As String)
        MaCachDung = strMaCachDung
        CachDung = strCachDung
    End Sub

#End Region

#Region "Property"

    Public Property MaCachDung As String
        Get
            Return strMaCachDung
        End Get
        Set(value As String)
            strMaCachDung = value
        End Set
    End Property

    Public Property CachDung As String
        Get
            Return strCachDung
        End Get
        Set(value As String)
            strCachDung = value
        End Set
    End Property

#End Region

End Class
