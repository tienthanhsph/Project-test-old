<%@ Page Title="" Language="C#" MasterPageFile="~/Excute.Master" AutoEventWireup="true" CodeBehind="XacNhanCapCoSo.aspx.cs" Inherits="DMCWeb.VanPhong.XuLyHoSo.XacNhanCapCoSo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="tieudeblogthongtin">THÔNG TIN XÁC NHẬN CẤP CƠ SỞ  (form này đang xem xét vị trí đặt khác cho hợp lý với quy trình.)</div>
                        <div class="nhapthongtin">
                            
                            <br />
                            <table  id="NhapThongTinXacNhan1"  runat="server" >
                                <tr>
                                    <td class="col-1">
                                        <asp:Label ID="Label17" runat="server" Text="Mã hồ sơ"></asp:Label>

                                    </td>
                                    <th class="col-2" colspan="4">
                                        <asp:Label ID="lblMaHoSoCS" runat="server" Text=""></asp:Label>
                                    </th>   
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="col-1">
                                        <asp:Label ID="Label18" runat="server" Text="Nội dung kê khai so với hiện tại"></asp:Label>

                                    </td>
                                    <th class="col-2" colspan="4">
                                        <asp:TextBox ID="txtNoiDungKeKhaiSoVoiHienTai" runat="server" Width="100%" TextMode="MultiLine" Height="100px"></asp:TextBox>
                                    </th>   
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="col-1">
                                        <asp:Label ID="Label19" runat="server" Text="Nguồn gốc sử dụng đất"></asp:Label>

                                    </td>
                                    <th class="col-2" colspan="4">
                                        <asp:TextBox ID="txtNguonGocSuDungDat" runat="server" Width="100%" TextMode="MultiLine" Height="80px"></asp:TextBox>
                                    </th>   
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="col-1">
                                        <asp:Label ID="Label29" runat="server" Text="Thời điểm sử dụng đất (theo đăng ký)"></asp:Label>

                                    </td>
                                    <th class="col-2" colspan="4">
                                        <asp:TextBox ID="txtThoiDiemSuDungDatVaoMucDichDangKy" runat="server" Width="150px"></asp:TextBox>
                                    </th>   
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="col-1">
                                        <asp:Label ID="Label30" runat="server" Text="Thời điểm tạo lập tài sản gắn liền với đất"></asp:Label>

                                    </td>
                                    <th class="col-2" colspan="4">
                                        <asp:TextBox ID="txtThoiDiemTaoLapTaiSanGanLienVoiDat" runat="server" Width="150px"></asp:TextBox>
                                    </th>   
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="col-1">
                                        <asp:Label ID="Label31" runat="server" Text="Tình trạng tranh chấp (Đất và tài sản)"></asp:Label>

                                    </td>
                                    <th class="col-2" colspan="4">
                                        <asp:TextBox ID="txtTinhTrangTranhChapDatDaiVaTaiSan" runat="server" Width="100%" TextMode="MultiLine" Height="70px"></asp:TextBox>
                                    </th>   
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="col-1">
                                        <asp:Label ID="Label32" runat="server" Text="Sự phù hợp với các quy hoạch"></asp:Label></td>
                                    <th class="col-2" colspan="4">
                                        <asp:TextBox ID="txtSuPhuHopVoiQuyHoachSuDungDatVaQuyHoachXayDung" runat="server" Width="100%" TextMode="MultiLine" Height="70px"></asp:TextBox>
                                    </th>   
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="col-1">
                                        <asp:Label ID="Label33" runat="server" Text="Nội dung khác"></asp:Label></td>
                                    <th class="col-2" colspan="4">
                                        <asp:TextBox ID="txtNoiDungKhac" runat="server" Width="100%" TextMode="MultiLine" Height="80px"></asp:TextBox>
                                    </th>   
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="col-1"> &nbsp; </td>
                                    <td class="col-2">&nbsp;</td>
                                    <td class="col-3">&nbsp;</td>
                                    <td class="col-4">&nbsp;</td>
                                    <td class="col-5">&nbsp;</td>
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                  <tr>
                                    <th class="col-1" colspan="2"> <asp:Label ID="Label42" runat="server" Text="XÁC NHẬN CỦA ĐỊA CHÍNH"></asp:Label></th>
                                    
                                    <td class="col-3">&nbsp;</td>
                                    <th class="col-4" colspan="2"><asp:Label ID="Label43" runat="server" Text="XÁC NHẬN CỦA UBND"></asp:Label></th>
                                   
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="col-1">
                                        <asp:Label ID="Label34" runat="server" Text="Ngày xác nhận"></asp:Label></td>
                                    <td class="col-2">
                                        <asp:TextBox ID="txtDiaChinh_NgayXacNhan" runat="server" Width="100%"></asp:TextBox></td>
                                    <td class="col-3">&nbsp;</td>
                                    <td class="col-4">
                                        <asp:Label ID="Label35" runat="server" Text="Ngày xác nhận"></asp:Label></td>
                                    <td class="col-5">
                                        <asp:TextBox ID="txtUBND_NgayXacNhan" runat="server" Width="100%"></asp:TextBox></td>
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                 <tr>
                                    <td class="col-1">
                                        <asp:Label ID="Label36" runat="server" Text="Tiêu đề ký"></asp:Label></td>
                                    <td class="col-2">
                                        <asp:TextBox ID="txtDiaChinh_TieuDeKy" runat="server" Width="100%"></asp:TextBox></td>
                                    <td class="col-3">&nbsp;</td>
                                    <td class="col-4">
                                        <asp:Label ID="Label37" runat="server" Text="Tiêu đề ký"></asp:Label></td>
                                    <td class="col-5">
                                        <asp:TextBox ID="txtUBND_TieuDeKy" runat="server" Width="100%"></asp:TextBox></td>
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                 <tr>
                                    <td class="col-1">
                                        <asp:Label ID="Label38" runat="server" Text="Người ký"></asp:Label></td>
                                    <td class="col-2">
                                        <asp:TextBox ID="txtDiaChinh_NguoiKy" runat="server" Width="100%"></asp:TextBox></td>
                                    <td class="col-3">&nbsp;</td>
                                    <td class="col-4">
                                        <asp:Label ID="Label39" runat="server" Text="Người ký"></asp:Label></td>
                                    <td class="col-5">
                                        <asp:TextBox ID="txtUBND_NguoiKy" runat="server" Width="100%"></asp:TextBox></td>
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                                 <tr>
                                    <td class="col-1">&nbsp;</td>
                                    <td class="col-2">&nbsp;</td>
                                    <td class="col-3">&nbsp;</td>
                                    <td class="col-4">&nbsp;</td>
                                    <td class="col-5">&nbsp;</td>
                                    <td class="col-6">&nbsp;</td>
                                </tr>
                               
                            </table>
                                         
                            <br/>                            
                            <div class="center" >
                            <asp:Button CssClass="btn btn-success" ID="btnLuuXacNhanCS" runat="server" Text="Lưu thông tin" OnClick="btnLuuXacNhanCS_Click"/>
                            <%--<asp:Button CssClass="btn btn-warning" ID="btnHuyXacNhanCS" runat="server" Text="Hủy" OnClick="btnHuyXacNhanCS_Click"/>--%>
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
