<%@ Page Title="" Language="C#" MasterPageFile="~/Excute.Master" AutoEventWireup="true" CodeBehind="HoSo.aspx.cs" Inherits="DMCWeb.VanPhong.XuLyHoSo.HoSo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <div class="tieude"><h3><asp:Label ID="lblMaHoSo" runat="server" Text=""></asp:Label></h3></div>
    
    <asp:Button CssClass="btn btn-lg btn-danger" ID="btnSuaHoSo" runat="server" Text="Cập nhật hồ sơ..." OnClick="btnSuaHoSo_Click"/>
        <asp:Button CssClass="btn btn-lg btn-danger" ID="btnXetDuyetCapCoSo" runat="server" Text="Cấp cơ sở" OnClick="btnXetDuyetCapCoSo_Click"/>
        <asp:Button CssClass="btn btn-lg btn-danger" ID="btnXacNhanCoQuanDangKyDatDai" runat="server" Text="Cơ quan đăng ký đất đai" OnClick="btnXacNhanCoQuanDangKyDatDai_Click"/>

    <section>
        <div class ="muc">Thông tin hồ sơ</div>
        <div class="noidung">
            <table class="hienthithongtin" aria-invalid="grammar">
                <tr>
                    <td class="col1">Tiêu đề đơn:</td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblTieuDeDon" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
                <tr>
                    <td class="col1">Người viết đơn:</td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblNguoiVietDon" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
                <tr>
                    <td class="col1">Điện thoại:</td>
                    <td class="col2">
                        <asp:Label ID="lblDienThoai" runat="server" Text="Label"></asp:Label></td>
                    <td class="col3"></td>
                    <td class="col4">Email</td>
                    <td class="col5">
                        <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <td class="col1">Đề nghị: </td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblDeNghi" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
                <tr>
                    <td class="col1">Đề nghị khác: </td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblDeNghiKhac" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <td class="col1">Nghĩa vụ TC: </td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblNghiaVuTaiChinh" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
                <tr>
                    <td class="col1">Ngày nhận HS: </td>
                    <td class="col2">
                        <asp:Label ID="lblNgayNhanHoSo" runat="server" Text="Label"></asp:Label></td>
                    <td class="col3"></td>
                    <td class="col4">Người nhận HS: </td>
                    <td class="col5">
                        <asp:Label ID="lblNguoiNhanHoSo" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <td class="col1">Số vào sổ</td>
                    <td class="col2">
                        <asp:Label ID="lblSoVaoSo" runat="server" Text="Label"></asp:Label></td>
                    <td class="col3"></td>
                    <td class="col4">Quyển: </td>
                    <td class="col5">
                        <asp:Label ID="lblQuyen" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <td class="col1">Giấy tờ kèm theo: </td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblGiayToKemTheo" runat="server" Text="Label"></asp:Label></td>
                </tr>
                
            </table>
        </div>
    </section>
<br />
    <section>
        <div class ="muc">Chủ</div>
        <div class="noidung">
           <asp:GridView CssClass="grvThongTinDaNhap" ID="grvChu" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="MaChu">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="Mã chủ" DataField="MaChu" Visible="False" />
                    <asp:BoundField DataField="DanhXung" />
                    <asp:BoundField HeaderText="Họ tên" DataField="HoTen" />
                    <asp:BoundField HeaderText="Năm sinh" DataField="NamSinh" />
                    <asp:BoundField HeaderText="Địa chỉ" DataField="DiaChi" />
                    <asp:BoundField HeaderText="Định danh" DataField="DinhDanh" Visible="False" />
                    <asp:BoundField HeaderText="CMND" DataField="SoDinhDanh" />
                    <asp:BoundField HeaderText="Ngày cấp" DataField="NgayCap" Visible="False" />
                    <asp:BoundField HeaderText="Nơi cấp" DataField="NoiCap" Visible="False" />
                    <asp:BoundField HeaderText="Quốc tịch" DataField="QuocTich" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </div>
    </section>
<br />
    <section>
        <div class ="muc">Thửa đất</div>
        <div class="noidung">
            <asp:GridView CssClass="grvThongTinDaNhap" ID="grvThuaDat" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" CaptionAlign="Top">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="MaThuaDat" HeaderText="Mã thửa đất" Visible="False" />
                    <asp:BoundField DataField="MaHoSo" HeaderText="Mã hồ sơ" Visible="False" />
                    <asp:BoundField DataField="ToBanDo" HeaderText="Số Tờ" />
                    <asp:BoundField DataField="SoThua" HeaderText="Số Thửa" />
                    <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
                    <asp:BoundField DataField="DienTich" HeaderText="Diện tích" />
                    <asp:BoundField DataField="SuDungChung" HeaderText="Chung" />
                    <asp:BoundField DataField="SuDungRieng" HeaderText="Riêng" />
                    <asp:BoundField DataField="MucDichSuDung" HeaderText="Mục đích" />
                    <asp:BoundField DataField="ThoiHanSuDung" HeaderText="Thời hạn" />
                    <asp:BoundField DataField="NgayBatDauSuDung" HeaderText="SD từ ngày" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="LoaiNguonGocSuDung" HeaderText="Nguồn gốc" />
                    <asp:CheckBoxField DataField="CoHanCheSuDung" HeaderText="Hạn chế" />
                    <asp:BoundField DataField="NoiDungHanCheSuDung" HeaderText="Hạn chế" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>        
        </div>
    </section>
<br />
    <section>
        <div class ="muc">Nhà ở - công trình</div>
        <div class="noidung">
            <asp:GridView CssClass="grvThongTinDaNhap" ID="grvNhaO" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" CaptionAlign="Top">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="MaNhaO" HeaderText="Mã Số" Visible="False" />
                    <asp:BoundField DataField="MaHoSo" HeaderText="Mã hồ sơ" Visible="False" />
                    <asp:BoundField DataField="LoaiNhaO" HeaderText="Loại nhà ở" />
                    <asp:BoundField DataField="DienTichXayDung" HeaderText="Diện tích xây dựng" />
                    <asp:BoundField DataField="DienTichSan" HeaderText="Diện tích sàn" />
                    <asp:BoundField DataField="SoHuuChung" HeaderText="Sở hữu chung" />
                    <asp:BoundField DataField="SoHuuRieng" HeaderText="Sở hữu riêng" />
                    <asp:BoundField DataField="KetCau" HeaderText="Kết cấu" />
                    <asp:BoundField DataField="SoTang" HeaderText="Số tầng" />
                    <asp:BoundField DataField="CoHanCheThoiHanSoHuu" HeaderText="Hạn chế thời hạn" />
                    <asp:BoundField DataField="ThoiHanSoHuu" HeaderText="Thời hạn" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>      
        </div>
    </section>
<br />
    <section>
        <div class ="muc">Rừng cây </div>
        <div class="noidung">

        </div>
    </section>
<br />
    <section>
        <div class ="muc">Rừng cây</div>
        <div class="noidung">

        </div>

    </section>
<br />
    <section>
        <div class ="muc">Xét duyệt cấp cơ sở</div>
        <div class="noidung">
            <table class="hienthithongtin" aria-invalid="grammar">
                <tr>
                    <td class="col1">Hiện Trạng:</td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblNoiDungKeKhaiSoVoiHienTai" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
                <tr>
                    <td class="col1">Nguồn gốc:</td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblNguonGoc" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
                <tr>
                    <td class="col1">Thời điểm sử dụng đất:</td>
                    <td class="col2">
                        <asp:Label ID="lblThoiDiemSuDungDat" runat="server" Text="Label"></asp:Label></td>
                    <td class="col3"></td>
                    <td class="col4">Thời điểm tạo tài sản:</td>
                    <td class="col5">
                        <asp:Label ID="lblThoiDiemTaoTaiSan" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <td class="col1">Tranh chấp:</td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblTinhTrangTranhChap" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
                <tr>
                    <td class="col1">Sự phù hợp với quy hoạch:</td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblPhuHopQuyHoach" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
                 <tr>
                    <td class="col1">Nội dung khác:</td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblNoiDungKhac" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
                
                <tr>
                    <th class="col1" colspan="2">XÁC NHẬN ĐỊA CHÍNH:</th>
                    
                       
                    <td class="col3"></td>
                    <th class="col4"colspan="2">XÁC NHẬN UBND:</th>
                    
                </tr>
                <tr>
                    <td class="col1" style="text-align:center"><asp:Label ID="lblDiaChinhNgay" runat="server" Text="Label"></asp:Label></td>
                    <td class="col2">
                        </td>
                    <td class="col3"></td>
                    <td class="col4" style="text-align:center"><asp:Label ID="lblUBNDNgay" runat="server" Text="Label"></asp:Label></td>
                    <td class="col5">
                        </td>
                </tr>
                 <tr>
                    <td class="col1" style="text-align:center"> <asp:Label ID="lblDiaChinhTieuDe" runat="server" Text="Label"></asp:Label></td>
                    <td class="col2">
                       </td>
                    <td class="col3"></td>
                    <td class="col4" style="text-align:center"><asp:Label ID="lblUBNDTieuDe" runat="server" Text="Label"></asp:Label></td>
                    <td class="col5">
                        </td>
                </tr>
                 <tr>
                    <td class="col1" style="text-align:center"><asp:Label ID="lblDiaChinhNguoi" runat="server" Text="Label"></asp:Label></td>
                    <td class="col2">
                        </td>
                    <td class="col3"></td>
                    <td class="col4" style="text-align:center"><asp:Label ID="lblUBNDNguoi" runat="server" Text="Label"></asp:Label></td>
                    <td class="col5">
                        </td>
                </tr>
            </table>
        </div>
    </section>

<br />
    <section>
        <div class ="muc">Xác nhận của cơ quan đăng ký đất đai</div>
        <div class="noidung">
            <table class="hienthithongtin" aria-invalid="grammar">
                <tr>
                    <td class="col1">Ngày kiểm tra:</td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblNgayKiemTra" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
               
                <tr>
                    <td class="col1">Người kiểm tra:</td>
                    <td class="col2">
                        <asp:Label ID="lblNguoiKiemTra" runat="server" Text="Label"></asp:Label></td>
                    <td class="col3"></td>
                    <td class="col4">Chức vụ:</td>
                    <td class="col5">
                        <asp:Label ID="lblChucVuNguoiKiemTra" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <td class="col1">Nội dung ý kiến:</td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblNoiDungYKien" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
                <tr>
                    <td class="col1">Ghi chú:</td>
                    <td class="col2" colspan="4">
                        <asp:Label ID="lblGhiChuYKien" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
                 
                <tr>
                    <td class="col1"></td>
                    <td class="col2"></td>
                       
                    <td class="col3"></td>
                    <td class="col4">Ngày ký:</td>
                    <td class="col5">
                        <asp:Label ID="lblNgayKyVPDK" runat="server" Text="Label"></asp:Label></td>
                </tr>
                 <tr>
                    <td class="col1"></td>
                    <td class="col2">
                       </td>
                    <td class="col3"></td>
                    <td class="col4">Giám đốc:</td>
                    <td class="col5">
                        <asp:Label ID="lblGiamDocVPDK" runat="server" Text="Label"></asp:Label></td>
                </tr>
                
            </table>
        </div>
    </section>

    </div>
</asp:Content>
