<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucThongTinThuaDatCoThayDoiDoDoDacLai.ascx.cs" Inherits="DMCWeb.NguoiDan.DangKyBienDong.ucThongTinThuaDatCoThayDoiDoDoDacLai" %>
<div>
    <%--<table style="width: 100%;" runat="server">
        <tr>
            <td>Tờ bản đồ số</td>
            <td>Thửa đất số</td>
            <td>Diện tích (m<sup>2</sup>)</td>
            <td style="width:40%">Nội dung thay đổi khác</td>
        </tr>
       <tr>
           
            <td>
                <asp:TextBox ID="txtToBanDo" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtSoThua" runat="server"></asp:TextBox>
            </td>
            <td>
               <asp:TextBox ID="txtDienTich" runat="server"></asp:TextBox>

            </td>
            <td style="width:40%">
                 <asp:TextBox ID="txtNoiDungThayDoiKhac" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th colspan="4">
                
            </th>            
        </tr>
    </table>--%>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" OnRowDeleting="GridView1_RowDeleting" OnRowCommand="GridView1_RowCommand" >
        <Columns>
            <asp:BoundField DataField="ToBanDo" HeaderText="Tờ bản đồ số" />
            <asp:BoundField DataField="SoThua" HeaderText="Thửa đất số" />
            <asp:BoundField DataField="DienTich" HeaderText="Diện tích (m2)" />
            <asp:BoundField DataField="NoiDungThayDoiKhac" HeaderText="Nội dung thay đổi khác" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="Chọn..." CommandArgument='<%# Eval("ID") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" Visible="False" />
        </Columns>
    </asp:GridView>
    <br>
    <div class="center">
        <asp:Button CssClass="btn btn-sm btn-success" ID="btnThemThuaDat" runat="server" Text="Thêm" OnClick="btnThemThuaDat_Click"/>
    </div>
    <table style="width: 100%;" runat="server" class="table" id="CapNhatThongTinThuaDatThayDoiDoBienDong">
        <tr>
            <td>4.1. Thông tin thửa đất theo GCN đã cấp: </td>
            <td>4.2. Thông tin thửa đất mới thay đổi:</td>
        </tr>
        <tr>
            <td>Thửa đất số:
                <asp:TextBox ID="txtThuaDat1" runat="server"></asp:TextBox>
            </td>
            <td>Thửa đất số:
                <asp:TextBox ID="txtThuaDat2" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Tờ bản đồ số:
                <asp:TextBox ID="txtToBanDo1" runat="server"></asp:TextBox>
            </td>
            <td>Tờ bản đồ số:
                <asp:TextBox ID="txtToBanDo2" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Diện tích:
                <asp:TextBox ID="txtDienTich1" runat="server"></asp:TextBox>
            </td>
            <td>Diện tích:
                <asp:TextBox ID="txtDienTich2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtNoiDungKhac1" runat="server" Height="100px" TextMode="MultiLine" Width="100%"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtNoiDungKhac2" runat="server" Height="100px" TextMode="MultiLine" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th colspan="2">
                <asp:Button CssClass="btn btn-sm btn-success" ID="btnLuuThongTin" runat="server" Text="Lưu" OnClick="btnLuuThongTin_Click" />
                <asp:Button CssClass="btn btn-sm btn-warning" ID="btnHuy" runat="server" Text="Hủy" OnClick="btnHuy_Click"/>
            </th>
        </tr>
    </table>
</div>