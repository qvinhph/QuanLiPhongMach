Public Class HoaDonDTO

#Region "Fields"

    Private strMaHoaDon As String
    Private strMaPhieuKham As String
    Private dTienThuoc As Double
    Private dTienKham As Double

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaHoaDon As String, strMaPhieuKham As String, dTienThuoc As Double, dTienKham As Double)
        MaHoaDon = strMaHoaDon
        MaPhieuKham = strMaPhieuKham
        TienThuoc = dTienThuoc
        TienKham = dTienKham
    End Sub

#End Region

#Region "Property"

    Public Property MaPhieuKham As String
        Get
            Return strMaPhieuKham
        End Get
        Set(value As String)
            strMaPhieuKham = value
        End Set
    End Property

    Public Property MaHoaDon As String
        Get
            Return strMaHoaDon
        End Get
        Set(value As String)
            strMaHoaDon = value
        End Set
    End Property
    Public Property TienThuoc As Double
        Get
            Return dTienThuoc
        End Get
        Set(value As Double)
            dTienThuoc = value
        End Set
    End Property

    Public Property TienKham As Double
        Get
            Return dTienKham
        End Get
        Set(value As Double)
            dTienKham = value
        End Set
    End Property

#End Region

End Class
