Public Class ThuvienDTO

    Private strMSBN As Integer
    Private strHoten As String
    Private strDiaChi As String
    Private dateNgaySinh As DateTime
    Private strNguoilap As String
    Private strNgaylapthe As String
    Public Sub New()
    End Sub
    Public Sub New(strMSBN As Integer, strHoten As String, strDiaChi As String, dateNgaySinh As DateTime, strNguoilap As String, strNgaylapthe As String)
        Me.strMSBN = strMSBN
        Me.strHoten = strHoten
        Me.strDiaChi = strDiaChi
        Me.dateNgaySinh = dateNgaySinh
        Me.strNguoilap = strNguoilap
        Me.strNgaylapthe = strNgaylapthe
    End Sub


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
    Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal Value As String)
            strEmail = Value
        End Set
    End Property
    Property Loaidg As String
        Get
            Return strLoaidg
        End Get
        Set(ByVal Value As String)
            strLoaidg = Value
        End Set
    End Property
    Property Nguoilap As String
        Get
            Return strNguoilap
        End Get
        Set(ByVal Value As String)
            strNguoilap = Value
        End Set
    End Property
    Property Ngaylapthe As String
        Get
            Return strNgaylapthe
        End Get
        Set(ByVal Value As String)
            strNgaylapthe = Value
        End Set
    End Property


End Class
