Public Class BaoCaoDoanhThuDTO

#Region "Fields"

    Private strMaBaoCaoDoanhThu As String
    Private iThangBaoCao As Integer

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaBaoCaoDoanhThu As String, iThangBaoCao As Integer)
        MaBaoCaoDoanhThu = strMaBaoCaoDoanhThu
        ThangBaoCao = iThangBaoCao
    End Sub

#End Region

#Region "Property"

    Public Property MaBaoCaoDoanhThu As String
        Get
            Return strMaBaoCaoDoanhThu
        End Get
        Set(value As String)
            strMaBaoCaoDoanhThu = value
        End Set
    End Property

    Public Property ThangBaoCao As Integer
        Get
            Return iThangBaoCao
        End Get
        Set(value As Integer)
            iThangBaoCao = value
        End Set
    End Property

#End Region

End Class
