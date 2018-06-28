Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPMDTO
Imports Utility

Public Class ChiTietBaoCaoThuocDAL

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

    Public Function Insert(chiTietBCT As ChiTietBaoCaoThuocDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblchi_tiet_bao_cao_thuoc] ([ma_chi_tiet_bao_cao_thuoc], [ma_bao_cao_thuoc], "
        query &= "[ngay], [ma_thuoc], [tong_so_luong], [so_lan_dung]) "
        query &= "VALUES (@ma_chi_tiet_bao_cao_thuoc, @ma_bao_cao_thuoc, @ngay, @ma_thuoc, @tong_so_luong, @so_lan_dung) "

        Dim nextID = Nothing
        nextID = BuildID(nextID)
        chiTietBCT.MaChiTietBaoCaoThuoc = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_chi_tiet_bao_cao_thuoc", chiTietBCT.MaChiTietBaoCaoThuoc)
                    .Parameters.AddWithValue("@ma_bao_cao_thuoc", chiTietBCT.MaBaoCaoThuoc)
                    .Parameters.AddWithValue("@ngay", chiTietBCT.Ngay)
                    .Parameters.AddWithValue("@ma_thuoc", chiTietBCT.MaThuoc)
                    .Parameters.AddWithValue("@tong_so_luong", chiTietBCT.TongSoLuong)
                    .Parameters.AddWithValue("@so_lan_dung", chiTietBCT.SoLanDung)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm chi tiết báo cáo thuốc mới không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Update(chiTietBCT As ChiTietBaoCaoThuocDTO) As Result

        Dim query As String = Nothing
        query &= "UPDATE [tblchi_tiet_bao_cao_thuoc] SET "
        query &= "[ma_chi_tiet_bao_cao_thuoc] = @ma_chi_tiet_bao_cao_thuoc "
        query &= "[ma_bao_cao_thuoc] = @ma_bao_cao_thuoc "
        query &= "[ngay] = @ngay "
        query &= "[ma_thuoc] = @ma_thuoc "
        query &= "[tong_so_luong] = @tong_so_luong "
        query &= "[so_lan_dung] = @so_lan_dung "
        query &= "WHERE [ma_chi_tiet_bao_cao_thuoc] = @ma_chi_tiet_bao_cao_thuoc "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_chi_tiet_bao_cao_thuoc", chiTietBCT.MaChiTietBaoCaoThuoc)
                    .Parameters.AddWithValue("@ma_bao_cao_thuoc", chiTietBCT.MaBaoCaoThuoc)
                    .Parameters.AddWithValue("@ngay", chiTietBCT.Ngay)
                    .Parameters.AddWithValue("@ma_thuoc", chiTietBCT.MaThuoc)
                    .Parameters.AddWithValue("@tong_so_luong", chiTietBCT.TongSoLuong)
                    .Parameters.AddWithValue("@so_lan_dung", chiTietBCT.SoLanDung)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật chi tiết báo cáo thuốc không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Delete(maChiTietBaoCaoThuoc As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblchi_tiet_bao_cao_thuoc] "
        query &= " WHERE "
        query &= " [ma_chi_tiet_bao_cao_thuoc] = @ma_chi_tiet_bao_cao_thuoc "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_chi_tiet_bao_cao_thuoc", maChiTietBaoCaoThuoc)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa chi tiết báo cáo thuốc không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result 'ex: CT000001

        nextID = String.Empty

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ma_chi_tiet_bao_cao_thuoc] "
        query &= "FROM [tblchi_tiet_bao_cao_thuoc] "
        query &= "ORDER BY [ma_chi_tiet_bao_cao_thuoc] DESC "

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
                            idOnDB = reader("ma_chi_tiet_bao_cao_thuoc")
                        End While
                    Else
                        idOnDB = "CT000000"
                    End If

                    If (idOnDB <> Nothing And idOnDB.Length >= 8) Then
                        Dim currentNumberID = Integer.Parse(idOnDB.Substring(2, 6))
                        Dim nextNumberID = currentNumberID + 1
                        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
                        nextID = "CT" + strNextNumberID
                        'For debugging
                        Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy mã tự động của chi tiết báo cáo thuốc mới không thành công", ex.StackTrace)

                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function SelectAll_ByMaBaoCaoThuoc(maBaoCaoThuoc As String, ByRef listChiTietBCT As List(Of ChiTietBaoCaoThuocDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tblchi_tiet_bao_cao_thuoc] "
        query &= "WHERE [tblchi_tiet_bao_cao_thuoc].[ma_bao_cao_thuoc] = @ma_bao_cao_thuoc "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_bao_cao_thuoc", maBaoCaoThuoc)
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listChiTietBCT.Clear()
                        While reader.Read()
                            listChiTietBCT.Add(New ChiTietBaoCaoThuocDTO(reader("ma_chi_tiet_bao_cao_thuoc"), reader("ma_bao_cao_thuoc"),
                                                                      reader("ngay"), reader("ma_thuoc"), reader("tong_so_luong"), reader("so_lan_dung")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả chi tiết báo cáo thuốc theo mã báo cáo thuốc khám không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

End Class
