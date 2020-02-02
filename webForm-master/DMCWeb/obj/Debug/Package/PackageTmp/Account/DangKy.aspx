<%@ Page Title="" Language="C#" MasterPageFile="~/Basic.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="DMCWeb.Account.DangKy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
        <div class="col-sm-3">

        </div>
         <div class="col-sm-6">
             <div class="login">
                 
                 <table style="width: 100%;" runat="server">
                     <tr>                       
                         <td class="left-3col">
                             
                         </td>
                         <td class="titlelogin">Đăng ký tài khoản.

                         </td>
                         <td class="right-3col"><asp:Label ID="lblSai" runat="server" Text="Sai tên tài khoản hoặc mật khẩu!" Visible="false" ></asp:Label></td>
                     </tr>
                     <tr>
                         <td class="left-3col">
                             Tên tài khoản

                         </td>
                         <td class="mid-3col">
                             <asp:TextBox ID="txtTaiKhoan" runat="server" Width="70%"></asp:TextBox>

                         </td>
                         
                         <td class="right-3col"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Phải nhập tên tài khoản" ControlToValidate="txtTaiKhoan" ></asp:RequiredFieldValidator>

                         </td>
                     </tr>
                     <tr>
                         <td class="left-3col">
                             Họ tên

                         </td>
                         <td class="mid-3col">
                             <asp:TextBox ID="txtHoTen" runat="server" Width="100%"></asp:TextBox>

                         </td>
                         
                         <td class="right-3col"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Phải nhập họ tên" ControlToValidate="txtTaiKhoan" ></asp:RequiredFieldValidator>

                         </td>
                     </tr>
                     <tr>
                         <td class="left-3col">
                             Mật khẩu

                         </td>
                         <td class="mid-3col">
                             <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password" Width="70%"></asp:TextBox>

                         </td>
                         <td class="right-3col">
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Phải nhập mật khẩu" ControlToValidate="txtMatKhau"></asp:RequiredFieldValidator>
                             

                         </td>
                     </tr>
                     <tr>
                         <td class="left-3col">
                             Mật khẩu *

                         </td>
                         <td class="mid-3col">
                             <asp:TextBox ID="txtMatKhau2" runat="server" TextMode="Password" Width="70%"></asp:TextBox>

                         </td>
                         <td class="right-3col">
                             <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Mật khẩu không khớp!" ControlToCompare="txtMatKhau" ControlToValidate="txtMatKhau2"></asp:CompareValidator> 
                         </td>
                     </tr>

                     <tr>
                         <td class="left-3col">
                             Mã quyền

                         </td>
                         <td class="mid-3col">
                             <asp:DropDownList ID="drMaQuyen" runat="server"></asp:DropDownList>

                         </td>
                         <td class="right-3col">
                             
                         </td>
                     </tr>
                     <tr>
                         <td class="left-3col">
                             Người quản lý

                         </td>
                         <td class="mid-3col">
                             <asp:TextBox ID="txtNguoiQuanLy" runat="server" TextMode="Password" Width="100%"></asp:TextBox>

                         </td>
                         <td class="right-3col">
                            
                         </td>
                     </tr>
                      
                     
                     <tr>
                         <td class="left-3col">
                             Ngày tạo tài khoản
                         </td>
                         <td class="mid-3col">
                             <asp:TextBox ID="txtNgayTao" runat="server" Width="60%"></asp:TextBox>
                         </td>
                         
                         <td>
                         </td>
                     </tr>
                     <tr>
                         <td class="left-3col">
                             Chức vụ
                         </td>
                         <td class="mid-3col">
                             <asp:TextBox ID="txtChucVu" runat="server" Width="60%"></asp:TextBox>
                         </td>
                         
                         <td class="right-3col">
                         </td>
                     </tr>
                      <tr>
                         <td class="left-3col">
                             Phòng ban
                         </td>
                         <td class="mid-3col">
                             <asp:TextBox ID="txtPhongBan" runat="server" Width="80%"></asp:TextBox>
                         </td>
                         
                         <td class="right-3col">
                         </td>
                     </tr>
                    <tr>
                         <td class="left-3col">
                             Địa chỉ

                         </td>
                         <td class="mid-3col">
                             <asp:TextBox ID="txtDiaChi" runat="server" Width="100%"></asp:TextBox>

                         </td>
                         
                         <td class="right-3col">
                         </td>
                     </tr>
                      <tr>
                         <td class="left-3col">
                             Điện thoại

                         </td>
                         <td class="mid-3col">
                             <asp:TextBox ID="txtSoDienThoai" runat="server" Width="60%" TextMode="Phone"></asp:TextBox>

                         </td>
                         
                         <td class="right-3col">
                         </td>
                     </tr>
                      
                     <tr style="height:30px; padding-top:10px;">
                         <td class="left-3col"></td>
                         <td class="mid-3col" style="text-align:center; padding:7px 0px;">
                             <asp:Button CssClass="btn btn-warning" ID="btnDangNhap" runat="server" Text="Đăng ký" Font-Bold="True" OnClick="btnDangNhap_Click" />&nbsp;
                              <asp:LinkButton ID="lnkDangKy" runat="server" ForeColor="White" PostBackUrl="~/Account/DangNhap.aspx" Visible="False"><i>Đăng nhập</i></asp:LinkButton>

                         </td>
                         <td >
                            
                         </td>
                     </tr>

                     
                 </table>
             </div>
        </div>
         <div class="col-sm-3">

        </div>
    </div>
</asp:Content>
