<%@ Page Title="" Language="C#" MasterPageFile="~/Excute.Master" AutoEventWireup="true" CodeBehind="BaoCaoHoSoBienDongMoi.aspx.cs" Inherits="DMCWeb.VanPhong.TiepNhanDon.BaoCaoHoSoBienDongMoi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="TimKiemDangKyBienDong" runat="server">
         <div class="noibat2">
            <asp:Label ID="Label3" runat="server" Text="Đơn vị hành chính: "></asp:Label>
            <asp:DropDownList ID="drDonViHanhChinh" runat="server" DataSourceID="dtsDVHC" DataTextField="Ten" DataValueField="MaDonViHanhChinh" AutoPostBack="True" OnSelectedIndexChanged="drDonViHanhChinh_SelectedIndexChanged"></asp:DropDownList>
       <asp:CheckBox ID="ChckDVHC" runat="server" Text="" OnCheckedChanged="ChckDVHC_CheckedChanged" AutoPostBack="True" />
            <asp:EntityDataSource ID="dtsDVHC" runat="server" ConnectionString="name=DMCWebEntities" DefaultContainerName="DMCWebEntities" EnableFlattening="False" EntitySetName="DVHCtams" Select="it.[MaDonViHanhChinh], it.[Ten]">
            </asp:EntityDataSource>
    </div>
    <div class="center">
        <asp:Label CssClass="tieude" ID="lblThongBao" runat="server" Text="Hồ sơ đăng ký đang chờ duyệt"></asp:Label>
    </div>
        <div class="ThongTinTimKiem">
       <br />
            <asp:Label ID="Label8" runat="server" Text="Loại biến động:"></asp:Label>
               
                    <asp:DropDownList ID="drLoaiBienDong" runat="server" ForeColor="Red" >
                    <asp:ListItem Value="0">-- Chọn dưới đây --</asp:ListItem>
                    <asp:ListItem Value="1">ĐĂNG KÝ BIẾN ĐỘNG ĐẤT ĐAI, TÀI SẢN GẮN LIỀN VỚI ĐẤT.</asp:ListItem>
                    <asp:ListItem Value="2">ĐỀ NGHỊ CẤP LẠI, CẤP ĐỔI GIẤY CHỨNG NHẬN QUYỀN SỬ DỤNG ĐẤT, QUYỀN SỞ HỮU NHÀ Ở VÀ TÀI SẢN GẮN LIỀN VỚI ĐẤT.</asp:ListItem>
                    <asp:ListItem Value="3">ĐỀ NGHỊ TÁCH THỬA, HỢP THỬA ĐẤT.</asp:ListItem>
                    </asp:DropDownList>
                
        <table >
            <tr>
                <td class="col1">&nbsp;</td>
                <td class="col2">&nbsp;</td>
                <td class="col3">&nbsp;</td>
                <td class="col4">&nbsp;</td>
                <td class="col5">&nbsp;</td>
            </tr>
             <tr>
                <td class="col1"><asp:Label ID="Label2" runat="server" Text="Người viết đơn: "></asp:Label></td>
                <th class="col2" colspan="4"><asp:TextBox ID="txtNguoiVietDon" runat="server"  Width="100%"></asp:TextBox></th>
                
            </tr>
             
             <tr>
                 <td class="col1"><asp:Label ID="Label9" runat="server" Text="Số phát hành GCN: "></asp:Label></td>
                <th class="col2" colspan="4"><asp:TextBox ID="txtSoPhatHanhGCN" runat="server" Width="100%"></asp:TextBox></th>
            </tr>
             <tr>
                <td class="col1"><asp:Label ID="Label10" runat="server" Text="Số vào sổ cấp GCN: "></asp:Label></td>
                <td class="col2"><asp:TextBox ID="txtSoVaoSoCapGCN" runat="server" Width="100%"></asp:TextBox></td>
                <td class="col3">&nbsp;</td>
                <td class="col4"><asp:Label ID="Label11" runat="server" Text="Ngày cấp GCN: "></asp:Label></td>
                <td class="col5"><asp:TextBox ID="txtNgayCapGCN" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
             <tr>
                <td class="col1">&nbsp;</td>
                <td class="col2">&nbsp;</td>
                <td class="col3">&nbsp;</td>
                <td class="col4">&nbsp;</td>
                <td class="col5">&nbsp;</td>
            </tr>
            
            
        </table>

        <div class="center"> 
            <asp:Button CssClass="btn btn-lg btn-default" ID="btnTimKiemBienDong" runat="server" Text="Tìm kiếm" OnClick="btnTimKiemBienDong_Click" />
        </div>
    </div>
    
        <div class="center">
        <div class="grvTimKiem">
        <asp:GridView CssClass="center" ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="MaDangKyBienDong" DataTextField="MaDangKyBienDong" HeaderText="Biến động" DataNavigateUrlFormatString="~/NguoiDan/DangKyBienDong/DonDangKyBienDong.aspx?DangKyBienDong={0}&QuyenChapNhan=true" />
                <asp:BoundField DataField="NguoiVietDon" HeaderText="Người đăng ký" />
                <asp:BoundField DataField="LoaiBienDong" HeaderText="Loại biến động" />
                <asp:BoundField DataField="SoPhatHanhGCN" HeaderText="Số phát hành GCN" />
                <asp:BoundField DataField="SoVaoSoCapGCN" HeaderText="Số vào sổ cấp GCN" />
                <asp:BoundField DataField="NgayCapGCN" HeaderText="Ngày cấp GCN" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />

        </asp:GridView>
        </div>
    </div>
        </div>
</asp:Content>
