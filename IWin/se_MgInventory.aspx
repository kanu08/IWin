<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="se_MgInventory.aspx.cs" Inherits="IWin.se_MgInventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box">
       <br />
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1"
           AllowSorting="True"  BackColor="White" BorderColor="#DEDFDE" 
           BorderStyle="None" BorderWidth="1px" CellPadding="4" 
         ForeColor="Black" GridLines="Vertical" ShowHeaderWhenEmpty="true"  >
           <Columns>
               <asp:CommandField ShowEditButton="True" />
               <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
               <asp:BoundField DataField="SellId" HeaderText="SellId" SortExpression="SellId" />
               <asp:BoundField DataField="mqu_id" HeaderText="mqu_id" SortExpression="mqu_id" />
               <asp:BoundField DataField="sno" HeaderText="sno" SortExpression="sno" />
               <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
               <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
               <asp:BoundField DataField="Brand_Name" HeaderText="Brand_Name" SortExpression="Brand_Name" />
               <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
               <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
               <asp:BoundField DataField="UOM_Desc" HeaderText="UOM_Desc" SortExpression="UOM_Desc" />
               <asp:TemplateField HeaderText="Your Price" SortExpression="sellPrice">
                   <EditItemTemplate>
                       <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("sellPrice") %>'></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("sellPrice") %>'></asp:TextBox>
                       <asp:Label ID="Label1" runat="server" Text='<%# Bind("sellPrice") %>'></asp:Label>
                   </ItemTemplate>
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Quantity/Units" SortExpression="sellQty">
                   <EditItemTemplate>
                       <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("sellQty") %>'></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label2" runat="server" Text='<%# Bind("sellQty") %>'></asp:Label>
                       <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("sellQty", "{0:N}") %>'></asp:TextBox>
                   </ItemTemplate>
               </asp:TemplateField>
           </Columns>
               <FooterStyle BackColor="#CCCC99" />
           <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
           <RowStyle BackColor="#F7F7DE" />
           <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
           <SortedAscendingCellStyle BackColor="#FBFBF2" />
           <SortedAscendingHeaderStyle BackColor="#848384" />
           <SortedDescendingCellStyle BackColor="#EAEAD3" />
           <SortedDescendingHeaderStyle BackColor="#575357" />
       </asp:GridView>
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:iwinConn %>" SelectCommand=" SELECT tbl_Seller_Inventory.Id, tbl_Seller_Inventory.SellId, tbl_Seller_Inventory.mqu_id,  v_allProductsWithMRP.sno, v_allProductsWithMRP.Name, v_allProductsWithMRP.Image, 
 v_allProductsWithMRP.Brand_Name, v_allProductsWithMRP.price, v_allProductsWithMRP.quantity, 
                  v_allProductsWithMRP.UOM_Desc,tbl_Seller_Inventory.sellPrice, 
 tbl_Seller_Inventory.sellQty
FROM     tbl_Seller_Inventory LEFT OUTER JOIN
                  v_allProductsWithMRP ON v_allProductsWithMRP.sno = tbl_Seller_Inventory.mqu_id 
WHERE  (tbl_Seller_Inventory.SellId = @Sid)" UpdateCommand="sp_Admin_AddCategory" UpdateCommandType="StoredProcedure">
           <SelectParameters>
               <asp:SessionParameter name="Sid" SessionField="Si" Type="Int16" />
           </SelectParameters>
           <UpdateParameters>
               <asp:Parameter Name="In_CategoryName" Type="String" />
               <asp:Parameter Name="IN_CategoryID" Type="Int32" />
               <asp:Parameter Name="OP" Type="Int32" />
           </UpdateParameters>
       </asp:SqlDataSource>
       <br /><br />
       <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>



       </div></div></div></div>
</asp:Content>
