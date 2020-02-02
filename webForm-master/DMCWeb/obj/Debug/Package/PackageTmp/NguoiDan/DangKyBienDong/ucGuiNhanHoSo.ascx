<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucGuiNhanHoSo.ascx.cs" Inherits="DMCWeb.NguoiDan.DangKyBienDong.ucGuiNhanHoSo" %>
<div>
    <div class="tieude-xanh">THÔNG TIN GỬI/NHẬN HỒ SƠ ĐĂNG KÝ BIẾN ĐỘNG.</div>
    <div class="tieude-xanh">
        <asp:Label ID="lblTieuDeDon" runat="server" Text=""></asp:Label>
    </div>
    <div class="nhapthongtin">
    <div id="ThongTinGuiHoSo" runat="server">
    <div class="center">Thông tin gửi hồ sơ</div>
    <table runat="server" class="" >
        <tr>
            <td class="col-1">Tiêu đề đơn:</td>
            <th class="col-2" colspan="4">
                <asp:TextBox ID="txtTieuDeDon" runat="server" Width="100%"></asp:TextBox>
            </th>
            <td class="col-6"></td>
        </tr>
        <tr>
            <td class="col-1">Người viết đơn:</td>
            <td class="col-2">
                <asp:TextBox ID="txtNguoiViet" runat="server" Width="100%"></asp:TextBox>
            </td>
            <td class="col-3"></td>
            <td class="col-4">Ngày viết đơn:</td>
            <td class="col-5">
                <asp:TextBox ID="txtNgayViet" runat="server" Width="100%" TextMode="DateTime"></asp:TextBox>
            </td>
            <td class="col-6"></td>
        </tr>
    </table>
    </div>
    <br />
        <div id="ThongTinNhanHoSo" runat="server">
        <div class="center">Thông tin nhận hồ sơ</div>
        <table runat="server" class="" >
            <tr>
                <td class="col-1">Người nhận hồ sơ:</td>
                <td class="col-2">
                    <asp:TextBox ID="txtNguoiNhan" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td class="col-3"></td>
                <td class="col-4">Ngày nhận hồ sơ</td>
                <td class="col-5">
                    <asp:TextBox ID="txtNgayNhan" runat="server" Width="100%" TextMode="DateTime"></asp:TextBox>
                </td>
                <td class="col-6"></td>
            </tr>
            <tr>
                <td class="col-1">Số tiếp nhận:</td>
                <td class="col-2">
                    <asp:TextBox ID="txtSoTiepNhan" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td class="col-3"></td>
                <td class="col-4">Quyển:</td>
                <td class="col-5">
                    <asp:TextBox ID="txtQuyen" runat="server" Width="100%"></asp:TextBox>
                </td>
                <td class="col-6"></td>
            </tr>         
        </table>
        </div>
    </div>
    <div class="center">
        <asp:Button CssClass="btn btn-success" ID="btnLuu" runat="server" Text="Lưu thông tin." OnClick="btnLuu_Click" />
        <asp:Button CssClass="btn btn-warning" ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" />
        
    </div>
</div>