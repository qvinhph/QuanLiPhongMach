Public Class BaoCaoThuocDTO

#Region "Fields"

    Private strMaBaoCaoThuoc As String
    Private iThangBaoCao As Integer

#End Region

#Region "Constructor"

    Public Sub New()
    End Sub

    Public Sub New(strMaBaoCaoThuoc As String, iThangBaoCao As Integer)
        MaBaoCaoThuoc = strMaBaoCaoThuoc
        ThangBaoCao = iThangBaoCao
    End Sub

#End Region

#Region "Property"

    Public Property MaBaoCaoThuoc As String
        Get
            Return strMaBaoCaoThuoc
        End Get
        Set(value As String)
            strMaBaoCaoThuoc = value
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
