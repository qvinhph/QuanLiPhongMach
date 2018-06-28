Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPMDTO
Imports Utility

Public Class BenhNhanDAL

#Region "Fields"

    Private connectionString As String

#End Region

#Region "Constructor"

    ''' <summary>
    ''' Read ConnectionString value from App.config file
    ''' </summary>
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(benhNhan As BenhnhanDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblbenh_nhan] ([ma_benh_nhan], [ho_ten], [gioi_tinh], [nam_sinh], [dia_chi], [ngay_kham])"
        query &= "VALUES (@ma_benh_nhan, @ho_ten, @gioi_tinh, @nam_sinh, @dia_chi, @ngay_kham) "

        Dim nextID = Nothing
        nextID = BuildID(nextID)
        benhNhan.MSBN = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_benh_nhan", benhNhan.MSBN)
                    .Parameters.AddWithValue("@ho_ten", benhNhan.HoTen)
                    .Parameters.AddWithValue("@gioi_tinh", benhNhan.Gioitinh)
                    .Parameters.AddWithValue("@nam_sinh", benhNhan.NgaySinh)
                    .Parameters.AddWithValue("@dia_chi", benhNhan.DiaChi)
                    .Parameters.AddWithValue("@ngay_kham", benhNhan.NgayKham)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm bệnh nhân mới không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Update(benhNhan As BenhnhanDTO) As Result

        Dim query As String = Nothing
        query &= "UPDATE [tblbenh_nhan] SET "
        query &= "[ma_benh_nhan] = @ma_benh_nhan "
        query &= "[ho_ten] = @ho_ten "
        query &= "[gioi_tinh] = @gioi_tinh "
        query &= "[nam_sinh] = @nam_sinh "
        query &= "[dia_chi] = @dia_chi "
        query &= "[ngay_kham] = @ngay_kham "
        query &= "WHERE [ma_benh_nhan] = @ma_benh_nhan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_benh_nhan", benhNhan.MSBN)
                    .Parameters.AddWithValue("@ho_ten", benhNhan.HoTen)
                    .Parameters.AddWithValue("@gioi_tinh", benhNhan.Gioitinh)
                    .Parameters.AddWithValue("@nam_sinh", benhNhan.NgaySinh)
                    .Parameters.AddWithValue("@dia_chi", benhNhan.DiaChi)
                    .Parameters.AddWithValue("@ngay_kham", benhNhan.NgayKham)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật bệnh nhân không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Delete(maBenhNhan As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblbenh_nhan] "
        query &= " WHERE "
        query &= " [ma_benh_nhan] = @ma_benh_nhan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_don_vi", maBenhNhan)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa bệnh nhân không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result 'ex: DV000001

        nextID = String.Empty

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ma_benh_nhan] "
        query &= "FROM [tblbenh_nhan] "
        query &= "ORDER BY [ma_benh_nhan] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As String = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("ma_benh_nhan")
                        End While
                    Else
                        idOnDB = "BN000000"
                    End If

                    If (idOnDB <> Nothing And idOnDB.Length >= 8) Then
                        Dim currentNumberID = Integer.Parse(idOnDB.Substring(2, 6))
                        Dim nextNumberID = currentNumberID + 1
                        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
                        nextID = "BN" + strNextNumberID
                        'For debugging
                        Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy mã tự động của bệnh nhân mới không thành công", ex.StackTrace)

                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function SelectAll(ByRef listBenhNhan As List(Of BenhnhanDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tblbenh_nhan] "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBenhNhan.Clear()
                        While reader.Read()
                            listBenhNhan.Add(New BenhnhanDTO(reader("ma_benh_nhan"), reader("ho_ten"), reader("dia_chi"), reader("nam_sinh"), reader("ngay_kham"), reader("gioi_tinh")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả bệnh nhân không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

End Class
