Public Class BenhNhanDTO

#Region "Fields"
    Private strMaBenhNhan As String
    Private strHoTen As String
    Private strDiaChi As String
    Private dateNgaySinh As DateTime
    Private strGioiTinh As String
#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaBenhNhan As String, strHoTen As String, strDiaChi As String, dateNgaySinh As DateTime, strGioiTinh As String)
        MaBenhNhan = strMaBenhNhan
        HoTen = strHoTen
        DiaChi = strDiaChi
        NgaySinh = dateNgaySinh
        GioiTinh = strGioiTinh
    End Sub
#End Region

#Region "Property"
    Public Property MaBenhNhan() As String
        Get
            Return strMaBenhNhan
        End Get
        Set(ByVal value As String)
            strMaBenhNhan = value
        End Set
    End Property

    Public Property HoTen() As String
        Get
            Return strHoTen
        End Get
        Set(ByVal Value As String)
            strHoTen = Value
        End Set
    End Property

    Public Property DiaChi() As String
        Get
            Return strDiaChi
        End Get
        Set(ByVal Value As String)
            strDiaChi = Value
        End Set
    End Property

    Public Property NgaySinh() As DateTime
        Get
            Return dateNgaySinh
        End Get
        Set(ByVal Value As DateTime)
            dateNgaySinh = Value
        End Set
    End Property

    Public Property GioiTinh() As String
        Get
            Return strGioiTinh
        End Get
        Set(ByVal Value As String)
            strGioiTinh = Value
        End Set
    End Property

#End Region

End Class
