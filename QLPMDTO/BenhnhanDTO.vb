Public Class BenhnhanDTO

#Region "Fields"
    Private strMSBN As String
    Private strHoten As String
    Private strDiaChi As String
    Private dateNgaySinh As DateTime
    Private dateNgayKham As String
    Private strGioiTinh As String
#End Region

#Region "Constructor"


    Public Sub New()
    End Sub
    Public Sub New(strMSBN As String, strHoten As String, strDiaChi As String, dateNgaySinh As DateTime, dateNgayKham As Date, strGioiTinh As String)
        MSBN = strMSBN
        HoTen = strHoten
        DiaChi = strDiaChi
        NgaySinh = dateNgaySinh
        NgayKham = dateNgayKham
        Gioitinh = strGioiTinh
    End Sub
#End Region

#Region "Property"
    Property MSBN() As String
        Get
            Return strMSBN
        End Get
        Set(ByVal Value As String)
            strMSBN = Value
        End Set
    End Property

    Property HoTen() As String
        Get
            Return strHoten
        End Get
        Set(ByVal Value As String)
            strHoten = Value
        End Set
    End Property

    Property DiaChi() As String
        Get
            Return strDiaChi
        End Get
        Set(ByVal Value As String)
            strDiaChi = Value
        End Set
    End Property
    Property NgaySinh() As DateTime
        Get
            Return dateNgaySinh
        End Get
        Set(ByVal Value As DateTime)
            dateNgaySinh = Value
        End Set
    End Property

    Property NgayKham() As Date
        Get
            Return dateNgayKham
        End Get
        Set(ByVal Value As Date)
            dateNgayKham = Value
        End Set
    End Property

    Property Gioitinh() As String
        Get
            Return strGioiTinh
        End Get
        Set(ByVal Value As String)
            strGioiTinh = Value
        End Set
    End Property

#End Region

End Class
