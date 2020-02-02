Imports Microsoft.Office.Interop
Public Class frmHoSoChuyenQuyen
    Private strConnection As String = ""
    Public Property Connection() As String
        Get
            Return strConnection
        End Get
        Set(ByVal value As String)
            strConnection = value
        End Set
    End Property

  
    Private strMaDonViHanhChinh As String
    Public Property MaDonViHanhChinh() As String
        Get
            Return strMaDonViHanhChinh
        End Get
        Set(ByVal value As String)
            strMaDonViHanhChinh = value
        End Set
    End Property
    Private strError As String = ""

    Private strMaHoSoCapGCN As String = ""


    Public Sub AddColumnsTimKiem()
        Dim txtClnSTT As New DataGridViewTextBoxColumn
        Dim txtClnBenChuyenQuyen As New DataGridViewTextBoxColumn
        Dim txtClnBenNhanChuyenQuyen As New DataGridViewTextBoxColumn
        Dim txtClnToBanDo As New DataGridViewTextBoxColumn
        Dim txtClnSoThua As New DataGridViewTextBoxColumn
        Dim txtClnDienTichChuyenDich As New DataGridViewTextBoxColumn
        Dim txtClnTongGiaTriGiaoDich As New DataGridViewTextBoxColumn
        Dim txtClnThoiDiemGiaoDich As New DataGridViewTextBoxColumn
        Dim txtClnGhiChu As New DataGridViewTextBoxColumn
       
        Try
            With txtClnSTT
                .HeaderText = "STT"
                .Name = "STT"
                .Width = 50
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            With txtClnBenChuyenQuyen
                .HeaderText = "Bên chuyển quyền"
                .Name = "BenChuyenQuyen"
                .Width = 200
                .Visible = True
            End With
            With txtClnBenNhanChuyenQuyen
                .HeaderText = "Bên nhận chuyển quyền"
                .Name = "BenNhanChuyenQuyen"
                .Width = 200
                .Visible = True
            End With
            'Tờ bản đồ
            With txtClnToBanDo
                .HeaderText = "Tờ bản đồ"
                .Name = "ToBanDo"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            'Số hiệu thửa
            With txtClnSoThua
                .HeaderText = "Số Thửa"
                .Name = "SoThua"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            End With
            'Dien tich thửa đất
            With txtClnDienTichChuyenDich
                .HeaderText = "Diện tích chuyển dịch"
                .Name = "DienTichChuyenDich"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With txtClnTongGiaTriGiaoDich
                .HeaderText = "Tổng giá trị giao dịch"
                .Name = "TongGiaTriGiaoDich"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With txtClnThoiDiemGiaoDich
                .HeaderText = "Thời điểm giao dịch"
                .Name = "ThoiDiemGiaoDich"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With txtClnGhiChu
                .HeaderText = "Ghi chú"
                .Name = "GhiChu"
                .Width = 250
            End With
            
            With Me.dtgrv
                .BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                .RowHeadersVisible = False
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                'Add Columns
                With .Columns
                    .Add(txtClnSTT)
                    .Add(txtClnBenChuyenQuyen)
                    .Add(txtClnBenNhanChuyenQuyen)
                    .Add(txtClnToBanDo)
                    .Add(txtClnSoThua)
                    .Add(txtClnDienTichChuyenDich)
                    .Add(txtClnTongGiaTriGiaoDich)
                    .Add(txtClnThoiDiemGiaoDich)
                    .Add(txtClnGhiChu)
                    

                End With
                'Không cho phép thêm
                .AllowUserToAddRows = False
                'Không cho phép xóa
                .AllowUserToDeleteRows = False
                'Không lựa chọn bất kỳ dòng nào
                .ClearSelection()
            End With
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Tìm kiếm" + vbNewLine + " Lỗi: " & vbNewLine & strError, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub

    Public Sub LoadGrid(ByVal dtTimKiem As DataTable)
        If dtTimKiem.Rows.Count > 0 Then
            For i As Integer = 0 To dtTimKiem.Rows.Count - 1
                With Me.dtgrv
                    .RowCount += 1
                    .Item("STT", i).Value = dtTimKiem.Rows(i).Item("STT").ToString
                    .Item("ToBanDo", i).Value = dtTimKiem.Rows(i).Item("ToBanDo").ToString
                    .Item("SoThua", i).Value = dtTimKiem.Rows(i).Item("SoThua").ToString
                    .Item("DienTichChuyenDich", i).Value = dtTimKiem.Rows(i).Item("DienTichChuyenQuyen").ToString
                    .Item("BenChuyenQuyen", i).Value = dtTimKiem.Rows(i).Item("BenChuyenQuyen").ToString
                    .Item("BenNhanChuyenQuyen", i).Value = dtTimKiem.Rows(i).Item("BenNhanChuyenQuyen").ToString
                    .Item("TongGiaTriGiaoDich", i).Value = dtTimKiem.Rows(i).Item("TongGiaTriGiaoDich").ToString
                    .Item("ThoiDiemGiaoDich", i).Value = dtTimKiem.Rows(i).Item("ThoiDiemGiaoDich").ToString
                    .Item("GhiChu", i).Value = dtTimKiem.Rows(i).Item("GhiChu").ToString
                   
                End With
            Next i
        End If
    End Sub

    Public Function TongHopChu(ByVal strMaHoSoCapGCN As String) As String
        Dim strTongHop As String = ""
        Dim TimKiem As New clsHoSoCapGCN
        Dim dt As New DataTable

        With TimKiem
            'Gán chuỗi kết nối Database cho clsTimKiem
            .Connection = strConnection
            'Mã đơn vị hành chính
            .MaHoSoCapGCN = strMaHoSoCapGCN
        End With
        Try
            'Goi phuong thuc GetData de khoi tao doi tuong clsTimKiem
            If TimKiem.SelectTongHopChu(dt) = "" Then
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        strTongHop = strTongHop & dt.Rows(i).Item("QuanHe") & ": " & dt.Rows(i).Item("HoTen") & ", "
                    Next
                    strTongHop = strTongHop.Substring(0, strTongHop.Length - 2)
                End If
            End If
        Catch ex As Exception
            strError = ex.Message
            MsgBox(vbNewLine & "Lỗi: " & vbNewLine + ex.Message, MsgBoxStyle.Information, "DMCLand")
        End Try
        Return strTongHop
    End Function

    Public Function MaLoaiBienDong(ByVal MaHoSo As String) As String
        Dim dt As New DataTable
        Dim strMaLoaiBD As String = ""
        Dim cls As New clsHoSoCapGCN
        cls.Connection = strConnection
        cls.MaHoSoCapGCN = MaHoSo
        If cls.SelectLoaiBienDong(dt) = "" Then
            If dt.Rows.Count > 0 Then
                strMaLoaiBD = dt.Rows(0).Item("MaLoaiBienDong").ToString.Trim
            End If
        End If
        Return strMaLoaiBD
    End Function

    Public Function TongHopChuChuyenNhuong(ByVal strMaHoSoCapGCN As String) As String


        Dim strTongHop As String = ""
        Dim TimKiem As New clsHoSoCapGCN
        Dim dt As New DataTable

        With TimKiem
            'Gán chuỗi kết nối Database cho clsTimKiem
            .Connection = strConnection
            'Mã đơn vị hành chính
            .MaHoSoCapGCN = strMaHoSoCapGCN
        End With
        Try
            'Goi phuong thuc GetData de khoi tao doi tuong clsTimKiem
            If TimKiem.SelectTongHopChuChuyenNhuong(dt) = "" Then
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        strTongHop = strTongHop & dt.Rows(i).Item(0) & ", "
                    Next
                    strTongHop = strTongHop.Substring(0, strTongHop.Length - 2)
                End If
            End If
        Catch ex As Exception
            strError = ex.Message
            MsgBox(vbNewLine & "Lỗi: " & vbNewLine + ex.Message, MsgBoxStyle.Information, "DMCLand")
        End Try
        Return strTongHop
    End Function
    Public Function ToiUuXau(ByVal str As String) As String
        str = str.Replace("[", "[[]")
        str = str.Replace("%", "[%]")
        str = str.Replace("'", "''")
        Return str
    End Function

    Public Sub ShowData()
        Dim dtTimKiem As New DataTable
        Dim TimKiem As New clsHoSoCapGCN
        dtTimKiem = New DataTable
        With Me
            'Lam sach du lieu
            dtTimKiem.Clear()
            strMaHoSoCapGCN = ""
            With .dtgrv
                .RowCount = 1
                .ClearSelection()
            End With
        End With

        With TimKiem
            'Gán chuỗi kết nối Database cho clsTimKiem
            .Connection = strConnection
            .Thang = ComboBox2.Text
            .Nam = TextBox1.Text
            .MaDonViHanhChinh = MaDonViHanhChinh

        End With
        Try
            If TimKiem.SelectHoSoBySoChuyenQuyen(dtTimKiem) = "" Then
                'Kiểm tra tính hợp lệ của dữ liệu
                If dtTimKiem Is Nothing Then
                    Return
                End If
                If dtTimKiem.Rows.Count > 0 Then
                    'Trình bày dữ liệu lên Form
                    LoadGrid(dtTimKiem)
                End If
            End If
        Catch ex As Exception
            strError = ex.Message
            MsgBox(vbNewLine & "Lỗi: " & vbNewLine + ex.Message, MsgBoxStyle.Information, "DMCLand")
        End Try
    End Sub
    Private Sub frmThongKeHoSoNhap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ShowData()
        MaDonViHanhChinh = "100640"
        AddColumnsTimKiem()
        TextBox1.Text = "2015"
        ComboBox2.Text = "1"
        Label6.Text += "GlobalTenDonViHanhChinhHienThoi"

    End Sub

    Private Sub cmdThongKe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThongKe.Click
        ShowData()
    End Sub

    Private Sub cmdXuatExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXuatExcel.Click
        Dim strFileNameTmp As String
        Dim strFileNameKetQua As String
        Dim pathSourcetmp As String = ""

        pathSourcetmp = System.Windows.Forms.Application.StartupPath & "\HoSoChuyenQuyen"
        If Not System.IO.Directory.Exists(pathSourcetmp) Then
            System.IO.Directory.CreateDirectory(pathSourcetmp)
        End If
        Dim filename As String = ""
        filename = "\HoSoChuyenQuyen Thang_ " & ComboBox2.Text.Trim() & "_Nam_" & TextBox1.Text.Trim() & ".xls"

        strFileNameTmp = System.Windows.Forms.Application.StartupPath & "\TmpExcel\HoSoChuyenQuyen.xls"  'thay doi thu muc'
        strFileNameKetQua = pathSourcetmp & filename


        If dtgrv.RowCount > 0 Then
            Dim excel As New Excel.ApplicationClass
            Dim wBook As Excel.Workbook
            Dim wSheet As Excel.Worksheet

            wBook = excel.Workbooks.Open(strFileNameTmp)
            wSheet = wBook.ActiveSheet()

            wSheet.Cells(2, 6) = "HỒ SƠ CHUYỂN QUYỀN XÃ globalTenDonViHanhChinhHienThoi "
            wSheet.Cells(3, 7) = "Tháng  " & ComboBox2.Text
            wSheet.Cells(3, 8) = "Năm  " & TextBox1.Text
            '& Now.Day.ToString() & " tháng " & Now.Month.ToString & " năm " & Now.Year.ToString
            Try

                'For j = 0 To dtgrv.ColumnCount - 2
                '    If dtgrv.Columns(j).Visible Then
                '        wSheet.Cells(6, j + 1) = dtgrv.Columns(j).HeaderText.ToString
                '        Dim range As Microsoft.Office.Interop.Excel.Range
                '        range = wSheet.Cells(6, j + 1)
                '        range.VerticalAlignment = 3
                '        range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                '    End If
                'Next
                For i = 0 To dtgrv.RowCount - 2
                    For j = 0 To dtgrv.ColumnCount - 1
                        If dtgrv.Columns(j).Visible Then
                            If Not System.Convert.IsDBNull(dtgrv(j, i).Value) Then
                                wSheet.Cells(i + 7, j + 1) = dtgrv(j, i).Value.ToString()
                            Else
                                wSheet.Cells(i + 7, j + 1) = ""
                            End If
                            Dim range As Microsoft.Office.Interop.Excel.Range
                            range = wSheet.Cells(i + 7, j + 1)
                            range.VerticalAlignment = 3
                            range.Font.Name = "Arial"
                            range.Font.Size = 11
                            range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                        End If
                    Next
                Next
                wSheet.Columns.AutoFit()
           

                wBook.SaveAs(strFileNameKetQua)
            Catch ex As Exception
                MessageBox.Show("LAM VIEC VOI FILE EXEL BI LOI: " & ex.Message)
            End Try
            excel.Visible = True
            wBook = Nothing
            wBook = Nothing
            wSheet = Nothing
        End If
    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Text = ""
    End Sub
End Class