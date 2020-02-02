<%@ Page Title="" Language="C#" MasterPageFile="~/Excute.Master" AutoEventWireup="true" CodeBehind="TuDienLoaiNguonGocSuDung.aspx.cs" Inherits="DMCWeb.TuDien.TuDienLoaiNguonGocSuDung" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <div class="row">
           
            <br />
            <br />

             
                 <div class="toLeft" style="width:45%">
                 
                 <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" Caption="Từ điển nguồn gốc sử dụng" CaptionAlign="Top" DataKeyNames="LoaiNguonGocSuDung" DataSourceID="dtsNguonGocSuDung_gridview"  OnRowCommand="GridView1_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None" BorderWidth="1">
                     <AlternatingRowStyle BackColor="White" />
                     <Columns>
                         <asp:BoundField DataField="LoaiNguonGocSuDung" HeaderText="LoaiNguonGocSuDung" ReadOnly="True" SortExpression="LoaiNguonGocSuDung" Visible="False" />
                         <asp:BoundField DataField="Ten" HeaderText="Tên nguồn gốc sử dụng" SortExpression="Ten">
                         <ItemStyle Width="300px" />
                         </asp:BoundField>
                         <asp:CommandField SelectText="Xem" ShowSelectButton="True" />
                         <asp:TemplateField ShowHeader="False">
                             <ItemTemplate>
                                 <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Xóa" OnClientClick=" return confirm('Bạn có chắc chắn muốn xóa không?')"></asp:LinkButton>
                             </ItemTemplate>
                         </asp:TemplateField>
                         <asp:CommandField NewText="Thêm" ShowInsertButton="True" />
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
                 <asp:EntityDataSource ID="dtsNguonGocSuDung_gridview" runat="server" ConnectionString="name=DMCWebEntities" DefaultContainerName="DMCWebEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="tblNguonGocSuDungs">
                 </asp:EntityDataSource>
                     </div>
       
                <div class="toRight"  style="width:45%">
                
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="LoaiNguonGocSuDung" DataSourceID="dtsNguonGocSuDugn_detailsview" DefaultMode="Edit" GridLines="Vertical" Height="50px" Width="125px" OnItemUpdated="DetailsView1_ItemUpdated" OnItemInserted="DetailsView1_ItemInserted" Caption="Chi tiết" CaptionAlign="Top">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <Fields>
                        <asp:BoundField DataField="LoaiNguonGocSuDung" HeaderText="Mã số" ReadOnly="True" SortExpression="LoaiNguonGocSuDung" />
                        <asp:BoundField DataField="Ten" HeaderText="Tên" SortExpression="Ten" />
                        <asp:CommandField CancelText="Hủy" NewText="Thêm" ShowEditButton="True" ShowInsertButton="True" UpdateText="Sửa" InsertText="Thêm">
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:CommandField>
                    </Fields>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                </asp:DetailsView>
                <asp:EntityDataSource ID="dtsNguonGocSuDugn_detailsview" runat="server" ConnectionString="name=DMCWebEntities" DefaultContainerName="DMCWebEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="tblNguonGocSuDungs" Where="" AutoGenerateWhereClause="True" EntityTypeFilter="" Select="">
                    <WhereParameters>
                        <asp:ControlParameter ControlID="GridView1" DbType="Int32" Name="LoaiNguonGocSuDung" PropertyName="SelectedValue" />
                    </WhereParameters>
                </asp:EntityDataSource>
                    </div>
            </div>

        

</asp:Content>
