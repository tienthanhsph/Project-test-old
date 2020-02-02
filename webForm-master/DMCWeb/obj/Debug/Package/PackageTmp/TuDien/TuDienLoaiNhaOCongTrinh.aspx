<%@ Page Title="" Language="C#" MasterPageFile="~/Excute.Master" AutoEventWireup="true" CodeBehind="TuDienLoaiNhaOCongTrinh.aspx.cs" Inherits="DMCWeb.TuDienLoaiNhaOCongTrinh" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
        <div class="row">
           
            <br />
            <br />

             
                 <div class="toLeft" style="width:45%">
                 <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="LoaiNhaO" DataSourceID="gridviewNhaOCongTrinhEntityDataSource" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand" Caption="Từ điển loại nhà ở - công trình">
                     <AlternatingRowStyle BackColor="White" />
                     <Columns>
                         <asp:BoundField DataField="LoaiNhaO" HeaderText="LoaiNhaO" ReadOnly="True" SortExpression="LoaiNhaO" Visible="False" />
                         <asp:BoundField DataField="Ten" HeaderText="Tên loại nhà ở - công trình" SortExpression="Ten" >
                         <ItemStyle Width="300px" />
                         </asp:BoundField>
                         <asp:CommandField ShowSelectButton="True" DeleteText="Xóa" InsertText="Thêm" NewText="Thêm" SelectText="Chọn" ShowCancelButton="False" />
                         <asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" />
                         <asp:CommandField InsertText="Thêm" NewText="Thêm" ShowCancelButton="False" ShowInsertButton="True" />
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
                 <asp:EntityDataSource ID="gridviewNhaOCongTrinhEntityDataSource" runat="server" ConnectionString="name=DMCWebEntities" DefaultContainerName="DMCWebEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="tblLoaiNhaO_CongTrinh">
                 </asp:EntityDataSource>
                 </div>
            
                <div class="toRight"  style="width:45%">
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="LoaiNhaO" DataSourceID="DetailViewNhaOCongTrinhEntityDataSource" DefaultMode="Insert" Height="50px" Width="125px" OnItemUpdated="DetailsView1_ItemUpdated" OnItemInserted="DetailsView1_ItemInserted" Caption="Thông tin chi tiết" CaptionAlign="Top" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <Fields>
                        <asp:BoundField DataField="LoaiNhaO" HeaderText="Mã số" ReadOnly="True" SortExpression="LoaiNhaO" />
                        <asp:BoundField DataField="Ten" HeaderText="Tên" SortExpression="Ten" />
                        <asp:CommandField ShowInsertButton="True" CancelText="Hủy" InsertText="Thêm" NewText="Thêm" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:CommandField>
                        <asp:CommandField CancelText="Hủy" EditText="Sửa" ShowEditButton="True" UpdateText="Sửa" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:CommandField>
                    </Fields>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                </asp:DetailsView>
                <asp:EntityDataSource ID="DetailViewNhaOCongTrinhEntityDataSource" runat="server" AutoGenerateWhereClause="True" ConnectionString="name=DMCWebEntities" DefaultContainerName="DMCWebEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="tblLoaiNhaO_CongTrinh" Where="">
                    <WhereParameters>
                        <asp:ControlParameter ControlID="GridView1" DbType="Int32" Name="LoaiNhaO" PropertyName="SelectedValue" />
                    </WhereParameters>
                </asp:EntityDataSource>
                </div>
            </div>

        

</asp:Content>
