Public Class ChiTietDanhSachDTO

#Region "Fields"

    Private strMaChiTietDanhSach As String
    Private strMaDanhSach As String
    Private strMaBenhNhan As String

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaChiTietDanhSach As String, strMaDanhSach As String, strMaBenhNhan As String)
        MaChiTietDanhSach = strMaChiTietDanhSach
        MaDanhSach = strMaDanhSach
        MaBenhNhan = strMaBenhNhan
    End Sub

#End Region

#Region "Property"

    Public Property MaChiTietDanhSach As String
        Get
            Return strMaChiTietDanhSach
        End Get
        Set(value As String)
            strMaChiTietDanhSach = value
        End Set
    End Property

    Public Property MaDanhSach() As String
        Get
            Return strMaDanhSach
        End Get
        Set(value As String)
            strMaDanhSach = value
        End Set
    End Property

    Public Property MaBenhNhan As String
        Get
            Return strMaBenhNhan
        End Get
        Set(value As String)
            strMaBenhNhan = value
        End Set
    End Property



#End Region

End Class
