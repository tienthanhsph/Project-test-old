<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Tach_HopThua.ascx.cs" Inherits="DMCWeb.NguoiDan.DangKyBienDong.Tach_HopThua" %>
<div>
    <table style="width: 100%;" runat="server">
        <tr>
            <th>1. Đề nghị tách thành<asp:TextBox ID="txtSoThuaTachRa" runat="server" Width="50px"></asp:TextBox> thửa đất đối với thửa đất dưới đây:</th>           
        </tr>
         <tr>
            <td>a) Thửa đất số:<asp:TextBox ID="txtSoThua" runat="server"></asp:TextBox></td>
            <td>b) Tờ bản đồ số:<asp:TextBox ID="txtToBanDo" runat="server"></asp:TextBox></td>           
        </tr>
        <tr>
            <th colspan="2">
                c) Địa chỉ thửa đất:<asp:TextBox ID="txtDiaChiThua" runat="server"></asp:TextBox>
            </th>
        </tr>
         <tr>
            <td>d) Số phát hành Giấy chứng nhận:<asp:TextBox ID="txtSoPhatHanhGCN" runat="server"></asp:TextBox></td>
            <td></td>           
        </tr>
        <tr>
            <td>Số vào sổ cấp Giấy chứng nhận:<asp:TextBox ID="txtSoVaoSoCapGCN" runat="server"></asp:TextBox></td>
            <td>Ngày cấp:<asp:TextBox ID="txtNgayCapGCN" runat="server"></asp:TextBox></td>           
        </tr>
         <tr>
            <th colspan="2">
                đ) Diện tích sau khi tách thửa: Thửa thứ nhất:<asp:TextBox ID="txtTT_DienTichThua1" runat="server" Width="50px"></asp:TextBox>  m<sup>2</sup>; Thửa đất thứ hai:<asp:TextBox ID="txtTT_DienTichThua2" runat="server" Width="50px"></asp:TextBox> m<sup>2</sup>;    <i>(Sẽ chỉnh sửa nếu nhiều hơn 2 thửa!)</i>
            </th>
        </tr>
    </table>
    <div class="center">
    <asp:Button CssClass="btn btn-xm btn-success" ID="btnLuuThongTinThuaCanTach" runat="server" Text="Lưu" OnClick="btnLuuThongTinThuaCanTach_Click" />
         <asp:Button CssClass="btn btn-xm btn-warning" ID="btnSuaThongTinThuaCanTach" runat="server" Text="Sửa" OnClick="btnSuaThongTinThuaCanTach_Click" />
        </div>
    <br />
    <table class="table-bordered" style="width: 100%;" runat="server">
        <tr>
            <th colspan="5">
                2. Đề nghị hợp các thửa đất dưới đây thành một thửa đất:
            </th>
        </tr>
         <tr>
            <th colspan="5" style="text-align:left;">
               <asp:Button CssClass="btn btn-xm btn-success" ID="btnThemThuaCanHop" runat="server" Text="Thêm" OnClick="btnThemThuaCanHop_Click" />
            </th>
        </tr>
        <tr>
            <td>Thửa đất số</td>
            <td>Tờ bản đồ số</td>
            <td>Địa chỉ thửa đất</td>
            <td>Số phát hành GCN</td>
            <td>Số vào sổ cấp GCN</td>
        </tr>
         <tr>
            <td>
                <asp:TextBox ID="txtHT_ThuaDatSo" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtHT_ToBanDo" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtHT_DiaChiThua" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtHT_SoPhatHanh" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtHT_SoVaoSo" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <th colspan="5">
                <div class="center">
                <asp:Button CssClass="btn btn-xm btn-success" ID="btnLuuThuaCanHop" runat="server" Text="Lưu" OnClick="btnLuuThuaCanHop_Click" />
                
                 <asp:Button CssClass="btn btn-sm btn-warning" ID="btnHuy" runat="server" Text="Hủy" OnClick="btnHuy_Click"/>
                </div>
            </th>
        </tr>
        <tr>
            <th colspan="5">
                <asp:GridView ID="grvThuaDatDeNghiHopThua" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="ID" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="Thửa đất số" DataField="SoThua" />
                        <asp:BoundField HeaderText="Tờ bản đồ số" DataField="TobanDo" />
                        <asp:BoundField HeaderText="Địa chỉ thửa đất" DataField="DiaChi" />
                        <asp:BoundField HeaderText="Số phát hành GCN" DataField="SoPhatHanhGCN" />
                        <asp:BoundField HeaderText="Số vào sổ cấp GCN" DataField="SoVaoSoCapGCN" />
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="Chọn" CommandArgument='<%# Eval("ID") %>' ></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" >
                        <ControlStyle BackColor="Red" ForeColor="White" />
                        </asp:CommandField>
                        <asp:BoundField DataField="ID" HeaderText="ID" Visible="False" />
                    </Columns>
                </asp:GridView>
            </th>
        </tr>

    </table>
    
</div>
