<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucDeNghiTachThua_HopThua.ascx.cs" Inherits="DMCWeb.NguoiDan.DangKyBienDong.ucDeNghiTachThua_HopThua" %>
<%@ Register Src="~/NguoiDan/DangKyBienDong/Tach_HopThua.ascx" TagPrefix="uc1" TagName="Tach_HopThua" %>


<div>
    <div class="nhapthongtin">
        <table style="width: 100%;" class="table-condensed" runat="server">
            
            <tr>
               <th colspan="2"><b>Đề nghị tách, hợp thửa đất như sau:</b></th>
            </tr>
            <tr>
               <th colspan="2">
                   <uc1:Tach_HopThua runat="server" id="Tach_HopThua" />
               </th>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
               <th colspan="2"><b>Lý do tách, hợp thửa:</b></th>
            </tr>
            <tr>
               <th colspan="2">
                   <asp:TextBox ID="txtLyDoTachHopThua" runat="server" Width="100%" TextMode="MultiLine" Height="200px"></asp:TextBox>
               </th>
            </tr>
            
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
           <tr>
               <th colspan="2"><b>Giấy tờ nộp kèm theo đơn này gồm có:</b></th>
            </tr>
            <tr>
               <th colspan="2">
                   <asp:TextBox ID="txtGiayToLienQuan" runat="server" TextMode="MultiLine" Height="150px" Width="100%" Text=" - Giấy chứng nhận về quyền sử dụng đất của thửa đất trên; \n - Sơ đồ dự kiến phân chia các thửa đất trong trường hợp tách thửa (nếu có): "></asp:TextBox>
               </th>
            </tr>
        </table>
         <div class="center">
            <asp:Button CssClass="btn btn-success" ID="btnLuuThongTinKeKhai" runat="server" Text="Lưu lại." OnClick="btnLuuThongTinKeKhai_Click" />
             <asp:Button CssClass="btn btn-success" ID="btnSuaThongTinKeKhai" runat="server" Text="Sửa." OnClick="btnSuaThongTinKeKhai_Click" />
              
        </div>
    </div>
</div>