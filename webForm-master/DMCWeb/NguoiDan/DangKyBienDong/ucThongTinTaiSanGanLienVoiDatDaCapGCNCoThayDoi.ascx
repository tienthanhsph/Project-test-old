<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucThongTinTaiSanGanLienVoiDatDaCapGCNCoThayDoi.ascx.cs" Inherits="DMCWeb.NguoiDan.DangKyBienDong.ucThongTinTaiSanGanLienVoiDatDaCapGCNCoThayDoi" %>
<div>
 <%--   <table style="width: 100%;" runat="server">
        <tr>
            <td>Loại tài sản</td>
            <td style="width:60%">Nội dung thay đổi khác</td>
        </tr>
       <tr>
           
            <td>
                <asp:TextBox ID="txtLoaiTaiSan" runat="server"></asp:TextBox>
            </td>
            <td style="width:60%">
                 <asp:TextBox ID="txtNoiDungThayDoi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th colspan="4">
                <asp:Button CssClass="btn btn-sm btn-success" ID="btnThemTaiSan" runat="server" Text="Thêm" OnClick="btnThemTaiSan_Click" />
            </th>            
        </tr>
    </table>--%>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" OnRowDeleting="GridView1_RowDeleting" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="LoaiTaiSan" HeaderText="Loại tài sản" />
            <asp:BoundField DataField="NoiDungThayDoi" HeaderText="Nội dung thay đổi" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="Chọn..." CommandArgument='<%# Eval("ID") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" Visible="False" />
        </Columns>
    </asp:GridView>
    <br>
    <div class="center">
        <asp:Button CssClass="btn btn-sm btn-success" ID="btnThemTaiSan" runat="server" Text="Thêm" OnClick="btnThemTaiSan_Click" />
    </div>
    
    <br />
    <table style="width: 100%;" runat="server" class="table"  id="CapNhatThongTinTaiSanThayDoiDoBienDong">
        <tr>
            <td>5.1. Thông tin trên GCN đã cấp: </td>
            <td>5.2. Thông tin có thay đổi:</td>
        </tr>
        <tr>
            <td>Loại tài sản:
                <asp:TextBox ID="txtLoaiTaiSan1" runat="server"></asp:TextBox>
            </td>
            <td>Loại tài sản:
                <asp:TextBox ID="txtLoaiTaiSan2" runat="server"></asp:TextBox>
            </td>
        </tr>
        
         <tr>
            <td>Diện tích XD <i>(Chiếm đất)</i>:
                <asp:TextBox ID="txtDienTich1" runat="server"></asp:TextBox>
            </td>
            <td>Diện tích XD <i>(Chiếm đất)</i>:
                <asp:TextBox ID="txtDienTich2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtNoiDungKhac1" runat="server" Height="100px" TextMode="MultiLine" Width="100%"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtNoiDungKhac2" runat="server" Height="100px" TextMode="MultiLine" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th colspan="2">
                <asp:Button CssClass="btn btn-sm btn-success" ID="btnLuuThongTin" runat="server" Text="Lưu" OnClick="btnLuuThongTin_Click" />
                 <asp:Button CssClass="btn btn-sm btn-warning" ID="btnHuy" runat="server" Text="Hủy" OnClick="btnHuy_Click"/>
            </th>
        </tr>
    </table>
</div>