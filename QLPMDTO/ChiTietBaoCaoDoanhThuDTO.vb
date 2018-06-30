Public Class ChiTietBaoCaoDoanhThuDTO

#Region "Fields"

    Private strMaChiTietBaoCaoDoanhThu As String
    Private strMaBaoCaoDoanhThu As String
    Private dtNgay As DateTime
    Private iSoBenhNhan As Integer
    Private sDoanhThu As Double
    Private sTyLe As Double

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaChiTietBaoCaoDoanhThu As String, strMaBaoCaoDoanhThu As String,
                   dtNgay As DateTime, iSoBenhNhan As Integer, sDoanhThu As Double, sTyLe As Double)
        MaChiTietBaoCaoDoanhThu = strMaChiTietBaoCaoDoanhThu
        MaBaoCaoDoanhThu = strMaBaoCaoDoanhThu
        Ngay = dtNgay
        SoBenhNhan = iSoBenhNhan
        DoanhThu = sDoanhThu
        TyLe = sTyLe
    End Sub

#End Region

#Region "Property"

    Public Property MaChiTietBaoCaoDoanhThu As String
        Get
            Return strMaChiTietBaoCaoDoanhThu
        End Get
        Set(value As String)
            strMaChiTietBaoCaoDoanhThu = value
        End Set
    End Property

    Public Property MaBaoCaoDoanhThu As String
        Get
            Return strMaBaoCaoDoanhThu
        End Get
        Set(value As String)
            strMaBaoCaoDoanhThu = value
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

    Public Property SoBenhNhan As Integer
        Get
            Return iSoBenhNhan
        End Get
        Set(value As Integer)
            iSoBenhNhan = value
        End Set
    End Property

    Public Property DoanhThu As Double
        Get
            Return sDoanhThu
        End Get
        Set(value As Double)
            sDoanhThu = value
        End Set
    End Property

    Public Property TyLe As Double
        Get
            Return sTyLe
        End Get
        Set(value As Double)
            sTyLe = value
        End Set
    End Property

#End Region

End Class
