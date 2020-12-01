<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="se_MgInventory.aspx.cs" Inherits="IWin.se_MgInventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="seller">
    <div class="container">
   <div class="row clearfix"><br /><br /><br /><br /><br />
<%--<div class="find-box">--%>
       
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1"
           AllowSorting="True"  BackColor="White" BorderColor="#DEDFDE" 
           BorderStyle="None" BorderWidth="1px" CellPadding="2" 
         ForeColor="Black" GridLines="Vertical" ShowHeaderWhenEmpty="True" Width="80%" style="margin-left:50px;" OnRowCommand="GridView1_RowCommand">
           <Columns>
               <asp:TemplateField ShowHeader="False">
                   <EditItemTemplate>
                       <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Text="Update"></asp:LinkButton>
                       &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                   </ItemTemplate>
               </asp:TemplateField>
               <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" Visible="false"/>
               <asp:BoundField DataField="SellId" HeaderText="SellId" SortExpression="SellId" Visible="false"/>
              <%-- <asp:BoundField DataField="mqu_id" HeaderText="mqu_id" SortExpression="mqu_id" Visible="false"/>--%>
               <asp:TemplateField HeaderText="mqu" SortExpression="mqu_id">
            <ItemTemplate>
                <asp:HiddenField ID="HiddenField1" runat="server" 
                    Value='<%# Eval("mqu_id") %>' />
            </ItemTemplate>
        </asp:TemplateField>
<%--               <asp:BoundField DataField="sno" HeaderText="sno" SortExpression="sno" ReadOnly="True"/>--%>
               <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" ReadOnly="True"/>
               <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" Visible="false"/>
               <asp:BoundField DataField="Brand_Name" HeaderText="Brand_Name" SortExpression="Brand_Name" ReadOnly="True"/>
               <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" ReadOnly="True"/>
               <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" ReadOnly="True"/>
               <asp:BoundField DataField="UOM_Desc" HeaderText="UOM_Desc" SortExpression="UOM_Desc" ReadOnly="True"/>
               <asp:TemplateField HeaderText="Your Price" SortExpression="sellPrice">
                   <EditItemTemplate>
                       <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("sellPrice") %>'></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
<%--                       <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("sellPrice") %>'></asp:TextBox>--%>
                       <asp:Label ID="Label1" runat="server" Text='<%# Bind("sellPrice") %>'></asp:Label>
                   </ItemTemplate>
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Quantity/Units" SortExpression="sellQty">
                   <EditItemTemplate>
                       <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("sellQty") %>'></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label2" runat="server" Text='<%# Bind("sellQty") %>'></asp:Label>
<%--                       <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("sellQty", "{0:N}") %>'></asp:TextBox>--%>
                   </ItemTemplate>
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Do you Sell?" >
                   <ItemTemplate>
                       <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# GetAv(Eval("sellPrice").ToString(),Eval("sellQty").ToString()) %>' Enabled="false"/>
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
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:iwinConn %>" 
           SelectCommand="
           SELECT * FROM (SELECT v_ProductListOrderBySeller.Id, v_ProductListOrderBySeller.SellId, v_ProductListOrderBySeller.mqu_id,  
            v_ProductListOrderBySeller.Name,
 v_ProductListOrderBySeller.Image, 
 v_ProductListOrderBySeller.Brand_Name, v_ProductListOrderBySeller.price, v_ProductListOrderBySeller.quantity, 
                  v_ProductListOrderBySeller.UOM_Desc,v_ProductListOrderBySeller.sellPrice, 
 v_ProductListOrderBySeller.sellQty,
           ROW_NUMBER() OVER(PARTITION BY mqu_id ORDER BY SellId DESC) rn
FROM  v_ProductListOrderBySeller where (v_ProductListOrderBySeller.SellId=@Sid OR v_ProductListOrderBySeller.SellId IS NULL)) a where rn=1
           ">
           <SelectParameters>
             <asp:SessionParameter name="Sid" SessionField="Si" Type="Int16" />
           </SelectParameters>
         
       </asp:SqlDataSource>
       <br /><br />

       <asp:Label ID="Label4" runat="server" ForeColor="White"></asp:Label>
       </div></div></div>
 <%--  </div>--%>
</asp:Content>
