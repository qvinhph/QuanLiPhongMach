Public Class LoaiBenhDTO

#Region "Fields"

    Private strMaLoaiBenh As String
    Private strLoaiBenh As String

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaLoaiBenh As String, strLoaiBenh As String)
        MaLoaiBenh = strMaLoaiBenh
        LoaiBenh = strLoaiBenh
    End Sub

#End Region

#Region "Property"

    Public Property LoaiBenh As String
        Get
            Return strLoaiBenh
        End Get
        Set(value As String)
            strLoaiBenh = value
        End Set
    End Property

    Public Property MaLoaiBenh As String
        Get
            Return strMaLoaiBenh
        End Get
        Set(value As String)
            strMaLoaiBenh = value
        End Set
    End Property

#End Region

End Class
