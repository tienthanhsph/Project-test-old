<%@ Page Title="" Language="C#" MasterPageFile="~/Basic.Master" AutoEventWireup="true" CodeBehind="TimKiemHoSoDuBi_SearchTab.aspx.cs" Inherits="DMCWeb.NguoiDan.TimKiemHoSoDuBi_SearchTab" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
        <div class="center">
            <div class="noibat2">Hồ sơ đăng ký cấp GCN</div>
            <div class="grvTimKiem">
            <asp:GridView CssClass="center" ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="MaHS" DataNavigateUrlFormatString="~/NguoiDan/DangKyCapGCN.aspx?MaHoSo={0}" DataTextField="MaHS" HeaderText="Hồ sơ" NavigateUrl="~/NguoiDan/DangKyCapGCN.aspx" />
                    <asp:BoundField DataField="TenChu" HeaderText="Chủ" />
                    <asp:BoundField DataField="ToBD" HeaderText="Tờ bản đồ" />
                    <asp:BoundField DataField="ST" HeaderText="Số thửa" />
                    <asp:BoundField DataField="DT" HeaderText="Diện tích" />
                    <asp:BoundField DataField="DC" HeaderText="Địa chỉ đất" />
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
            <hr />
            <div class="noibat2">Hồ sơ đăng ký biến động.</div>


            <div class="grvTimKiem">
            <asp:GridView CssClass="center" ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="MaDangKyBienDong" DataTextField="MaDangKyBienDong" HeaderText="Biến động" DataNavigateUrlFormatString="~/NguoiDan/DangKyBienDong/DonDangKyBienDong.aspx?DangKyBienDong={0}" />
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
   
</asp:Content>
