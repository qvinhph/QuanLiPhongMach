Public Class DanhSachKhamDTO

#Region "Fields"
    Private strMaDanhSach As String
    Private dateNgayKham As Date
#End Region

#Region "Constructor"
    Public Sub New()

    End Sub
    Public Sub New(strMaDanhSach As String, dateNgayKham As Date)
        MaDanhSach = strMaDanhSach
        NgayKham = dateNgayKham
    End Sub

#End Region

#Region "Property"
    Public Property MaDanhSach() As String
        Get
            Return strMaDanhSach
        End Get
        Set(ByVal Value As String)
            strMaDanhSach = Value
        End Set
    End Property

    Public Property NgayKham As Date
        Get
            Return dateNgayKham
        End Get
        Set(value As Date)
            dateNgayKham = value
        End Set
    End Property

#End Region

End Class