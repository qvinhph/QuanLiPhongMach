Public Class BenhnhanDTO
#Region "Fields"
    Private strMSBN As Integer
    Private strHoten As String
    Private strDiaChi As String
    Private dateNgaySinh As DateTime
    Private strNgayKham As String
#End Region
#Region "Methods"


    Public Sub New()
    End Sub
    Public Sub New(strMSBN As Integer, strHoten As String, strDiaChi As String, dateNgaySinh As DateTime, strNgayKham As String)
        Me.strMSBN = strMSBN
        Me.strHoten = strHoten
        Me.strDiaChi = strDiaChi
        Me.dateNgaySinh = dateNgaySinh
        Me.strNgayKham = strNgayKham
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

    Property NgayKham() As String
        Get
            Return strNgayKham
        End Get
        Set(ByVal Value As String)
            strNgayKham = Value
        End Set
    End Property

#End Region
End Class
