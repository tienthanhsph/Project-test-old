﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Excute.Master" AutoEventWireup="true" CodeBehind="TimKiemHoSo.aspx.cs" Inherits="DMCWeb.TimKiem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
        <div class="noibat2">
            <asp:Label ID="Label3" runat="server" Text="Đơn vị hành chính: "></asp:Label>
            <asp:DropDownList ID="drDonViHanhChinh" runat="server" DataSourceID="dtsDVHC" DataTextField="Ten" DataValueField="MaDonViHanhChinh" OnSelectedIndexChanged="drDonViHanhChinh_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:CheckBox ID="ChckDVHC" runat="server" Text="" OnCheckedChanged="ChckDVHC_CheckedChanged" AutoPostBack="True" />
            <asp:EntityDataSource ID="dtsDVHC" runat="server" ConnectionString="name=DMCWebEntities" DefaultContainerName="DMCWebEntities" EnableFlattening="False" EntitySetName="DVHCtams" Select="it.[MaDonViHanhChinh], it.[Ten]">
            </asp:EntityDataSource>
        </div>
        <br />
        <%--<div class="center">
            <div class="toLeft" style="width:30%;padding-left:0px; margin-left:0px;">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" BackColor="#FF9900" ForeColor="White" Height="30px" Width="200px">
                    <asp:ListItem Value="1">Tiếp nhận.</asp:ListItem>
                    <asp:ListItem Value="2">Xét duyệt cấp cơ sở.</asp:ListItem>
                    <asp:ListItem Value="3">Thẩm định.</asp:ListItem>
                    <asp:ListItem Value="4">Hoàn tất các bước.</asp:ListItem>
                    <asp:ListItem Value="5">Có sai sót!</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div class="toRight" style="width:70%;height:300px;background-color:red;"></div>
        </div>--%>
    
    
    <div class="ThongTinTimKiem">
       
        <table >
            <tr>
                <td class="col1">&nbsp;</td>
                <td class="col2">&nbsp;</td>
                <td class="col3">&nbsp;</td>
                <td class="col4">&nbsp;</td>
                <td class="col5">&nbsp;</td>
            </tr>
             <tr>
                <td class="col1"><asp:Label ID="Label1" runat="server" Text="Tên chủ: "></asp:Label></td>
                <th class="col2" colspan="4"><asp:TextBox ID="txtTen" runat="server"  Width="100%"></asp:TextBox></th>
                
            </tr>
             <tr>
                <td class="col1"><asp:Label ID="Label6" runat="server" Text="CMND: "></asp:Label></td>
                <th class="col2" colspan="3"><asp:TextBox ID="txtCMND" runat="server" Width="100%" AutoPostBack="True"></asp:TextBox></th>                
                <td class="col5">&nbsp;</td>
            </tr>
             <tr>
                 <td class="col1"><asp:Label ID="Label7" runat="server" Text="Địa chỉ: "></asp:Label></td>
                <th class="col2" colspan="4"><asp:TextBox ID="txtDiaChi" runat="server" Width="100%"></asp:TextBox></th>
            </tr>
             <tr>
                <td class="col1"><asp:Label ID="Label4" runat="server" Text="Số tờ: "></asp:Label></td>
                <td class="col2"><asp:TextBox ID="txtToBanDo" runat="server" Width="100%" AutoPostBack="True"></asp:TextBox></td>
                <td class="col3">&nbsp;</td>
                <td class="col4"><asp:Label ID="Label5" runat="server" Text="Số thửa: "></asp:Label></td>
                <td class="col5"><asp:TextBox ID="txtSoThua" runat="server" Width="100%" AutoPostBack="True"></asp:TextBox></td>
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
            <asp:Button CssClass="btn btn-lg btn-default" ID="btnTim" runat="server" Text="Tìm kiếm" OnClick="btnTim_Click" />
        </div>
    </div>
    
    <div class="center">
        <div class="grvTimKiem">
        <asp:GridView CssClass="center" ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="MaHS" DataNavigateUrlFormatString="~/VanPhong/XuLyHoSo/HoSo.aspx?MaHoSo={0}" DataTextField="MaHS" HeaderText="Hồ sơ" NavigateUrl="~/NguoiDan/DangKyCapGCN.aspx" />
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
    </div>
</asp:Content>
