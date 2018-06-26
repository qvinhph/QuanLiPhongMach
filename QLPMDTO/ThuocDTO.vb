Public Class ThuocDTO

#Region "Fields"

    Private strMaThuoc As String
    Private strMaDonVi As String
    Private iSoLuong As Integer
    Private fDonGia As Single

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaThuoc As String, strMaDonVi As String,
                   iSoLuong As Integer, fDonGia As Single)
        MaThuoc = strMaThuoc
        MaDonVi = strMaDonVi
        SoLuong = iSoLuong
        DonGia = fDonGia
    End Sub

#End Region

#Region "Property"

    Public Property MaThuoc As String
        Get
            Return strMaThuoc
        End Get
        Set(value As String)
            strMaThuoc = value
        End Set
    End Property

    Public Property MaDonVi As String
        Get
            Return strMaDonVi
        End Get
        Set(value As String)
            strMaDonVi = value
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

    Public Property DonGia As Single
        Get
            Return fDonGia
        End Get
        Set(value As Single)
            fDonGia = value
        End Set
    End Property

#End Region

End Class
