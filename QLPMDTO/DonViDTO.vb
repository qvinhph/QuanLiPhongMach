Public Class DonViDTO

#Region "Fields"

    Private strMaDonVi As String
    Private strDonVi As String

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaDonVi As String, strDonVi As String)
        MaDonVi = strMaDonVi
        DonVi = strDonVi
    End Sub

#End Region

#Region "Property"

    Public Property MaDonVi As String
        Get
            Return strMaDonVi
        End Get
        Set(value As String)
            strMaDonVi = value
        End Set
    End Property

    Public Property DonVi As String
        Get
            Return strDonVi
        End Get
        Set(value As String)
            strDonVi = value
        End Set
    End Property

#End Region

End Class
