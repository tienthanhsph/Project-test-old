<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TimKiemNguoi.aspx.cs" Inherits="DMCWeb.TienIch.TimKiemNguoi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="tieude">Tìm kiếm thông tin người có sẵn trong hệ thống</div>
        <div class="noidungdon">
            <div class="noibat2">
            <asp:Label ID="Label3" runat="server" Text="Đơn vị hành chính: "></asp:Label>
            <asp:DropDownList ID="drDonViHanhChinh" runat="server" DataSourceID="dtsDVHC" DataTextField="Ten" DataValueField="MaDonViHanhChinh" OnSelectedIndexChanged="drDonViHanhChinh_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:CheckBox ID="ChckDVHC" runat="server" Text="" OnCheckedChanged="ChckDVHC_CheckedChanged" AutoPostBack="True" />
            <asp:EntityDataSource ID="dtsDVHC" runat="server" ConnectionString="name=DMCWebEntities" DefaultContainerName="DMCWebEntities" EnableFlattening="False" EntitySetName="DVHCtams" Select="it.[MaDonViHanhChinh], it.[Ten]">
            </asp:EntityDataSource>
        </div>
         <div class="nhapthongtin">
            <table runat="server" class="">
                <tr>
                    <td class="col-1">Họ tên:</td>
                    <th class="col-2" colspan="4">
                        <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox></th>
                    
                </tr>
                <tr>
                    <td class="col-1">CMND:</td>
                    <td class="col-2">
                        <asp:TextBox ID="txtCMND" runat="server"></asp:TextBox></td>
                    <td class="col-3"></td>
                    <td class="col-4"></td>
                    <td class="col-5"></td>
                    <td class="col-6"></td>
                </tr>
                <tr>
                    <td class="col-1">Địa chỉ</td>
                    <th class="col-2" colspan="4">
                        <asp:TextBox ID="txtDiaChi" runat="server" Width="100%"></asp:TextBox></th>
                   
                    <td class="col-6"></td>
                </tr>
                <tr>
                    <td class="col-1">Tờ bản đồ <i><sub>(Chính xác)</sub></i></td>
                    <td class="col-2">
                        <asp:TextBox ID="txtToBanDo" runat="server"></asp:TextBox></td>
                    <td class="col-3">&nbsp;</td>
                    <td class="col-4">Số thửa <i><sub>(Chính xác)</sub></i></td>
                    <td class="col-5">
                        <asp:TextBox ID="txtSoThua" runat="server"></asp:TextBox></td>
                    <td class="col-6"></td>
                </tr>
            </table>
             <div class="center">
                 <asp:Button CssClass="btn btn-lg btn-warning" ID="btnTim" runat="server" Text="Tìm kiếm" OnClick="btnTim_Click" />
             </div>
             
            </div>
            <div>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="MaChu" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="DanhXung" />
                        <asp:BoundField DataField="HoTen" HeaderText="Họ Tên" />
                        <asp:BoundField DataField="NamSinh" HeaderText="Năm sinh" />
                        <asp:BoundField DataField="SoDinhDanh" HeaderText="CMND" />
                        <asp:BoundField DataField="NoiCap" HeaderText="Nơi cấp" />
                        <asp:BoundField DataField="NgayCap" HeaderText="Ngày cấp" />
                        <asp:BoundField DataField="QuocTich" HeaderText="Quốc tịch" />
                        <asp:BoundField DataField="MaChu" Visible="False" />
                        <asp:BoundField DataField="DinhDanh" Visible="False" />
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandName="Select" Text="Chọn" CommandArgument='<%# Eval("MaChu") %>'/>
                            </ItemTemplate>
                            <ControlStyle BackColor="#33CC33" />
                            <ItemStyle BackColor="#00CC00" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
            
        </div>
    </div>
</asp:Content>
