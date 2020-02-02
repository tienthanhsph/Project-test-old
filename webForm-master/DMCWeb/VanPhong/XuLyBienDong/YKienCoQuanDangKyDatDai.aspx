<%@ Page Title="" Language="C#" MasterPageFile="~/Excute.Master" AutoEventWireup="true" CodeBehind="YKienCoQuanDangKyDatDai.aspx.cs" Inherits="DMCWeb.VanPhong.XuLyBienDong.YKienCoQuanDangKyDatDai" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  <div>
        <div class="tieude">
            Ý KIẾN CỦA CƠ QUAN ĐĂNG KÝ ĐẤT ĐAI.
        </div>
        <div class="noidungdon">
            <div class="nhapthongtin">
                <table runat="server" class="nhapthongtin">
                <tr>
                    <td class="col-1">Nội dung ý kiến:</td>
                    <th class="col-2" colspan="4">
                        <asp:TextBox ID="txtNoiDungYKien" runat="server" Width="100%" TextMode="MultiLine" Height="400px"></asp:TextBox>
                    </th>
                    <td class="col-6"></td>
                </tr>
                   <tr>
                    <td class="col-1">Ghi chú:</td>
                    <th class="col-2" colspan="4">
                        <asp:TextBox ID="txtGhiChu" runat="server" Width="100%" TextMode="MultiLine" Height="200px"></asp:TextBox>
                    </th>
                    <td class="col-6"></td>
                </tr> 
                    <tr>
                    <th class="col-1" colspan="2" style="text-align:center;">
                        NGƯỜI KIỂM TRA

                    </th>
                    
                    <td class="col-3">
                       
                    </td>
                    <th class="col-4" colspan="2" style="text-align:center;">
                        GIÁM ĐỐC
                    </th>
                    
                    <td class="col-6"></td>
                </tr>
                    <tr>
                    <td class="col-1">Ngày ký</td>
                    <td class="col-2">
                        <asp:TextBox ID="txtNguoiKiemTra_NgayKy" runat="server"></asp:TextBox>
                    </td>
                    <td class="col-3"></td>
                    <td class="col-4">Ngày ký</td>
                    <td class="col-5">
                        <asp:TextBox ID="txtGiamDoc_NgayKy" runat="server"></asp:TextBox>
                    </td>
                    <td class="col-6"></td>
                </tr>
                   
                    <tr>
                    <td class="col-1">Người ký</td>
                    <td class="col-2">
                        <asp:TextBox ID="txtNguoiKiemTra" runat="server"></asp:TextBox>
                    </td>
                    <td class="col-3"></td>
                    <td class="col-4">Người ký</td>
                    <td class="col-5">
                        <asp:TextBox ID="txtGiamDoc" runat="server"></asp:TextBox>
                    </td>
                    <td class="col-6"></td>
                </tr>
            </table>

                <div class="center">
                     <asp:Button CssClass="btn btn-lg btn-success" ID="btnXemHoSo" runat="server" Text="Hồ sơ." OnClick="btnXemHoSo_Click" />
                    <asp:Button CssClass="btn btn-lg btn-danger" ID="btnLuuYKien" runat="server" Text="Lưu ý kiến." OnClick="btnLuuYKien_Click" />
                </div>
            </div>
        </div>
    </div>


</asp:Content>
