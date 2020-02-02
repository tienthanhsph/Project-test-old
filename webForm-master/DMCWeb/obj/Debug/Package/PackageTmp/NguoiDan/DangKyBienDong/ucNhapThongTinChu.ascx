<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucNhapThongTinChu.ascx.cs" Inherits="DMCWeb.NguoiDan.DangKyBienDong.ucNhapThongTinChu" %>


    
            <div class="tieude-xanh">THÔNG TIN CHỦ SỬ DỤNG</div>
            <div class="tieude-xanh">
                <asp:Label ID="lblTieuDeDon" runat="server" Text=""></asp:Label>
            </div>
            <div class="nhapthongtin" >
                <div class="noibat3">
                    <asp:Label ID="Label1" runat="server" Text="   Chọn loại đối tượng  "></asp:Label>
                    <asp:DropDownList ID="drLoaiDoiTuong" runat="server" OnSelectedIndexChanged="drLoaiDoiTuong_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                </div>
                            
                           
                <br />
                <div>
                    <asp:Button  CssClass="btn btn-primary" ID="btnThemChu" runat="server" Text="Thêm người" OnClick="btnThemChu_Click" />
                    <asp:Button  CssClass="btn btn-default" ID="btnTimChu" runat="server" Text="Tìm kiếm" OnClick="btnTimChu_Click" />

                </div> 
                <table runat="server" id="NhapThongTinChu">
                    <tr>
                        <td class="col-1"><asp:Label ID="Label38" runat="server" Text="Mã chủ"></asp:Label></td>
                        <td class="col-2"><asp:Label ID="lblMaChu" runat="server" Text=""></asp:Label></td>
                        <td class="col-3"></td>
                        <td class="col-4"></td>
                        <td class="col-5"></td>
                        <td class="col-6"></td>         
                    </tr>
                        <tr>
                        <td class="col-1">Danh xưng:</td>
                        <td class="col-2"><asp:DropDownList ID="drDanhXung" runat="server">
                            </asp:DropDownList></td>
                        <td class="col-3"></td>
                        <td class="col-4">Họ tên:</td>
                        <td class="col-5"><asp:TextBox ID="txtHoTen" runat="server" Text="(*)"></asp:TextBox></td>
                        <td class="col-6"></td>
                    </tr>
                        <tr>
                        <td class="col-1">Năm sinh</td>
                        <td class="col-2"><asp:TextBox ID="txtNamSinh" runat="server" TextMode="Number"></asp:TextBox></td>
                        <td class="col-3"></td>
                        <td class="col-4">Địa chỉ:</td>
                        <td class="col-5"><asp:TextBox ID="txtDiaChi" runat="server" Text="(*)"></asp:TextBox></td>
                        <td class="col-6"></td>
                    </tr>
                        <tr>
                        <td class="col-1">Định danh:</td>
                        <td class="col-2"><asp:TextBox ID="txtDinhDanh" runat="server" Text="CMND"></asp:TextBox></td>
                        <td class="col-3"></td>
                        <td class="col-4">Số định danh:</td>
                        <td class="col-5"><asp:TextBox ID="txtSoDinhDanh" runat="server" Text="(*)"></asp:TextBox></td>
                        <td class="col-6"></td>
                    </tr>
                        <tr>
                        <td class="col-1">Nơi cấp:</td>
                        <td class="col-2"><asp:TextBox ID="txtNoiCap" runat="server"></asp:TextBox></td>
                        <td class="col-3"></td>
                        <td class="col-4">Ngày cấp:</td>
                        <td class="col-5"> <asp:TextBox ID="txtNgayCap" runat="server" TextMode="DateTime"></asp:TextBox></td>
                        <td class="col-6"></td>
                    </tr>
                        <tr>
                        <td class="col-1">Quốc tịch:</td>
                        <td class="col-2"><asp:TextBox ID="txtQuocTich" runat="server" Text="Việt Nam"></asp:TextBox></td>
                        <td class="col-3"></td>
                        <td class="col-4"></td>
                        <td class="col-5"></td>
                        <td class="col-6"></td>
                    </tr>
                                
                </table>
                                              
                <br/>                            
                <div class="center" >
                    <asp:Button CssClass="btn btn-success" ID="btnLuuChu" runat="server" Text="Lưu thông tin" OnClick="btnLuuChu_Click" />
                <asp:Button CssClass="btn btn-warning" ID="btnSuaChu" runat="server" Text="Sửa" OnClick="btnSuaChu_Click" />
                     <asp:Button CssClass="btn btn-sm btn-warning" ID="btnHuy" runat="server" Text="Hủy" OnClick="btnHuy_Click"/>
                </div> 
                <br />                                                       
                <asp:GridView CssClass="grvThongTinDaNhap" ID="grvChu" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="grvChu_RowCommand" DataKeyNames="MaChu" OnRowDeleting="grvChu_RowDeleting" >
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
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Select" Text="Chọn" CommandArgument='<%# Eval("MaChu") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm('Bạn có chắc chắn muốn xóa không?')" Text="Xóa"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>                           
                <br />
                 <br />
                 <br />
            </div>
        
