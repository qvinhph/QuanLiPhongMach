Public Class ChiTietBaoCaoDoanhThuDTO

#Region "Fields"

    Private strMaChiTietBaoCaoDoanhThu As String
    Private strMaBaoCaoDoanhThu As String
    Private dtNgay As DateTime
    Private iSoBenhNhan As Integer
    Private sDoanhThu As Single
    Private sTyLe As Single

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaChiTietBaoCaoDoanhThu As String, strMaBaoCaoDoanhThu As String,
                   dtNgay As DateTime, iSoBenhNhan As Integer, sDoanhThu As Single, sTyLe As Single)
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

    Public Property DoanhThu As Single
        Get
            Return sDoanhThu
        End Get
        Set(value As Single)
            sDoanhThu = value
        End Set
    End Property

    Public Property TyLe As Single
        Get
            Return sTyLe
        End Get
        Set(value As Single)
            sTyLe = value
        End Set
    End Property

#End Region

End Class
