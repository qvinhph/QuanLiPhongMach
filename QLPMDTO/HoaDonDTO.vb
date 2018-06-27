Public Class HoaDonDTO

#Region "Fields"

    Private strMaHoaDon As String
    Private strMaPhieuKham As String
    Private iTienThuoc As Integer

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaHoaDon As String, strMaPhieuKham As String, iTienThuoc As Integer)
        MaHoaDon = strMaHoaDon
        MaPhieuKham = strMaPhieuKham
        TienThuoc = iTienThuoc
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
    Public Property TienThuoc As Integer
        Get
            Return iTienThuoc
        End Get
        Set(value As Integer)
            iTienThuoc = value
        End Set
    End Property

#End Region

End Class
