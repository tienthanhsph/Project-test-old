<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucDangKyBienDongDatDat_TaiSan.ascx.cs" Inherits="DMCWeb.NguoiDan.DangKyBienDong.ucDangKyBienDongDatDat_TaiSan" %>
<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
<div>

    <div class="center" style="color:red;"></div>
    <div class="nhapthongtin">
        <table style="width: 100%;" class="table-condensed" runat="server">
            
            <tr>
               <th colspan="2"><b>Giấy chứng nhận đã cấp</b></th>
            </tr>
            <tr>
                <td>
                    Số vào sổ cấp GCN:
                    <asp:TextBox ID="txtSoVaoSoCapGCN" runat="server"></asp:TextBox>
                </td>
                <td>
                    Số phát hành GCN:
                    <asp:TextBox ID="txtSoPhatHanhGCN" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>               
                <td >
                    Ngày cấp GCN:
                    <asp:TextBox ID="txtNgayCapGCN" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
         
            <tr>
               <th colspan="2"><b>Nội dung biến động về:</b></th>
            </tr>
            <tr>
                <th colspan="2">
                    <asp:TextBox ID="txtNoiDungBienDongVe" runat="server" Width="100%"></asp:TextBox>

                </th>
                
                    
            </tr>
            <tr>
                <td>1. Nội dung trên GCN trước khi biến động:</td>
                <td>2. Nội dung sau khi biến động:</td>
                    
            </tr>
            <tr>
                <td style="width:50%"> 
                    <asp:TextBox ID="txtNoiDungTrenGCNTruocBD" runat="server" Width="100%" TextMode="MultiLine" Height="250px"></asp:TextBox>

                </td>
                <td>
                    <asp:TextBox ID="txtNoiDungSauBD" runat="server" Width="100%" TextMode="MultiLine"  Height="250px"></asp:TextBox>

                </td>
                    
            </tr>
              <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
               <th colspan="2">
                   <b>Lý do biến động:</b>
               </th>
            </tr> 
             <tr>
                <th colspan="2">
                    <asp:TextBox ID="txtLyDoBienDong" runat="server" TextMode="MultiLine" Height="150px" Width="100%"></asp:TextBox>
                </th>
            </tr> 

            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
               <th colspan="2"><b>Tình hình thực hiện nghĩa vụ tài chính về đất đai đối với thửa đất đăng ký biến động:</b></th>
            </tr>
            <tr>
               <th colspan="2">
                   <asp:TextBox ID="txtTinhHinhThucHienNghiaVuTaiChinh" runat="server" TextMode="MultiLine" Height="150px" Width="100%"></asp:TextBox>
               </th>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
               <th colspan="2"><b>Giấy tờ liên quan đến nội dung thay đổi nộp kèm theo đơn này gồm có:</b></th>
            </tr>
            <tr>
               <th colspan="2">
                   <asp:TextBox ID="txtGiayToLienQuan" runat="server" TextMode="MultiLine" Height="150px" Width="100%" Text=" - Giấy chứng nhận đã cấp:"></asp:TextBox>
               </th>
            </tr>
        </table>
	

        <div class="center">
            <asp:Button CssClass="btn btn-success" ID="btnLuuThongTinKeKhai" runat="server" Text="Lưu lại." OnClick="btnLuuThongTinKeKhai_Click" />
            <asp:Button CssClass="btn btn-success" ID="btnSuaThongTinKeKhai" runat="server" Text="Sửa." OnClick="btnSuaThongTinKeKhai_Click"  />
        </div>
    </div>






</div>