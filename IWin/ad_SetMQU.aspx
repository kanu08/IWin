<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_SetMQU.aspx.cs" Inherits="IWin.ad_SetMQU" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box">
       <br />
<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:iwinConn %>" SelectCommand="SELECT [UOM_Id],[UOM_Desc] FROM [tbl_lookup_UOM]"></asp:SqlDataSource>
       <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" 
           BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" 
         ForeColor="Black" GridLines="Vertical" ShowFooter="true" ShowHeaderWhenEmpty="true"  OnRowDataBound="GridView1_RowDataBound" >
           <AlternatingRowStyle BackColor="White" /> 
           <Columns>
               <%--<asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" InsertVisible="False" ReadOnly="True" />--%>
               <asp:TemplateField HeaderText="Id" SortExpression="price" InsertVisible="False" >
                   <FooterTemplate>
                       <asp:Button ID="AddMqu" runat="server" CommandName="Insert" Text="Add" ValidationGroup="vg_Add" />
                   </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="lblId" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
            </ItemTemplate>
        
        </asp:TemplateField>
               <asp:BoundField DataField="product_id" visible="false" SortExpression="product_id"/>
               <%--<asp:BoundField DataField="price" HeaderText="MRP" SortExpression="price" visible="false"/>--%>
            <asp:TemplateField HeaderText="MRP" SortExpression="price" >
            <EditItemTemplate>
                <asp:TextBox ID="Price" runat="server" Text='<%# Bind("price") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblPrice" runat="server" Text='<%# Eval("price") %>'></asp:Label>
            </ItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="txtPrice" runat="server" />
            </FooterTemplate>
        </asp:TemplateField>
               <%--<asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />--%>
               <asp:TemplateField HeaderText="Quantity" SortExpression="quantity" >
            <EditItemTemplate>
                <asp:TextBox ID="Quantity" runat="server" Text='<%# Bind("quantity") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblQty" runat="server" Text='<%# Eval("quantity") %>'></asp:Label>
            </ItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="txtQty" runat="server" />
            </FooterTemplate>
        </asp:TemplateField>
              <asp:BoundField DataField="UOM_id" SortExpression="UOM_id" visible="false"/>
      <%--         <asp:BoundField DataField="UOM_Desc" visible="false" SortExpression="UOM_Desc"/>--%>
                <asp:TemplateField HeaderText="UOM"  SortExpression="UOM_Desc">
                            <ItemTemplate>
                                <asp:Label ID="lblUOM" runat="server" Text='<%# Eval("UOM_Desc")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                        <asp:DropDownList ID="ddlUOM" runat="server" DataSourceID="SqlDataSource2"
                      DataTextField="UOM_Desc"
                      DataValueField="UOM_id"
                      SelectedValue='<%# Bind("UOM_id") %>'>
                                </asp:DropDownList>
                            </EditItemTemplate>
                      <FooterTemplate>
                  <asp:DropDownList ID="ddlUOMi" runat="server" DataSourceID="SqlDataSource2"
                      DataTextField="UOM_Desc"
                      DataValueField="UOM_Id"
                      AppendDataBoundItems="true" >
                    <items>
                    <asp:ListItem Text="choose" Value="0" Selected="True"></asp:ListItem></items>
             </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfv_ddlUOMi" runat="server" ErrorMessage="*please enter UOM" ControlToValidate="ddlUOMi" 
                Display="Dynamic" ForeColor="#CC0000" Font-Size="XX-Small" SetFocusOnError="True" InitialValue="0" 
                ValidationGroup="vg_Add"></asp:RequiredFieldValidator>         
                    </FooterTemplate>
                        </asp:TemplateField>
                <asp:CommandField ShowEditButton="true" />  
                <asp:CommandField ShowDeleteButton="true" /> 
              
           </Columns>
          <EmptyDataTemplate>
               There are no results to show
         
           </EmptyDataTemplate>
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
           SelectCommand="SELECT tbl_lookup_mqu.Id, tbl_lookup_mqu.product_id, tbl_lookup_mqu.price, tbl_lookup_mqu.quantity, tbl_lookup_mqu.UOM_id, tbl_lookup_UOM.UOM_Desc FROM tbl_lookup_mqu LEFT OUTER JOIN tbl_lookup_UOM ON tbl_lookup_mqu.UOM_id = tbl_lookup_UOM.UOM_Id WHERE (tbl_lookup_mqu.product_id = @prodid)" 
           DeleteCommand="DELETE FROM tbl_lookup_mqu WHERE (Id = @Id)"
           InsertCommand="INSERT INTO tbl_lookup_mqu VALUES(@prodid,@price,@quantity,@UOM_id)" 
           UpdateCommand="UPDATE tbl_lookup_mqu SET price = @Price, quantity = @Quantity, 
           UOM_id = @UOM_id WHERE (Id=@Id)">
           <DeleteParameters>
               <asp:Parameter Name="Id" />
           </DeleteParameters>
           <InsertParameters>
                <asp:Parameter Name="prodid" type="String"/>
                <asp:Parameter Name="price" Type="String"/>
                <asp:Parameter Name="quantity" Type="String"/>
                <asp:Parameter Name="UOM_id" Type="String"/>
<%--              <asp:QueryStringParameter DefaultValue="0" Name="prodid" QueryStringField="id" Type="Int16" />
              <asp:ControlParameter ControlID="txtPrice" Name="Price" PropertyName="Text" />
              <asp:ControlParameter ControlID="txtQty" Name="Quantity" PropertyName="Text" />--%>
               <%--<asp:ControlParameter ControlID="ddlUOMi" Name="UOM_id" />--%>
           </InsertParameters>
           <SelectParameters>
               <asp:QueryStringParameter DefaultValue="0" Name="prodid" QueryStringField="id" Type="Int16" />
    </SelectParameters>
           <UpdateParameters>
               <asp:Parameter Name="Price" />
               <asp:Parameter Name="Quantity" />
               <asp:Parameter Name="uOM_id" />
               <asp:Parameter Name="Id" />
           </UpdateParameters>
       </asp:SqlDataSource>
       
   <br /><br /><br />
      <div id="newM" runat="server" visible="false" >
            <table id="et" BackColor="#F7F7DE" Width="80%" BorderColor="#DEDFDE" 
           BorderStyle="None" BorderWidth="1px" CellPadding="4" >
            <tr>
             <td style="width: 58px">
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="InsertNewMqu"   ValidationGroup="vg_Add2" />
            </td>
            <td style="width: 100px"><asp:TextBox ID="txtPrice2" runat="server" ></asp:TextBox></td>
            <td style="width: 100px">              
               <asp:TextBox ID="txtQty2" runat="server"></asp:TextBox>
            </td>
             <td style="width: 100px">              
            <asp:DropDownList ID="ddlUOMi2" runat="server" DataSourceID="SqlDataSource2"
                      DataTextField="UOM_Desc"
                      DataValueField="UOM_Id"
                      AppendDataBoundItems="true" >
                    <items>
                    <asp:ListItem Text="choose" Value="0" Selected="True"></asp:ListItem></items>
             </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfv_ddlUOMi" runat="server" ErrorMessage="*please enter UOM" ControlToValidate="ddlUOMi2" 
                Display="Dynamic" ForeColor="#CC0000" Font-Size="XX-Small" SetFocusOnError="True" InitialValue="0" 
                ValidationGroup="vg_Add2"></asp:RequiredFieldValidator>        
            </td>
            
        </tr>
        </table>
      </div>
       
   
   </div></div></div></div>

</asp:Content>
