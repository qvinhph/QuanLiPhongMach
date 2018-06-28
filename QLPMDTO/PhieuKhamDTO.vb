Public Class PhieuKhamDTO

#Region "Fields"
    Private strMaPhieuKham As String
    Private strMaChiTietDanhSach As String
    Private strTrieuChung As String
    Private strMaLoaiBenh As String
#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(strMaPhieuKham As String, strMaChiTietDanhSach As String, strChieuTrung As String, strLoaiBenh As String)
        MaPhieuKham = strMaPhieuKham
        MaChiTietDanhSach = strMaChiTietDanhSach
        TrieuChung = strTrieuChung
        MaLoaiBenh = strLoaiBenh
    End Sub
#End Region

#Region "Property"
    Property MaPhieuKham() As Integer
        Get
            Return strMaPhieuKham
        End Get
        Set(ByVal Value As Integer)
            strMaPhieuKham = Value
        End Set
    End Property

    Property MaChiTietDanhSach() As Integer
        Get
            Return strMaChiTietDanhSach
        End Get
        Set(ByVal Value As Integer)
            strMaChiTietDanhSach = Value
        End Set
    End Property
    Property TrieuChung() As Integer
        Get
            Return strTrieuChung
        End Get
        Set(ByVal Value As Integer)
            strTrieuChung = Value
        End Set
    End Property
    Property MaLoaiBenh() As Integer
        Get
            Return strMaLoaiBenh
        End Get
        Set(value As Integer)
            strMaLoaiBenh = value
        End Set
    End Property
#End Region
End Class