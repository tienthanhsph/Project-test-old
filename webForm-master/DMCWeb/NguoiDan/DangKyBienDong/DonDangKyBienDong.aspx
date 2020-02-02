<%@ Page Title="" Language="C#" MasterPageFile="~/Basic.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="DonDangKyBienDong.aspx.cs" Inherits="DMCWeb.NguoiDan.DangKyBienDong.DonDangKyBienDong" %>

<%@ Register Src="~/NguoiDan/DangKyBienDong/ucGuiNhanHoSo.ascx" TagPrefix="uc1" TagName="ucGuiNhanHoSo" %>
<%@ Register Src="~/NguoiDan/DangKyBienDong/ucNhapThongTinChu.ascx" TagPrefix="uc1" TagName="ucNhapThongTinChu" %>
<%@ Register Src="~/NguoiDan/DangKyBienDong/ucDangKyBienDongDatDat_TaiSan.ascx" TagPrefix="uc1" TagName="ucDangKyBienDongDatDat_TaiSan" %>
<%@ Register Src="~/NguoiDan/DangKyBienDong/ucDeNghiCapLai.ascx" TagPrefix="uc1" TagName="ucDeNghiCapLai" %>
<%@ Register Src="~/NguoiDan/DangKyBienDong/ucDeNghiTachThua_HopThua.ascx" TagPrefix="uc1" TagName="ucDeNghiTachThua_HopThua" %>







<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="TaoHoSo">
        <asp:Button CssClass="btn btn-lg btn-danger" ID="btnTaoHoSoDangKyBienDong" runat="server" Text="Đăng ký biến động mới." OnClick="btnTaoHoSoDangKyBienDong_Click" />
        <asp:Button CssClass="btn btn-lg btn-default" ID="btnSuaDonDangKyBienDong" runat="server" Text="Sửa đơn." OnClick="btnSuaDonDangKyBienDong_Click" />


        <div class="noibat2" style="float:right; padding-top:13px;">
            <asp:Label ID="Label3" runat="server" Text="Đơn vị hành chính: "></asp:Label>
            <asp:DropDownList ID="drDonViHanhChinh" runat="server" DataSourceID="dtsDVHC" DataTextField="Ten" DataValueField="MaDonViHanhChinh" OnSelectedIndexChanged="drDonViHanhChinh_SelectedIndexChanged" AutoPostBack="True" ></asp:DropDownList>
            <asp:CheckBox ID="ChckDVHC" runat="server" Text="" OnCheckedChanged="ChckDVHC_CheckedChanged" AutoPostBack="True" />
            <asp:EntityDataSource ID="dtsDVHC" runat="server" ConnectionString="name=DMCWebEntities" DefaultContainerName="DMCWebEntities" EnableFlattening="False" EntitySetName="DVHCtams" Select="it.[MaDonViHanhChinh], it.[Ten]">
            </asp:EntityDataSource>
        </div>
    </div>
    <br />
    <div id="ChucNangXuLyHoSoCapTren" runat="server" >
        <asp:Button CssClass="btn btn-success" ID="btnXacNhanCapCoSo" runat="server" Text="Xác nhận cấp cơ sở." OnClick="btnXacNhanCapCoSo_Click" />
        <asp:Button CssClass="btn btn-warning" ID="btnCoQuanDangKyDatDai" runat="server" Text="Cơ quan ĐKĐĐ." OnClick="btnCoQuanDangKyDatDai_Click" />
        <asp:Button CssClass="btn btn-danger" ID="btnCoQuanTaiNguyenMoiTruong" runat="server" Text="Cơ quan TN&MT" OnClick="btnCoQuanTaiNguyenMoiTruong_Click" />
    </div>
    <div id="ThongTinBienDong" runat="server">       
        <div id="LoaiBienDong">
        <div class="center" id="ChonLoaiBienDong">
            <%--<div class="noibat1" >
                <asp:Label ID="Label1" runat="server" Text="Chọn loại biến động đăng ký: "></asp:Label>
            </div>--%>
            <div>
                <asp:DropDownList ID="drLoaiBienDong" runat="server" Font-Bold="True" ForeColor="Red" Height="40px" BackColor="#FFCC66" AutoPostBack="True" OnSelectedIndexChanged="drLoaiBienDong_SelectedIndexChanged" Width="100%">
                    <asp:ListItem Value="0">-- Chọn loại biến động --</asp:ListItem>
                    <asp:ListItem Value="1">ĐĂNG KÝ BIẾN ĐỘNG ĐẤT ĐAI, TÀI SẢN GẮN LIỀN VỚI ĐẤT.</asp:ListItem>
                    <asp:ListItem Value="2">ĐỀ NGHỊ CẤP LẠI, CẤP ĐỔI GIẤY CHỨNG NHẬN QUYỀN SỬ DỤNG ĐẤT, QUYỀN SỞ HỮU NHÀ Ở VÀ TÀI SẢN GẮN LIỀN VỚI ĐẤT.</asp:ListItem>
                    <asp:ListItem Value="3">ĐỀ NGHỊ TÁCH THỬA, HỢP THỬA ĐẤT.</asp:ListItem>
                </asp:DropDownList>
            </div>
            
            <div>
                <asp:CheckBox ID="chckDaChonLoaiBienDong" runat="server" Text="Đồng ý chọn!" ForeColor="Red" OnCheckedChanged="chckDaChonLoaiBienDong_CheckedChanged" AutoPostBack="True" />
            </div>

        </div>

        </div>
        <br /><br />
        <uc1:ucGuiNhanHoSo runat="server" ID="ucGuiNhanHoSo" />   
        <br />
        <br />
        <uc1:ucNhapThongTinChu runat="server" id="ucNhapThongTinChu" />
        <br />
     
        <div id="3Loai">
           <div class="tieude-xanh">
               <asp:Label ID="Label2" runat="server" Text="THÔNG TIN BIẾN ĐỘNG"></asp:Label>

           </div>
                <uc1:ucDangKyBienDongDatDat_TaiSan runat="server" id="ucDangKyBienDongDatDat_TaiSan" />
            
                <uc1:ucDeNghiCapLai runat="server" id="ucDeNghiCapLai" />
            
                <uc1:ucDeNghiTachThua_HopThua runat="server" id="ucDeNghiTachThua_HopThua" />
           
        </div>
    </div>
    <br /> <br />
    <div class="center">
        <asp:Button CssClass="btn btn-lg btn-primary btn-block" ID="btnGuiHoSoBienDong" runat="server" Text="Gửi hồ sơ..." OnClick="btnGuiHoSoBienDong_Click" />
    </div>
    <br />
    <div  runat="server" id="QuyenCanBo" >

        <div id="ThongTinNhanHoSo" runat="server" class="center">
        <div class="tieude-xanh">Thông tin nhận hồ sơ</div>
        <table runat="server" class="table-bordered" style="text-align:center; margin:auto; margin-top:10px;">
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
    <br />
    <div class="center">
        <asp:Button CssClass="btn btn-lg btn-danger" ID="btnXoaHoSo" runat="server" Text="Xóa hồ sơ" OnClick="btnXoaHoSo_Click"/>&nbsp;&nbsp;&nbsp;
        <asp:Button CssClass="btn btn-lg btn-warning" ID="btnChapNhanHoSo" runat="server" Text="Chấp nhận hồ sơ!" OnClick="btnChapNhanHoSo_Click" />        
    </div>
        <div style="clear:both;"></div>
        </div>
</asp:Content>
