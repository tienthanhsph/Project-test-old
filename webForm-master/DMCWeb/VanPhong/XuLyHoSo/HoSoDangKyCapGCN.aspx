<%@ Page Title="" Language="C#" MasterPageFile="~/Excute.Master" AutoEventWireup="true" CodeBehind="HoSoDangKyCapGCN.aspx.cs" Inherits="DMCWeb.VanPhong.XuLyHoSo.HoSoDangKyCapGCN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="tieude-xanh">
        HỒ SƠ ĐĂNG KÝ CẤP GCN QUYỀN SỬ DỤNG ĐẤT
    </div>
    <div class="btn-group">
        <%--<asp:Button CssClass="btn btn-danger" ID="btnTaoDon" runat="server" Text="Tạo đơn đăng ký." OnClick="btnTaoDon_Click"/>--%>
        <asp:Button CssClass="btn btn-default" ID="btnSuaDon" runat="server" Text="Sửa thông tin đơn" OnClick="btnSuaDon_Click" />
    </div>
    
    <div class="noidungdon">
        <div class="noibat2">
            <asp:Label ID="Label3" runat="server" Text="Đơn vị hành chính: "></asp:Label>
            <asp:DropDownList ID="drDonViHanhChinh" runat="server" DataSourceID="dtsDVHC" DataTextField="Ten" DataValueField="MaDonViHanhChinh"></asp:DropDownList>
            <asp:EntityDataSource ID="dtsDVHC" runat="server" ConnectionString="name=DMCWebEntities" DefaultContainerName="DMCWebEntities" EnableFlattening="False" EntitySetName="DVHCtams" Select="it.[MaDonViHanhChinh], it.[Ten]">
            </asp:EntityDataSource>
        </div>


    <div class="wizard">
        <asp:Wizard ID="Wizard1" runat="server" StartNextButtonText="Tiếp theo..." StepNextButtonText="Tiếp theo..." StepPreviousButtonText="Quay lại" FinishPreviousButtonText="Quay lại" FinishCompleteButtonText="Gửi hồ sơ."  SideBarStyle-CssClass="wizardSlideBar" StepPreviousButtonStyle-CssClass="btn btn-info" StepNextButtonStyle-CssClass="btn btn-success" StartNextButtonStyle-CssClass="btn btn-success" FinishPreviousButtonStyle-CssClass="btn btn-info" FinishCompleteButtonStyle-CssClass="btn btn-info" CssClass="wizardStyle" StepStyle-CssClass="wizardStepStyle" ActiveStepIndex="0" DisplaySideBar="False">
           

            <FinishCompleteButtonStyle CssClass="btn btn-info"></FinishCompleteButtonStyle>

            <FinishPreviousButtonStyle CssClass="btn btn-info"></FinishPreviousButtonStyle>

            <StartNextButtonStyle CssClass="btn btn-success"></StartNextButtonStyle>

            <StepNextButtonStyle CssClass="btn btn-success"></StepNextButtonStyle>

            <StepPreviousButtonStyle CssClass="btn btn-info"></StepPreviousButtonStyle>

            <SideBarStyle CssClass="wizardSlideBar" HorizontalAlign="Left" VerticalAlign="Top" BackColor="LightSteelBlue"></SideBarStyle>

            <StepStyle CssClass="wizardStepStyle"></StepStyle>
           

            <WizardSteps>
                <asp:WizardStep ID="stepChu" runat="server" Title="CHỦ SỬ DỤNG">
                    <div class="blogthongtin" id="thongtinchu">
                        <div class="tieudeblogthongtin">THÔNG TIN CHỦ SỬ DỤNG</div>
                        <div class="nhapthongtin">
                            <div class="noibat3">
                                <asp:Label ID="Label1" runat="server" Text="   Chọn loại đối tượng  "></asp:Label>
                                <asp:DropDownList ID="drLoaiDoiTuong" runat="server" OnSelectedIndexChanged="drLoaiDoiTuong_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                            </div>
                            
                           
                            <br />
                            <div>
                                <asp:Button  CssClass="btn btn-primary" ID="btnThemChu" runat="server" Text="Thêm người" OnClick="btnThemChu_Click" />
                            </div> 
                            <table runat="server" id="NhapThongTinChu">
                                <tr>
                                    <td class="col-1"><asp:Label ID="Label38" runat="server" Text="Mã chủ"></asp:Label></td>
                                    <th class="col-2" colspan="5"><asp:Label ID="lblMaChu" runat="server" Text=""></asp:Label></th>
                                   
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
                            <asp:Button CssClass="btn btn-warning" ID="btnHuyChu" runat="server" Text="Hủy" OnClick="btnHuyChu_Click" />
                            </div> 
                            <br />                                                       
                            <asp:GridView CssClass="grvThongTinDaNhap" ID="grvChu" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="grvChu_RowCommand" DataKeyNames="MaChu" OnRowDeleting="grvChu_RowDeleting" Caption="Thông tin chi tiết">
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
                        </div>
                    </div>
                </asp:WizardStep>
                <asp:WizardStep ID="stepThuaDat" runat="server" Title="THỬA ĐẤT">
                    <div class="blogthongtin" id="thongtinthuadat">
                        <div class="tieudeblogthongtin">THÔNG TIN THỬA ĐẤT</div>
                        <div class="nhapthongtin">
                            <div>
                            <asp:Button CssClass="btn btn-primary" ID="btnThemThuaDat" runat="server" Text="Thêm thửa đất" OnClick="btnThemThuaDat_Click" />
                            </div>    
                            <br />
                            <table runat="server" id="NhapThongTinThuaDat">
                                <tr>
                                    <td class="col-1">Mã hồ sơ:</td>
                                    <td class="col-2"><asp:Label ID="lblMaHoSo" runat="server" Text=""></asp:Label></td>
                                    <td class="col-3"></td>
                                    <td class="col-4">Mã Thửa đất:</td>
                                    <td class="col-5"><asp:Label ID="lblMaThuaDat" runat="server" Text=""></asp:Label></td>
                                    <td class="col-6"></td>
                                </tr>      
                                <tr>
                                    <td class="col-1">Tờ bản đồ:</td>
                                    <td class="col-2"><asp:TextBox ID="txtToBanDo" runat="server"></asp:TextBox></td>
                                    <td class="col-3"></td>
                                    <td class="col-4">Số thửa:</td>
                                    <td class="col-5"><asp:TextBox ID="txtSoThua" runat="server"></asp:TextBox></td>
                                    <td class="col-6"></td>
                                </tr>  
                                <tr>
                                    <td class="col-1">Địa chỉ:</td>
                                    <th class="col-2" colspan="4"><asp:TextBox ID="txtDiaChiThuaDat" runat="server" Width="100%"></asp:TextBox></th>
                                    <td class="col-6"></td>
                                   
                                </tr>
                                 <tr>
                                    <td class="col-1">Diện tích:</td>
                                    <th class="col-2" colspan="5"> <asp:TextBox ID="txtDienTich" runat="server"></asp:TextBox></th>
                                   
                                </tr>
                                <tr>
                                    <td class="col-1">Sử dụng chung:</td>
                                    <td class="col-2"><asp:TextBox ID="txtDTSDChung" runat="server"></asp:TextBox></td>
                                    <td class="col-3"></td>
                                    <td class="col-4">Sử dụng riêng:</td>
                                    <td class="col-5"><asp:TextBox ID="txtDTSDRieng" runat="server"></asp:TextBox></td>
                                    <td class="col-6"></td>
                                </tr>  
                                <tr>
                                    <td class="col-1">Mục đích:</td>
                                    <td class="col-2"><asp:TextBox ID="txtMucDich" runat="server"></asp:TextBox></td>
                                    <td class="col-3"></td>
                                    <td class="col-4">Thời hạn:</td>
                                    <td class="col-5"><asp:TextBox ID="txtThoiHan" runat="server"></asp:TextBox></td>
                                    <td class="col-6"></td>
                                </tr>  
                                <tr>
                                    <td class="col-1">Nguồn gốc:</td>
                                    <td class="col-2">
                                        <asp:DropDownList ID="drLoaiNguonGoc" runat="server" DataSourceID="dtsLoaiNguonGocSuDung" DataTextField="Ten" DataValueField="LoaiNguonGocSuDung">
                                        </asp:DropDownList>
                                        <asp:EntityDataSource ID="dtsLoaiNguonGocSuDung" runat="server" ConnectionString="name=DMCWebEntities" DefaultContainerName="DMCWebEntities" EnableFlattening="False" EntitySetName="tblNguonGocSuDungs" Select="it.[LoaiNguonGocSuDung], it.[Ten]">
                                        </asp:EntityDataSource>

                                    </td>
                                    <td class="col-3"></td>
                                    <td class="col-4">Ngày bắt đầu:</td>
                                    <td class="col-5"><asp:TextBox ID="txtNgayBatDau" runat="server" TextMode="DateTime"></asp:TextBox></td>
                                    <td class="col-6"></td>
                                </tr>  
                                <tr>
                                    <td class="col-1">Có hạn chế:</td>
                                    <td class="col-2">
                                        <asp:DropDownList ID="drHanChe" runat="server" >
                                            <asp:ListItem Selected="True" Value="false">Không</asp:ListItem>
                                            <asp:ListItem Value="true">Có</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="col-3"></td>
                                    <td class="col-4">Hạn chế:</td>
                                    <td class="col-5"><asp:TextBox ID="txtHanChe" runat="server"></asp:TextBox></td>
                                    <td class="col-6"></td>
                                </tr>  
                                 
                            </table>                                    
                            
                            <br/>                           
                            <div class="center">
                            <asp:Button CssClass="btn btn-success" ID="btnLuuThuaDat" runat="server" Text="Lưu thông tin" OnClick="btnLuuThuaDat_Click" />
                            <asp:Button CssClass="btn btn-warning" ID="btnHuyThuaDat" runat="server" Text="Hủy" OnClick="btnHuyThuaDat_Click" />
                            </div>
                            <br />                            
                            <asp:GridView CssClass="grvThongTinDaNhap" ID="grvThuaDat" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="grvThuaDat_RowCommand" OnRowDeleting="grvThuaDat_RowDeleting" Caption="Thông tin đã lưu." CaptionAlign="Top">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="MaThuaDat" HeaderText="Mã thửa đất" Visible="False" />
                                    <asp:BoundField DataField="MaHoSo" HeaderText="Mã hồ sơ" Visible="False" />
                                    <asp:BoundField DataField="ToBanDo" HeaderText="Số Tờ" />
                                    <asp:BoundField DataField="SoThua" HeaderText="Số Thửa" />
                                    <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
                                    <asp:BoundField DataField="DienTich" HeaderText="Diện tích" />
                                    <asp:BoundField DataField="SuDungChung" HeaderText="Chung" />
                                    <asp:BoundField DataField="SuDungRieng" HeaderText="Riêng" />
                                    <asp:BoundField DataField="MucDichSuDung" HeaderText="Mục đích" />
                                    <asp:BoundField DataField="ThoiHanSuDung" HeaderText="Thời hạn" Visible="False" />
                                    <asp:BoundField DataField="NgayBatDauSuDung" HeaderText="SD từ ngày" DataFormatString="{0:dd/MM/yyyy}" />
                                    <asp:BoundField DataField="LoaiNguonGocSuDung" HeaderText="Nguồn gốc" Visible="False" />
                                    <asp:CheckBoxField DataField="CoHanCheSuDung" HeaderText="Hạn chế" />
                                    <asp:BoundField DataField="NoiDungHanCheSuDung" HeaderText="Hạn chế" Visible="False" />
                                    <asp:TemplateField ShowHeader="False">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Select" Text="Chọn" CommandArgument='<%# Eval("MaThuaDat") %>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ShowHeader="False">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Xóa"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <EditRowStyle BackColor="#7C6F57" />
                                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle" />
                                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#E3EAEB" />
                                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                                <SortedAscendingHeaderStyle BackColor="#246B61" />
                                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                <SortedDescendingHeaderStyle BackColor="#15524A" />
                            </asp:GridView>                           
                            <br />
                        </div>
                    </div>
                </asp:WizardStep>
                <asp:WizardStep ID="stepNhaO" runat="server" Title="NHÀ Ở">
                     <div class="blogthongtin" id="thongtinnhao">
                        <div class="tieudeblogthongtin">THÔNG TIN NHÀ Ở</div>

                        <div class="nhapthongtin">

                            <div>
                            <asp:Button CssClass="btn btn-primary" ID="btnThemNhaO" runat="server" Text="Thêm nhà ở / công trình" OnClick="btnThemNhaO_Click"/>
                            </div> 
                             <table runat="server" id="NhapThongTinNhaO">
                                <tr>
                                    <td class="col-1">Mã số:</td>
                                    <td class="col-2"><asp:Label ID="lblMaNhaO" runat="server" Text=""></asp:Label></td>
                                    <td class="col-3"></td>
                                    <td class="col-4">Loại nhà ở:</td>
                                    <td class="col-5"><asp:DropDownList ID="drLoaiNhaO" runat="server" DataSourceID="dtsLoaiNhaOCongTrinh" DataTextField="Ten" DataValueField="LoaiNhaO"></asp:DropDownList>
                                        <asp:EntityDataSource ID="dtsLoaiNhaOCongTrinh" runat="server" ConnectionString="name=DMCWebEntities" DefaultContainerName="DMCWebEntities" EnableFlattening="False" EntitySetName="tblLoaiNhaO_CongTrinh" Select="it.[LoaiNhaO], it.[Ten]">
                                        </asp:EntityDataSource>

                                    </td>
                                    <td class="col-6"></td>
                                </tr>      
                                <tr>
                                    <td class="col-1">Diện tích xây dựng:</td>
                                    <td class="col-2"> <asp:TextBox ID="txtDienTichXayDung" runat="server"></asp:TextBox></td>
                                    <td class="col-3"></td>
                                    <td class="col-4">Diện tích sàn:</td>
                                    <td class="col-5"><asp:TextBox ID="txtDienTichSan" runat="server"></asp:TextBox></td>
                                    <td class="col-6"></td>
                                </tr>  
                                 <tr>
                                    <td class="col-1">Sở hữu chung:</td>
                                    <td class="col-2"> <asp:TextBox ID="txtSoHuuChung" runat="server"></asp:TextBox></td>
                                    <td class="col-3"></td>
                                    <td class="col-4">Sở hữu riêng:</td>
                                    <td class="col-5"><asp:TextBox ID="txtSoHuuRieng" runat="server"></asp:TextBox></td>
                                    <td class="col-6"></td>
                                </tr> 
                                 <tr>
                                    <td class="col-1">Kết cấu:</td>
                                    <td class="col-2"><asp:TextBox ID="txtKetCau" runat="server"></asp:TextBox></td>
                                    <td class="col-3"></td>
                                    <td class="col-4">Số tầng:</td>
                                    <td class="col-5"><asp:TextBox ID="txtSoTang" runat="server"></asp:TextBox></td>
                                    <td class="col-6"></td>
                                </tr> 
                                 <tr>
                                    <td class="col-1">Có hạn chế:</td>
                                    <td class="col-2"> <asp:DropDownList ID="drHanCheNha" runat="server">
                                            <asp:ListItem Selected="True" Value="false">Không</asp:ListItem>
                                            <asp:ListItem Value="true">Có</asp:ListItem>
                                        </asp:DropDownList>

                                    </td>
                                    <td class="col-3"></td>
                                    <td class="col-4">Hạn chế:</td>
                                    <td class="col-5"><asp:TextBox ID="txtHanCheNha" runat="server" TextMode="DateTime"></asp:TextBox>

                                    </td>
                                    <td class="col-6"></td>
                                </tr> 
                                
                            </table>                         
                            
                            <br/>                           
                            <div class="center">
                            <asp:Button CssClass="btn btn-success" ID="Button2" runat="server" Text="Lưu thông tin" OnClick="btnLuuNhaO_Click" />
                            <asp:Button CssClass="btn btn-warning" ID="Button3" runat="server" Text="Hủy" OnClick="btnHuyNhaO_Click" />
                            </div>                            
                            <asp:GridView CssClass="grvThongTinDaNhap" ID="grvNhaO" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="grvNhaO_RowCommand" OnRowDeleting="grvNhaO_RowDeleting" Caption="Thông tin đã lưu." CaptionAlign="Top">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="MaNhaO" HeaderText="Mã Số" Visible="False" />
                                    <asp:BoundField DataField="MaHoSo" HeaderText="Mã hồ sơ" Visible="False" />
                                    <asp:BoundField DataField="LoaiNhaO" HeaderText="Loại nhà ở" />
                                    <asp:BoundField DataField="DienTichXayDung" HeaderText="Diện tích xây dựng" />
                                    <asp:BoundField DataField="DienTichSan" HeaderText="Diện tích sàn" />
                                    <asp:BoundField DataField="SoHuuChung" HeaderText="Sở hữu chung" />
                                    <asp:BoundField DataField="SoHuuRieng" HeaderText="Sở hữu riêng" />
                                    <asp:BoundField DataField="KetCau" HeaderText="Kết cấu" />
                                    <asp:BoundField DataField="SoTang" HeaderText="Số tầng" />
                                    <asp:BoundField DataField="CoHanCheThoiHanSoHuu" HeaderText="Hạn chế thời hạn" Visible="False" />
                                    <asp:BoundField DataField="ThoiHanSoHuu" HeaderText="Thời hạn" />
                                    <asp:TemplateField ShowHeader="False">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Select" Text="Chọn" CommandArgument='<%# Eval("MaNhaO") %>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ShowHeader="False">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Xóa"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <EditRowStyle BackColor="#7C6F57" />
                                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle" />
                                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#E3EAEB" />
                                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                                <SortedAscendingHeaderStyle BackColor="#246B61" />
                                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                <SortedDescendingHeaderStyle BackColor="#15524A" />
                            </asp:GridView>                           
                            <br />
                        </div>
                        </div>
                   
                 </asp:WizardStep>
                <asp:WizardStep ID="stepRungSanXuat" runat="server" Title="RỪNG SẢN XUẤT">
                    <div class="blogthongtin" id="rungsanxuat">
                        <div class="tieudeblogthongtin">THÔNG TIN RỪNG SẢN XUẤT</div>
                        <div class="nhapthongtin"></div>
                    </div>
                </asp:WizardStep>
                <asp:WizardStep ID="stepRungCayLauNam" runat="server" Title="RỪNG CÂY LÂU NĂM">
                     <div class="blogthongtin" id="thongtinrungcay">
                        <div class="tieudeblogthongtin">THÔNG TIN RỪNG CÂY LÂU NĂM</div>
                        <div class="nhapthongtin"></div>
                    </div>
                 </asp:WizardStep>
                <asp:WizardStep ID="stepGuiHoSo" runat="server" Title="THÔNG TIN GỬI HỒ SƠ">
                    <div class="blogthongtin" id="thongtinhoso">
                         <div class="nhapthongtin">
                            
                            <br />
                            <table  id="NhapThongTinGuiHoSo"  runat="server" >
                                <tr>
                                    <td class="left-3col" runat="server">
                                        <asp:Label ID="Label17" runat="server" Text="Tiêu đề kính gửi"></asp:Label>&nbsp;</td>
                                    <td class="mid-3col" runat="server">
                                        <asp:TextBox ID="txtTieuDeKinhGui" runat="server" Width="100%"></asp:TextBox>&nbsp;</td>
                                    <td class="right-3col" runat="server">&nbsp;</td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" class="left-3col">
                                        <asp:Label ID="Label18" runat="server" Text="Người viết đơn"></asp:Label>&nbsp;</td>
                                    <td runat="server" class="mid-3col">
                                        <asp:TextBox ID="txtNguoiVietDon" runat="server"  Width="100%"></asp:TextBox>&nbsp;</td>
                                    <td runat="server" class="right-3col">&nbsp;</td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" class="left-3col">
                                        <asp:Label ID="Label31" runat="server" Text="Loại đề nghị"></asp:Label>&nbsp;</td>
                                    <td runat="server" class="mid-3col">
                                        <asp:DropDownList ID="drLoaiDeNghiCapGCN" runat="server" DataSourceID="dtsLoaiDeNghiCapGCN" DataTextField="TenDeNghi" DataValueField="MaLoaiDeNghi"></asp:DropDownList>
                                        <asp:EntityDataSource ID="dtsLoaiDeNghiCapGCN" runat="server" ConnectionString="name=DMCWebEntities" DefaultContainerName="DMCWebEntities" EnableFlattening="False" EntitySetName="tblLoaiDeNghiDangKyCapGCNs" Select="it.[MaLoaiDeNghi], it.[TenDeNghi]">
                                        </asp:EntityDataSource>
                                        &nbsp;</td>
                                    <td runat="server" class="right-3col">&nbsp;</td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" class="left-3col">
                                        <asp:Label ID="Label33" runat="server" Text="Nghĩa vụ tài chính"></asp:Label>&nbsp;</td>
                                    <td runat="server" class="mid-3col">
                                        <asp:TextBox ID="txtNghiaVuTaiChinh" runat="server"  Width="100px"></asp:TextBox>&nbsp;</td>
                                    <td runat="server" class="right-3col">&nbsp;</td>
                                </tr>
                                
                                 <tr runat="server">
                                    <td runat="server" class="left-3col">
                                        <asp:Label ID="Label19" runat="server" Text="Giấy tờ kèm theo"></asp:Label>&nbsp;</td>
                                    <td runat="server" class="mid-3col">
                                        <asp:TextBox ID="txtGiayToKemTheo" runat="server"  Width="100%" Height="120px" TextMode="MultiLine"></asp:TextBox>&nbsp;</td>
                                    <td runat="server" class="right-3col">&nbsp;</td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" class="left-3col">
                                        <asp:Label ID="Label32" runat="server" Text="Đề nghị khác"></asp:Label>&nbsp;</td>
                                    <td runat="server" class="mid-3col">
                                        <asp:TextBox ID="txtDeNghiKhac" runat="server"  Width="100%" Height="100px" TextMode="MultiLine"></asp:TextBox>&nbsp;</td>
                                    <td runat="server" class="right-3col">&nbsp;</td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" class="left-3col">
                                        <asp:Label ID="Label29" runat="server" Text="Email"></asp:Label>&nbsp;</td>
                                    <td runat="server" class="mid-3col">
                                        <asp:TextBox ID="txtEmailNguoiVietDon" runat="server"  Width="100px" TextMode="Email"></asp:TextBox>&nbsp;</td>
                                    <td runat="server" class="right-3col">&nbsp;</td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" class="left-3col">
                                        <asp:Label ID="Label30" runat="server" Text="Điện thoại"></asp:Label>&nbsp;</td>
                                    <td runat="server" class="mid-3col">
                                        <asp:TextBox ID="txtDienThoaiNguoiVietDon" runat="server"  Width="100px"></asp:TextBox>&nbsp;</td>
                                    <td runat="server" class="right-3col">&nbsp;</td>
                                </tr>
                            </table>

                             <br />
                            <table id="NhapThongTinNhanHoSo"  runat="server" >
                                 <tr>
                                    <td class="left-3col" runat="server">
                                        <asp:Label ID="Label34" runat="server" Text="Ngày nhận hồ sơ"></asp:Label>&nbsp;</td>
                                    <td class="mid-3col" runat="server">
                                        <asp:TextBox ID="txtNgayNhan" runat="server" TextMode="DateTime"  Width="100px"></asp:TextBox>&nbsp;</td>
                                    <td class="right-3col" runat="server">&nbsp;</td>
                                </tr>
                                 <tr runat="server">
                                     <td runat="server" class="left-3col">
                                         <asp:Label ID="Label35" runat="server" Text="Người nhận hồ sơ"></asp:Label>&nbsp;</td>
                                     <td runat="server" class="mid-3col">
                                         <asp:TextBox ID="txtNguoiNhan" runat="server"  Width="100%"></asp:TextBox>&nbsp;</td>
                                     <td runat="server" class="right-3col">&nbsp;</td>
                                 </tr>
                                 <tr runat="server">
                                     <td runat="server" class="left-3col">
                                         <asp:Label ID="Label36" runat="server" Text="Số tiếp nhận"></asp:Label>&nbsp;</td>
                                     <td runat="server" class="mid-3col">
                                         <asp:TextBox ID="txtSoTiepNhan" runat="server"  Width="80px"></asp:TextBox>&nbsp;</td>
                                     <td runat="server" class="right-3col">&nbsp;</td>
                                 </tr>
                                 <tr runat="server">
                                     <td runat="server" class="left-3col">
                                         <asp:Label ID="Label37" runat="server" Text="Quyển"></asp:Label>&nbsp;</td>
                                     <td runat="server" class="mid-3col">
                                         <asp:TextBox ID="txtQuyen" runat="server"  Width="100px"></asp:TextBox>&nbsp;</td>
                                     <td runat="server" class="right-3col">&nbsp;</td>
                                 </tr>
                                 
                            </table>

                            <br />
                            <%--<div class="center">
                            <asp:Button CssClass="btn btn-success" ID="btnLuuThongTinHoSo" runat="server" Text="Lưu thông tin" OnClick="btnLuuThongTinHoSo_Click" />
                                 <asp:Button CssClass="btn btn-default" ID="btnSuaThongTinHoSo" runat="server" Text="Sửa thông tin" OnClick="btnSuaThongTinHoSo_Click" />
                            </div> --%>
                             <br />
                             <br />  
                         </div>
                    </div>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>        
    </div>
   
    </div>

    <div >
        <asp:Button CssClass="btn btn-lg btn-warning" ID="btnXemHoSo" runat="server" Text="Xem hồ sơ" OnClick="btnXemHoSo_Click" />
       
    </div>
</asp:Content>
