Imports Microsoft.Office.Interop

Public Class frmChinhLyBienDong
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
        Dim txtClnSoVaoSo As New DataGridViewTextBoxColumn
        Dim txtClnSeriGCN As New DataGridViewTextBoxColumn
        Dim txtClnSoThua As New DataGridViewTextBoxColumn
        Dim txtClnToBanDo As New DataGridViewTextBoxColumn
        Dim txtClnDienTich As New DataGridViewTextBoxColumn
        Dim txtClnTenNguoiSuDung As New DataGridViewTextBoxColumn
        Dim txtClnSoVaoSo2 As New DataGridViewTextBoxColumn
        Dim txtClnSeriGCN2 As New DataGridViewTextBoxColumn
        Dim txtClnSoThua2 As New DataGridViewTextBoxColumn
        Dim txtClnToBanDo2 As New DataGridViewTextBoxColumn
        Dim txtClnDienTich2 As New DataGridViewTextBoxColumn
        Dim txtClnTenNguoiSuDung2 As New DataGridViewTextBoxColumn
        Dim txtClnMaHoSoTTHC As New DataGridViewTextBoxColumn
        Try
            With txtClnSTT
                .HeaderText = "STT"
                .Name = "STT"
                .Width = 50
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            With txtClnSoVaoSo
                .HeaderText = "Số vào sổ"
                .Name = "SoVaoSoCapGCN"
                .Width = 100
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            With txtClnSeriGCN
                .HeaderText = "Seri GCN"
                .Name = "SeriGCN"
                .Width = 70
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            End With
            With txtClnSoThua
                .HeaderText = "Thửa đất số"
                .Name = "SoThua"
                .Width = 80
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With txtClnToBanDo
                .HeaderText = "Tờ bản đồ số"
                .Name = "ToBanDo"
                .Width = 80
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With txtClnDienTich
                .HeaderText = "Diện tích"
                .Name = "DienTich"
                .Width = 80
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With txtClnTenNguoiSuDung
                .HeaderText = "Tên người sử dụng đất"
                .Name = "HoTenTimKiem"
                .Visible = True
                .Width = 200
            End With

            With txtClnSoVaoSo2
                .HeaderText = "Số vào sổ"
                .Name = "SoVaoSoCapGCN2"
                .Width = 100
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            With txtClnSeriGCN2
                .HeaderText = "Seri GCN"
                .Name = "SeriGCN2"
                .Width = 70
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            'Tờ bản đồ
            With txtClnSoThua2
                .HeaderText = "Thửa đất số"
                .Name = "SoThua2"
                .Width = 80
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            'Số hiệu thửa
            With txtClnToBanDo2
                .HeaderText = "Tờ bản đồ số"
                .Name = "ToBanDo2"
                .Width = 80
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            'Dien tich thửa đất
            With txtClnDienTich2
                .HeaderText = "Diện tích"
                .Name = "DienTich2"
                .Width = 80
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With txtClnTenNguoiSuDung2
                .HeaderText = "Tên người sử dụng đất"
                .Name = "HoTenChuChuyenNhuongTimKiem"
                .Width = 200
                .Visible = True
            End With

            With txtClnMaHoSoTTHC
                .HeaderText = "Mã hồ sơ TTHC"
                .Name = "MaHoSoTTHC"
                .Width = 50
                .Visible = True
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            End With
            With Me.grdThongTin
                .BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                .RowHeadersVisible = False
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                'Add Columns
                With .Columns
                    .Add(txtClnSTT)
                    .Add(txtClnSoVaoSo)
                    .Add(txtClnSeriGCN)
                    .Add(txtClnSoThua)
                    .Add(txtClnToBanDo)
                    .Add(txtClnDienTich)
                    .Add(txtClnTenNguoiSuDung)
                    .Add(txtClnSoVaoSo2)
                    .Add(txtClnSeriGCN2)
                    .Add(txtClnSoThua2)
                    .Add(txtClnToBanDo2)
                    .Add(txtClnDienTich2)
                    .Add(txtClnTenNguoiSuDung2)
                    .Add(txtClnMaHoSoTTHC)



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
            Dim TienThanh As String = ""

            For i As Integer = 0 To dtTimKiem.Rows.Count - 1
                With Me.grdThongTin
                    .RowCount += 1
                    TienThanh += dtTimKiem.Rows(i).Item("HoTenTimKiem").ToString
                    .Item("STT", i).Value = dtTimKiem.Rows(i).Item("STT").ToString
                    .Item("SoVaoSoCapGCN", i).Value = dtTimKiem.Rows(i).Item("SoVaoSo").ToString
                    .Item("SeriGCN", i).Value = dtTimKiem.Rows(i).Item("SeriGCN").ToString
                    .Item("SoThua", i).Value = dtTimKiem.Rows(i).Item("SoThua").ToString
                    .Item("ToBanDo", i).Value = dtTimKiem.Rows(i).Item("ToBanDo").ToString
                    .Item("DienTich", i).Value = dtTimKiem.Rows(i).Item("DienTich").ToString
                    '.Item("HoTenTimKiem", i).Value = TongHopChu(dtTimKiem.Rows(i).Item("MaHoSoCapGCN").ToString)
                    .Item("HoTenTimKiem", i).Value = dtTimKiem.Rows(i).Item("HoTenTimKiem").ToString
                    .Item("SoVaoSoCapGCN2", i).Value = dtTimKiem.Rows(i).Item("SoVaoSo2").ToString
                    .Item("SeriGCN2", i).Value = dtTimKiem.Rows(i).Item("SeriGCN2").ToString
                    .Item("SoThua2", i).Value = dtTimKiem.Rows(i).Item("SoThua2").ToString
                    .Item("ToBanDo2", i).Value = dtTimKiem.Rows(i).Item("ToBanDo2").ToString
                    .Item("DienTich2", i).Value = dtTimKiem.Rows(i).Item("DienTich2").ToString
                    '.Item("HoTenChuSuDungTimKiem", i).Value = TongHopChuChuyenNhuong(dtTimKiem.Rows(i).Item("MaHoSoCapGCN").ToString)
                    .Item("HoTenChuChuyenNhuongTimKiem", i).Value = dtTimKiem.Rows(i).Item("HoTenChuChuyenNhuongTimKiem").ToString
                    .Item("MaHoSoTTHC", i).Value = dtTimKiem.Rows(i).Item("MaHoSoTTHC").ToString
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
            With .grdThongTin
                .RowCount = 1
                .ClearSelection()
            End With
        End With

        With TimKiem
            'Gán chuỗi kết nối Database cho clsTimKiem
            .Connection = strConnection
            .MaDonViHanhChinh = MaDonViHanhChinh
            .TuNgay = DateTimePicker1.Text
            .DenNgay = DateTimePicker2.Text
            .SoQuyetDinh = TextBox1.Text.Trim()

        End With
        Try
            If TimKiem.SelectChinhLyBienDong(dtTimKiem) = "" Then
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
        DateTimePicker1.Text = "10/10/2014"
        AddColumnsTimKiem()
        MaDonViHanhChinh = "100640"
    End Sub

    Private Sub cmdThongKe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThongKe.Click
        ShowData()
    End Sub

    Private Sub cmdXuatExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXuatExcel.Click
        Dim strFileNameTmp As String
        Dim strFileNameKetQua As String
        Dim pathSourcetmp As String = ""

        pathSourcetmp = System.Windows.Forms.Application.StartupPath & "\ChinhLyBienDongDatDai"
        If Not System.IO.Directory.Exists(pathSourcetmp) Then
            System.IO.Directory.CreateDirectory(pathSourcetmp)
        End If

        strFileNameTmp = System.Windows.Forms.Application.StartupPath & "\TmpExcel\ChinhLyBienDongDatDai.xls"
        strFileNameKetQua = pathSourcetmp & "\ChinhLyBienDongDatDai_TuNgay" & Replace(DateTimePicker1.Text.Trim, "/", "_") & "_DenNgay_" & Replace(DateTimePicker2.Text.Trim, "/", "_") & ".xls"

        Try
            If grdThongTin.RowCount > 0 Then
                Dim excel As New Excel.ApplicationClass
                excel.StandardFontSize = 11
                Dim wBook As Excel.Workbook
                Dim wSheet As Excel.Worksheet

                wBook = excel.Workbooks.Open(strFileNameTmp)
                wSheet = wBook.ActiveSheet()
                wSheet.Cells(4, 2) = "Thanh Trì, Ngày " & Now.Day.ToString() & " tháng " & Now.Month.ToString & " năm " & Now.Year.ToString
                wSheet.Cells(4, 10) = "Số : " & "Số quyết định"
                wSheet.Cells(7, 5) = "UBND THỊ TRẤN VĂN ĐIỂN"
                'For j = 0 To grdThongTin.ColumnCount - 1
                '    If grdThongTin.Columns(j).Visible Then
                '        wSheet.Cells(7, j + 1) = grdThongTin.Columns(j).HeaderText.ToString
                '        Dim range As Microsoft.Office.Interop.Excel.Range
                '        range = wSheet.Cells(7, j + 1)
                '        range.VerticalAlignment = 3
                '        range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                '    End If
                'Next
                For i = 0 To grdThongTin.RowCount - 2
                    For j = 0 To grdThongTin.ColumnCount - 1
                        If grdThongTin.Columns(j).Visible Then
                            If Not System.Convert.IsDBNull(grdThongTin(j, i).Value) Then
                                wSheet.Cells(i + 11, j + 1) = grdThongTin(j, i).Value.ToString()
                            Else
                                wSheet.Cells(i + 11, j + 1) = ""
                            End If
                            Dim range As Microsoft.Office.Interop.Excel.Range

                            range = wSheet.Cells(i + 11, j + 1)
                            range.VerticalAlignment = 3
                            range.Font.Name = "Arial"
                            range.Font.Size = 11
                            range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                        End If
                    Next
                Next
                wSheet.Columns.AutoFit()

                wBook.SaveAs(strFileNameKetQua)
                excel.Visible = True
                wBook = Nothing
                wBook = Nothing
                wSheet = Nothing
            End If
        Catch ex As Exception
            MessageBox .Show (ex.Message)
        End Try

    End Sub

End Class