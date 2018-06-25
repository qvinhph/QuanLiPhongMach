Public Class ThamSoDTO
#Region "Fields"
    Private intSoBenhNhanMax As Integer
    Private intTienKham As Integer
#End Region
#Region "Methods"
    Public Sub New()

    End Sub

    Public Sub New(intSoBenhNhanMax As Integer, intTienKham As Integer)
        Me.intSoBenhNhanMax = intSoBenhNhanMax
        Me.intTienKham = intTienKham

    End Sub
#End Region
#Region "Property"
    Property SoBenhNhanMax() As Integer
        Get
            Return intSoBenhNhanMax
        End Get
        Set(ByVal Value As Integer)
            intSoBenhNhanMax = Value
        End Set
    End Property
#End Region
End Class