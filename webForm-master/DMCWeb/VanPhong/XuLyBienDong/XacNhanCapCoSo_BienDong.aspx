<%@ Page Title="" Language="C#" MasterPageFile="~/Excute.Master" AutoEventWireup="true" CodeBehind="XacNhanCapCoSo_BienDong.aspx.cs" Inherits="DMCWeb.VanPhong.XuLyBienDong.XacNhanCapCoSo_BienDong" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <div class="tieude">
            XÁC NHẬN CẤP CƠ SỞ.
        </div>
        <div class="noidungdon">
            <div class="nhapthongtin">
                <table runat="server" class="nhapthongtin">
                <tr>
                    <td class="col-1">Nội dung xác nhận:</td>
                    <th class="col-2" colspan="4">
                        <asp:TextBox ID="txtNoiDungXacNhan" runat="server" Width="100%" TextMode="MultiLine" Height="200px"></asp:TextBox>
                    </th>
                    <td class="col-6"></td>
                </tr>
                    <tr>
                    <td class="col-1">Nội dung khác:</td>
                    <th class="col-2" colspan="4">
                        <asp:TextBox ID="txtNoiDungKhac" runat="server" Width="100%" TextMode="MultiLine" Height="150px"></asp:TextBox>
                    </th>
                    <td class="col-6"></td>
                </tr>
                    <tr>
                    <th class="col-1" colspan="2" style="text-align:center;">
                        ĐỊA CHÍNH

                    </th>
                    
                    <td class="col-3">
                        
                    </td>
                    <th class="col-4" colspan="2" style="text-align:center;">
                        UBND
                    </th>
                   
                    <td class="col-6"></td>
                </tr>
                    <tr>
                    <td class="col-1">Ngày ký</td>
                    <td class="col-2">
                        <asp:TextBox ID="txtDiaChinh_NgayKy" runat="server"></asp:TextBox>
                    </td>
                    <td class="col-3"></td>
                    <td class="col-4">Ngày ký</td>
                    <td class="col-5">
                        <asp:TextBox ID="txtUBND_NgayKy" runat="server"></asp:TextBox>
                    </td>
                    <td class="col-6"></td>
                </tr>
                    <tr>
                    <td class="col-1">Tiêu đề ký</td>
                    <td class="col-2">
                        <asp:TextBox ID="txtDiaChinh_TieuDeKy" runat="server"></asp:TextBox>
                    </td>
                    <td class="col-3"></td>
                    <td class="col-4">Tiêu đề ký</td>
                    <td class="col-5">
                        <asp:TextBox ID="txtUBND_TieuDeKy" runat="server"></asp:TextBox>
                    </td>
                    <td class="col-6"></td>
                </tr>
                    <tr>
                    <td class="col-1">Người ký</td>
                    <td class="col-2">
                        <asp:TextBox ID="txtDiaChinh_NguoiKy" runat="server"></asp:TextBox>
                    </td>
                    <td class="col-3"></td>
                    <td class="col-4">Người ký</td>
                    <td class="col-5">
                        <asp:TextBox ID="txtUBND_NguoiKy" runat="server"></asp:TextBox>
                    </td>
                    <td class="col-6"></td>
                </tr>
            </table>

                <div class="center">
                    <asp:Button CssClass="btn btn-lg btn-success" ID="btnXemHoSo" runat="server" Text="Hồ sơ." OnClick="btnXemHoSo_Click" />
                    <asp:Button CssClass="btn btn-lg btn-danger" ID="btnXacNhan" runat="server" Text="Xác nhận." OnClick="btnLuuXacNhanCS_Click" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
