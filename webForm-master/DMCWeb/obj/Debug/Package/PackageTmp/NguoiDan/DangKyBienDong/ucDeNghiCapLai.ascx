<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucDeNghiCapLai.ascx.cs" Inherits="DMCWeb.NguoiDan.DangKyBienDong.ucDeNghiCapLai" %>
<%@ Register Src="~/NguoiDan/DangKyBienDong/ucThongTinThuaDatCoThayDoiDoDoDacLai.ascx" TagPrefix="uc1" TagName="ucThongTinThuaDatCoThayDoiDoDoDacLai" %>
<%@ Register Src="~/NguoiDan/DangKyBienDong/ucThongTinTaiSanGanLienVoiDatDaCapGCNCoThayDoi.ascx" TagPrefix="uc1" TagName="ucThongTinTaiSanGanLienVoiDatDaCapGCNCoThayDoi" %>


<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
<div>
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
               <th colspan="2">
                   <b>Lý do đề nghị cấp lại, cấp đổi Giấy chứng nhận:</b>
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
                <th colspan="2">
                    <b>Thông tin thửa đất có thay đổi do đo đạc lại</b><i>(Kê khai theo bản đồ địa chính mới)</i>
                </th>
            </tr>
            <tr>
                <th colspan="2">
                    <uc1:ucThongTinThuaDatCoThayDoiDoDoDacLai runat="server" id="ucThongTinThuaDatCoThayDoiDoDoDacLai" />
                </th>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <th colspan="2">
                    <b>Thông tin tài sản gắn liền với đất đã cấp GCN có thay đổi</b><i>(Kê khai theo thông tin đã thay đổi - nếu có)</i>
                </th>
            </tr>
            <tr>
                <th colspan="2">
                    <uc1:ucThongTinTaiSanGanLienVoiDatDaCapGCNCoThayDoi runat="server" id="ucThongTinTaiSanGanLienVoiDatDaCapGCNCoThayDoi" />
                </th>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
           <tr>
               <th colspan="2"><b>Những Giấy tờ liên quan đến nội dung thay đổi nộp kèm theo:</b></th>
            </tr>
            <tr>
               <th colspan="2">
                   <asp:TextBox ID="txtGiayToLienQuan" runat="server" TextMode="MultiLine" Height="150px" Width="100%" Text=" - Giấy chứng nhận đã cấp:"></asp:TextBox>
               </th>
            </tr>

        </table>
         <div class="center">
            <asp:Button CssClass="btn btn-success" ID="btnLuuThongTinKeKhai" runat="server" Text="Lưu lại." OnClick="btnLuuThongTinKeKhai_Click" />
             <asp:Button CssClass="btn btn-success" ID="btnSuaThongTinKeKhai" runat="server" Text="Sửa." OnClick="btnSuaThongTinKeKhai_Click" />
        </div>
    </div>
</div>