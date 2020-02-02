Imports System.Data.SqlClient
Public Class Form1
    Private strError As String = ""
    Dim sqlCon As SqlConnection


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With TextBox1
            .Text = "100640"
        End With
        TestConnect()
    End Sub
    Private Function TestConnect()
        Dim strconn As String = "Data Source=DMC-PC\SQL2005;Initial Catalog=georgetown_ThanhTri ;User ID=sa ;PassWord=dmc3star;"

        Dim boolSuccessfully As Boolean = False
        Try
            'Truyền chuỗi kết nối cơ sở dữ liệu
            sqlCon = New SqlConnection(strconn)
            'Mở kết nối cơ sở dữ liệu
            sqlCon.Open()
            strError = ""
            boolSuccessfully = True
            'If (boolSuccessfully = True) Then
            '    MessageBox.Show("Ket Noi Thanh Cong")
            'End If
        Catch eq As SqlException
            strError = eq.Message
            MsgBox(" Lỗi: " & vbNewLine & eq.Message, MsgBoxStyle.Information, "Lỗi kết nối dữ liệu")
        Catch ex As Exception
            strError = ex.Message
            MsgBox(" Lỗi: " & vbNewLine & ex.Message, MsgBoxStyle.Information, "Lỗi kết nối dữ liệu")
        End Try
        Return boolSuccessfully

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmChinhLyBienDong
        With frm
            .Connection = "Data Source=DMC-PC\SQL2005;Initial Catalog=georgetown_ThanhTri ;User ID=sa ;PassWord=dmc3star;"
            .MaDonViHanhChinh = TextBox1.Text.Trim()

            ' .ShowData()
        End With
        frm.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frm As New frmHoSoChuyenQuyen
        With frm
            .Connection = "Data Source=DMC-PC\SQL2005;Initial Catalog=georgetown_ThanhTri ;User ID=sa ;PassWord=dmc3star;"
            .MaDonViHanhChinh = TextBox1.Text.Trim()

            ' .ShowData()
        End With
        frm.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim frm As New frmThongKeHoSoNhap
        With frm
            .Connection = "Data Source=DMC-PC\SQL2005;Initial Catalog=georgetown_ThanhTri ;User ID=sa ;PassWord=dmc3star;"
            .MaDonViHanhChinh = TextBox1.Text.Trim()

            .ShowData()
        End With
        frm.Show()
    End Sub
End Class
