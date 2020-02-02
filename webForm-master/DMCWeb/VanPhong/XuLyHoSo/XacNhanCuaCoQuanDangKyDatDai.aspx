<%@ Page Title="" Language="C#" MasterPageFile="~/Excute.Master" AutoEventWireup="true" CodeBehind="XacNhanCuaCoQuanDangKyDatDai.aspx.cs" Inherits="DMCWeb.VanPhong.XuLyHoSo.XacNhanCuaCoQuanDangKyDatDai" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="tieudeblogthongtin">THÔNG TIN XÁC NHẬN CỦA CƠ QUAN ĐĂNG KÝ ĐẤT DAI  (form này đang xem xét vị trí đặt khác cho hợp lý với quy trình.)</div>

                        <div class="nhapthongtin">
                            
                            <br />
                            <table  id="NhapThongTinXacNhan2"  runat="server" >
                               
                                 <tr>
                                    <td class="left-3col">
                                        <asp:Label ID="Label1" runat="server" Text="Mã hồ sơ"></asp:Label>&nbsp;

                                    </td>
                                    <td class="mid-3col">
                                        <asp:Label ID="lblMaHoSo" runat="server" Text=""></asp:Label>

                                    </td>
                                    <td class="right-3col">&nbsp;</td>
                                    
                                </tr>
                                <tr>
                                    <td class="left-3col">
                                        <asp:Label ID="Label2" runat="server" Text="Ngày kiểm tra"></asp:Label>&nbsp;

                                    </td>
                                    <td class="mid-3col">
                                        <asp:TextBox ID="txtNgayKiemTra" runat="server"  Width="100px" TextMode="DateTime"></asp:TextBox>&nbsp;

                                    </td>
                                    <td class="right-3col">&nbsp;</td>
                                    
                                </tr>
                                <tr>
                                    <td class="left-3col">
                                        <asp:Label ID="Label3" runat="server" Text="Người kiểm tra"></asp:Label>&nbsp;

                                    </td>
                                    <td class="mid-3col">
                                        <asp:TextBox ID="txtNguoiKiemTra" runat="server" Width="100px"></asp:TextBox>&nbsp;

                                    </td>
                                    <td class="right-3col">&nbsp;</td>
                                    
                                </tr>
                                <tr>
                                    <td class="left-3col">
                                        <asp:Label ID="Label6" runat="server" Text="Chức vụ người kiểm tra"></asp:Label>&nbsp;

                                    </td>
                                    <td class="mid-3col">
                                        <asp:TextBox ID="txtChucVuNguoiKiemTra" runat="server" Width="100px"></asp:TextBox>&nbsp;

                                    </td>
                                    <td class="right-3col">&nbsp;</td>
                                    
                                </tr>
                                <tr>
                                    <td class="left-3col">
                                        <asp:Label ID="Label4" runat="server" Text="Nội dung ý kiến"></asp:Label>&nbsp;

                                    </td>
                                    <td class="mid-3col">
                                        <asp:TextBox ID="txtNoiDungYKien" runat="server" Width="100%" TextMode="MultiLine" Height="100px"></asp:TextBox>&nbsp;

                                    </td>
                                    <td class="right-3col">&nbsp;</td>
                                    
                                </tr>
                                <tr>
                                    <td class="left-3col">
                                        <asp:Label ID="Label5" runat="server" Text="Ghi chú"></asp:Label>&nbsp;

                                    </td>
                                    <td class="mid-3col">
                                        <asp:TextBox ID="txtGhiChu" runat="server" Width="100%" Height="80px" TextMode="MultiLine"></asp:TextBox>&nbsp;

                                    </td>
                                    <td class="right-3col">&nbsp;</td>
                                    
                                </tr>
                                <tr>
                                    <td class="left-3col">
                                        <asp:Label ID="Label7" runat="server" Text="Ngày ký"></asp:Label>&nbsp;

                                    </td>
                                    <td class="mid-3col">
                                        <asp:TextBox ID="txtNgayKy" runat="server" Width="100px" TextMode="DateTime"></asp:TextBox>&nbsp;

                                    </td>
                                    <td class="right-3col">&nbsp;</td>
                                    
                                </tr>

                                <tr>
                                    <td class="left-3col">
                                        <asp:Label ID="Label8" runat="server" Text="Giám đốc"></asp:Label>&nbsp;

                                    </td>
                                    <td class="mid-3col">
                                        <asp:TextBox ID="txtGiamDoc" runat="server" Width="100px"></asp:TextBox>&nbsp;

                                    </td>
                                    <td class="right-3col">&nbsp;</td>
                                    
                                </tr>
                               
                            </table>
                                         
                            <br/>                            
                            <div class="center">
                            <asp:Button CssClass="btn btn-success" ID="btnLuuCoQuanDangKyDatDai" runat="server" Text="Lưu thông tin" OnClick="btnLuuCoQuanDangKyDatDai_Click" />
                            <%--<asp:Button CssClass="btn btn-warning" ID="btnSuaCoQuanDangKyDatDai" runat="server" Text="Sửa" OnClick="btnSuaCoQuanDangKyDatDai_Click"/>--%>
                            </div>                                                        
                                                  
                            <br />
                        </div>
    <div class="center">
        <asp:Button CssClass="btn btn-lg btn-danger" ID="btnNext" runat="server" Text="Tiếp theo..." OnClick="btnNext_Click" />
    </div>
   <div >
        <asp:Button  CssClass="btn btn-lg btn-warning" ID="btnXuLyHoSo" runat="server" Text="Xem hồ sơ" OnClick="btnXemHoSo_Click" />
       
    </div>
</asp:Content>
