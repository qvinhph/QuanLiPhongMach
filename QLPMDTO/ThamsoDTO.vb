Public Class ThamSoDTO

#Region "Fields"
    Private iSoBenhNhanMax As Integer
    Private iTienKham As Integer
#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(intSoBenhNhanMax As Integer, intTienKham As Integer)
        SoBenhNhanMax = iSoBenhNhanMax
        TienKham = iTienKham

    End Sub
#End Region

#Region "Property"
    Property SoBenhNhanMax() As Integer
        Get
            Return iSoBenhNhanMax
        End Get
        Set(ByVal Value As Integer)
            iSoBenhNhanMax = Value
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