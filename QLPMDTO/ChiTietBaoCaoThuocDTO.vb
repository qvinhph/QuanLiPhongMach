Public Class ChiTietBaoCaoThuocDTO

#Region "Fields"

    Private strMaChiTietBaoCaoThuoc As String
    Private strMaBaoCaoThuoc As String
    Private dtNgay As DateTime
    Private strMaThuoc As String
    Private iTongSoLuong As Integer
    Private iSoLanDung As Integer

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaChiTietBaoCaoThuoc As String, strMaBaoCaoThuoc As Integer, dtNgay As DateTime,
                   strMaThuoc As String, iTongsoLuong As Integer, iSoLanDung As Integer)
        MaChiTietBaoCaoThuoc = strMaChiTietBaoCaoThuoc
        MaBaoCaoThuoc = strMaBaoCaoThuoc
        Ngay = dtNgay
        MaThuoc = strMaThuoc
        TongSoLuong = iTongsoLuong
        SoLanDung = iSoLanDung
    End Sub

#End Region

#Region "Property"

    Public Property MaChiTietBaoCaoThuoc As String
        Get
            Return strMaChiTietBaoCaoThuoc
        End Get
        Set(value As String)
            strMaChiTietBaoCaoThuoc = value
        End Set
    End Property

    Public Property MaBaoCaoThuoc As String
        Get
            Return strMaBaoCaoThuoc
        End Get
        Set(value As String)
            strMaBaoCaoThuoc = value
        End Set
    End Property

    Public Property Ngay As Date
        Get
            Return dtNgay
        End Get
        Set(value As Date)
            dtNgay = value
        End Set
    End Property

    Public Property MaThuoc As String
        Get
            Return strMaThuoc
        End Get
        Set(value As String)
            strMaThuoc = value
        End Set
    End Property

    Public Property TongSoLuong As Integer
        Get
            Return iTongSoLuong
        End Get
        Set(value As Integer)
            iTongSoLuong = value
        End Set
    End Property

    Public Property SoLanDung As Integer
        Get
            Return iSoLanDung
        End Get
        Set(value As Integer)
            iSoLanDung = value
        End Set
    End Property

#End Region

End Class
