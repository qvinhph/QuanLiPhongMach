Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPMDTO
Imports Utility

Public Class PhieuKhamDAL

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

    Public Function Insert(phieuKham As PhieuKhamDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblphieu_kham] ([ma_phieu_kham], [ma_chi_tiet_danh_sach], [trieu_chung], [ma_loai_benh])"
        query &= "VALUES (@ma_phieu_kham, @ma_chi_tiet_danh_sach, @trieu_chung, @ma_loai_benh) "

        Dim nextID = Nothing
        nextID = BuildID(nextID)
        phieuKham.MaPhieuKham = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_phieu_kham", phieuKham.MaPhieuKham)
                    .Parameters.AddWithValue("@ma_chi_tiet_danh_sach", phieuKham.MaChiTietDanhSach)
                    .Parameters.AddWithValue("@trieu_chung", phieuKham.TrieuChung)
                    .Parameters.AddWithValue("@ma_loai_benh", phieuKham.MaLoaiBenh)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm phiếu khám mới không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Update(phieuKham As PhieuKhamDTO) As Result

        Dim query As String = Nothing
        query &= "UPDATE [tblphieu_kham] SET "
        query &= "[ma_phieu_kham] = @ma_phieu_kham "
        query &= "[ma_chi_tiet_danh_sach] = @ma_chi_tiet_danh_sach "
        query &= "[trieu_chung] = @trieu_chung "
        query &= "[ma_loai_benh] = @ma_loai_benh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_phieu_kham", phieuKham.MaPhieuKham)
                    .Parameters.AddWithValue("@ma_chi_tiet_danh_sach", phieuKham.MaChiTietDanhSach)
                    .Parameters.AddWithValue("@trieu_chung", phieuKham.TrieuChung)
                    .Parameters.AddWithValue("@ma_loai_benh", phieuKham.MaLoaiBenh)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật phiếu khám không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Delete(maPhieuKham As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblphieu_kham] "
        query &= " WHERE "
        query &= " [ma_phieu_kham] = @ma_phieu_kham "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_phieu_kham", maPhieuKham)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa phiếu khám không thành công", ex.StackTrace)
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
        query &= "SELECT TOP 1 [ma_phieu_kham] "
        query &= "FROM [tblphieu_kham] "
        query &= "ORDER BY [ma_phieu_kham] DESC "

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
                            idOnDB = reader("ma_phieu_kham")
                        End While
                    Else
                        idOnDB = "PK000000"
                    End If

                    If (idOnDB <> Nothing And idOnDB.Length >= 8) Then
                        Dim currentNumberID = Integer.Parse(idOnDB.Substring(2, 6))
                        Dim nextNumberID = currentNumberID + 1
                        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
                        nextID = "PK" + strNextNumberID
                        'For debugging
                        Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy mã tự động của phiếu khám mới không thành công", ex.StackTrace)

                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function SelectAll(ByRef listPhieuKham As List(Of PhieuKhamDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tblphieu_kham] "

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
                        listPhieuKham.Clear()
                        While reader.Read()
                            listPhieuKham.Add(New PhieuKhamDTO(reader("ma_phieu_kham"), reader("ma_chi_tiet_danh_sach"), reader("trieu_chung"), reader("ma_loai_benh")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả phiếu khám không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

End Class
