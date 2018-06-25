Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHS1DTO
Imports Utility

Public Class PhongmachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub


    Public Function buildMSDG(ByRef nextMsdg As String) As Result 'ex: 18222229

        nextMsdg = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextMsdg = x + "000000"

        Dim query As String = String.Empty
        query &= "Select TOP 1 [msdg] "
        query &= "From [tblDocGia] "
        query &= "Order By [msdg] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("msdg")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextMsdg = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextMsdg = nextMsdg + tmp
                        System.Console.WriteLine(nextMsdg)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số độc giả kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(dg As ThuvienDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblDocgia] ([msdg], [hoten], [diachi], [ngaysinh], [email], [loaidg], [nguoilap], [ngaylapthe])"
        query &= "VALUES (@msdg,@hoten,@diachi,@ngaysinh,@email,@loaidg,@nguoilap,@ngaylapthe)"

        'get MSHS
        Dim nextMsdg = "1"
        buildMSDG(nextMsdg)
        dg.MSBN = nextMsdg

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@msdg", dg.MSBN)
                    .Parameters.AddWithValue("@hoten", dg.HoTen)
                    .Parameters.AddWithValue("@diachi", dg.DiaChi)
                    .Parameters.AddWithValue("@ngaysinh", dg.NgaySinh)
                    .Parameters.AddWithValue("@email", dg.Email)
                    .Parameters.AddWithValue("@loaidg", dg.Loaidg)
                    .Parameters.AddWithValue("@nguoilap", dg.Nguoilap)
                    .Parameters.AddWithValue("@ngaylapthe", dg.Ngaylapthe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function










End Class
