<%@ Page Title="" Language="C#" MasterPageFile="~/Basic.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="DMCWeb.Account.DangNhap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-3">

        </div>
         <div class="col-sm-6">
             <div class="login">
                 
                 <table style="width: 100%;"  runat="server">
                     <tr>
                       
                         <td class="left-3col">
                            
                         </td>
                         <td class="titlelogin">Đăng nhập
                         </td>
                         <td class="right-3col"><asp:Label ID="lblSai" runat="server" Text="Sai tên tài khoản hoặc mật khẩu!" Visible="false" ></asp:Label></td>
                     </tr>
                     <tr>
                         <td class="left-3col">
                             Tài khoản

                         </td>
                         <td class="mid-3col">
                             <asp:TextBox ID="txtTaiKhoan" runat="server" Width="100%"></asp:TextBox>

                         </td>
                         
                         <td class="right-3col"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Phải nhập tên tài khoản" ControlToValidate="txtTaiKhoan" ></asp:RequiredFieldValidator>

                         </td>
                     </tr>
                     <tr>
                         <td class="left-3col">
                             Mật khẩu

                         </td>
                         <td class="mid-3col">
                             <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password" Width="100%"></asp:TextBox>

                         </td>
                         <td class="right-3col">
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Phải nhập mật khẩu" ControlToValidate="txtMatKhau"></asp:RequiredFieldValidator>
                             

                         </td>
                     </tr>
                     <tr style="height:30px; padding-top:10px;">
                         <td class="left-3col"></td>
                         <td class="mid-3col" style="text-align:center; padding:7px 0px;">
                             <asp:Button CssClass="btn btn-warning" ID="btnDangNhap" runat="server" Text="Đăng nhập" Font-Bold="True" OnClick="btnDangNhap_Click"/> &nbsp; <asp:LinkButton ID="lnkDangKy" runat="server" ForeColor="White" PostBackUrl="~/Account/DangKy.aspx" Visible="False"><i>Đăng ký</i></asp:LinkButton></td>
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
