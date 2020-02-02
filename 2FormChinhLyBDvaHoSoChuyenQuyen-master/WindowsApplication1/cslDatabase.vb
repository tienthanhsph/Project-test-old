Imports System.Data.SqlClient
Public Class clsDatabase
    'Khai báo biến kiểm tra lỗi
    Private strError As String = ""
    'Khai báo biến Connection
    Dim sqlCon As SqlConnection
    'Khai báo chuỗi kết nối
    Dim strConnection As String = ""
    'Khai báo thuộc tính ghi chuỗi kết nối
    Public WriteOnly Property Connection() As String
        Set(ByVal value As String)
            strConnection = value
        End Set
    End Property
    'Khai báo thuộc tính đọc thông báo lỗi
    Public ReadOnly Property Err() As String
        Get
            Return strError
        End Get
    End Property
    'Mở kết nối cơ sở dữ liệu
    Public Function OpenConnection() As Boolean
        Dim boolSuccessfully As Boolean = False
        Try
            'Truyền chuỗi kết nối cơ sở dữ liệu
            sqlCon = New SqlConnection(strConnection)
            'Mở kết nối cơ sở dữ liệu
            sqlCon.Open()
            strError = ""
            boolSuccessfully = True
        Catch eq As SqlException
            strError = eq.Message
            MsgBox(" Lỗi: " & vbNewLine & eq.Message, MsgBoxStyle.Information, "Lỗi kết nối dữ liệu")
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Lỗi: " & vbNewLine & ex.Message, MsgBoxStyle.Information, "Lỗi kết nối dữ liệu")
        End Try
        Return boolSuccessfully
    End Function
    'Đóng kết nối cơ sở dữ liệu
    Public Sub CloseConnection()
        'Nếu chưa đóng kết nối thì đóng kết nối lại
        If sqlCon.State <> ConnectionState.Closed Then
            'Đóng kết nối
            sqlCon.Close()
            'Giải phóng 
            sqlCon.Dispose()
        End If
    End Sub
    'Hiển thị dữ liệu theo điều kiện
    Public Sub getValue(ByRef dtResult As DataTable, ByVal strSP As String, ByVal strPara() As String, ByVal strValues() As String)
        Try
            'Khai báo và khởi tạo đối tượng SqlCommand
            Dim sqlCom As New SqlCommand
            'Gán kết nối cơ sở dữ liệu
            sqlCom.Connection = sqlCon
            sqlCom.CommandTimeout = 0
            'Nhận kiểu thực thì câu lệnh truy vấn cơ sở dữ liệu là thủ tục 
            sqlCom.CommandType = CommandType.StoredProcedure
            'Gán Tên thủ tục
            sqlCom.CommandText = strSP
            'Khai báo đối tượng SqlParameter
            Dim sqlPara As SqlParameter

            'Duỵệt trên từng tham số với giá trị tương ứng
            For i As Integer = 0 To strPara.Length - 1
                'Khởi tạo đối tượng SqlParameter và gán từng cặp giá trị
                'vào tham số tương ứng                
                sqlPara = New SqlParameter(strPara(i), strValues(i))
                'Add vào tập hợp thực thi truy vấn SqlCommand
                sqlCom.Parameters.Add(sqlPara)
            Next
            'Khai báo vào khởi tạo đối tượng SqlDataAdapter
            Dim sqlDataAdapter As New SqlDataAdapter(sqlCom)
            'Điền dữ liệu vào đối tượng DataTable
            sqlDataAdapter.Fill(dtResult)
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Hiển thị dữ liệu " & vbNewLine & " Lỗi " & vbNewLine & ex.Message, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub
    Public Sub getValue1(ByRef dtResult As DataTable, ByVal strSP As String, ByVal strPara() As String, ByVal strValues() As String, ByRef TongSoBanGhi As Integer)
        Try
            'Khai báo và khởi tạo đối tượng SqlCommand
            Dim sqlCom As New SqlCommand
            'Gán kết nối cơ sở dữ liệu
            sqlCom.Connection = sqlCon
            sqlCom.CommandTimeout = 0
            'Nhận kiểu thực thì câu lệnh truy vấn cơ sở dữ liệu là thủ tục 
            sqlCom.CommandType = CommandType.StoredProcedure
            'Gán Tên thủ tục
            sqlCom.CommandText = strSP
            'Khai báo đối tượng SqlParameter
            Dim sqlPara As SqlParameter

            'Duỵệt trên từng tham số với giá trị tương ứng
            For i As Integer = 0 To strPara.Length - 1
                'Khởi tạo đối tượng SqlParameter và gán từng cặp giá trị
                'vào tham số tương ứng                
                sqlPara = New SqlParameter(strPara(i), strValues(i))
                'Add vào tập hợp thực thi truy vấn SqlCommand
                If (sqlPara.ParameterName = "@TongSoBanGhi") Then
                    sqlPara.DbType = DbType.Int32
                    sqlPara.Direction = ParameterDirection.Output
                End If
                sqlCom.Parameters.Add(sqlPara)
            Next
            'Khai báo vào khởi tạo đối tượng SqlDataAdapter
            Dim sqlDataAdapter As New SqlDataAdapter(sqlCom)
            'Điền dữ liệu vào đối tượng DataTable
            sqlDataAdapter.Fill(dtResult)
            Try
                TongSoBanGhi = sqlCom.Parameters("@TongSoBanGhi").Value
            Catch ex As Exception
                TongSoBanGhi = 0
            End Try
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Hiển thị dữ liệu " & vbNewLine & " Lỗi " & vbNewLine & ex.Message, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub
    'Thực thi phát biểu Sql dạng hành động: Thêm, sửa, xoá
    Public Sub ExecuteSP(ByVal strSP As String, ByVal strParameters() As String, ByVal strValues() As String, ByRef strResult As String)
        Try
            'Khai báo đối tượng SqlCommand
            Dim sqlCom As New SqlCommand
            'Gán kết nối tới cơ sở dữ liệu
            sqlCom.Connection = sqlCon
            sqlCom.CommandTimeout = 60
            'Xác định kểu thực thi câu lệnh Sql là StoredProcedure
            sqlCom.CommandType = CommandType.StoredProcedure
            'Nhận tên Thủ tục trong cơ sở dữ liệu 
            sqlCom.CommandText = strSP
            'Khai báo đối tượng SqlParameter
            Dim sqlPara As SqlParameter
            'Duyệt qua từng phần tử giá trị
            For i As Integer = 0 To strValues.Length - 1
                'Khởi tạo đối tượng SqlParameter
                sqlPara = New SqlParameter(strParameters(i), strValues(i))
                'sqlPara = New SqlParameter(strValues(i).ToString(), strValues(i))
                'Thêm vào đối tượng SqlParameter vào đối tượng SqlCommand
                sqlCom.Parameters.Add(sqlPara)
            Next
            'Thực thi thủ tục hệ thống
            strResult = sqlCom.ExecuteScalar
        Catch ex As Exception
            'Nhận lỗi trả về
            strError = ex.Message
            MsgBox(" Thực thi dữ liệu " & vbNewLine _
                   & " Lỗi: " & vbNewLine & ex.Message, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub
End Class

