Public Class ThamSoDTO

#Region "Fields"
    Private iSoBenhNhanToiDa As Integer
    Private iTienKham As Single
#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(iSoBenhNhanMax As Integer, iTienKham As Single)
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

    Property TienKham() As Single
        Get
            Return iTienKham
        End Get
        Set(ByVal Value As Single)
            iTienKham = Value
        End Set
    End Property
#End Region

End Class