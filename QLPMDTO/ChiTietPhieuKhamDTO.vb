Public Class ChiTietPhieuKhamDTO

#Region "Fields"

    Private strMaChiTietPhieuKham As String
    Private strMaPhieuKham As String
    Private strMaThuoc As String
    Private iSoLuong As Integer

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaChiTietPhieuKham As String, strMaPhieuKham As String,
                   strMaThuoc As String, iSoLuong As Integer)
        MaChiTietPhieuKham = strMaChiTietPhieuKham
        MaPhieuKham = strMaPhieuKham
        MaThuoc = strMaThuoc
        SoLuong = iSoLuong
    End Sub

#End Region

#Region "Property"

    Public Property MaChiTietPhieuKham As String
        Get
            Return strMaChiTietPhieuKham
        End Get
        Set(ByVal value As String)
            strMaChiTietPhieuKham = value
        End Set
    End Property

    Public Property MaPhieuKham As String
        Get
            Return strMaPhieuKham
        End Get
        Set(value As String)
            strMaPhieuKham = value
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

    Public Property SoLuong As Integer
        Get
            Return iSoLuong
        End Get
        Set(value As Integer)
            iSoLuong = value
        End Set
    End Property

#End Region

End Class
