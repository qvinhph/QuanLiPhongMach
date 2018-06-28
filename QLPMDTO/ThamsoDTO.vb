Public Class ThamSoDTO

#Region "Fields"
    Private iSoBenhNhanToiDa As Integer
    Private iTienKham As Integer
#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(intSoBenhNhanMax As Integer, intTienKham As Integer)
        SoBenhNhanToiDa = iSoBenhNhanToiDa
        TienKham = iTienKham

    End Sub
#End Region

#Region "Property"
    Property SoBenhNhanToiDa() As Integer
        Get
            Return iSoBenhNhanToiDa
        End Get
        Set(ByVal Value As Integer)
            iSoBenhNhanToiDa = Value
        End Set
    End Property

    Property TienKham() As Integer
        Get
            Return iTienKham
        End Get
        Set(ByVal Value As Integer)
            iTienKham = Value
        End Set
    End Property
#End Region

End Class