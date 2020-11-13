<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="mainProdview.aspx.cs" Inherits="IWin.mainProdview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="product_id" DataSourceID="SqlDataSource1" ShowFooter="True">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:TemplateField HeaderText="product_id" SortExpression="product_id">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("product_id") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("product_id") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:LinkButton ValidationGroup="INSERT" ID="lbInsert" runat="server">Insert</asp:LinkButton>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="product_Name" SortExpression="product_Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("product_Name") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEditName" runat="server" ErrorMessage="Name is a Required Field"
	                        ControlToValidate="TextBox1" Text="*" ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("product_Name") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvInsertName" runat="server" ErrorMessage="Name is a Required Field"
	                        ControlToValidate="txtName" ValidationGroup="INSERT" Text="*" ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="category_id" SortExpression="category_id">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("category_id") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEditCatid" runat="server" ErrorMessage="ID is a Required Field"
	                        ControlToValidate="TextBox2" Text="*" ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("category_id") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtcatid" runat="server"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rfvInsertCatid" runat="server" ErrorMessage="ID is a Required Field"
	                        ControlToValidate="txtcatid" ValidationGroup="INSERT" Text="*" ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="product_price" SortExpression="product_price">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("product_price") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEditProprice" runat="server" ErrorMessage="Price is a Required Field"
	                        ControlToValidate="TextBox3" Text="*" ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("product_price") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtproprice" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvInsertProprice" runat="server" ErrorMessage="Price is a Required Field"
	                        ControlToValidate="txtproprice" ValidationGroup="INSERT" Text="*" ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:ValidationSummary ValidationGroup="INSERT" ID="ValidationSummary1" ForeColor="Red" runat="server" />
        <asp:ValidationSummary ID="ValidationSummary2" ForeColor="Red" runat="server" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:iwinConnectionString %>" DeleteCommand="DELETE FROM [tbl_lookup_product] WHERE [product_id] = @product_id" InsertCommand="INSERT INTO [tbl_lookup_product] ([product_id], [product_Name], [category_id], [product_price]) VALUES (@product_id, @product_Name, @category_id, @product_price)" SelectCommand="SELECT [product_id], [product_Name], [category_id], [product_price] FROM [tbl_lookup_product]" UpdateCommand="UPDATE [tbl_lookup_product] SET [product_Name] = @product_Name, [category_id] = @category_id, [product_price] = @product_price WHERE [product_id] = @product_id">
            <DeleteParameters>
                <asp:Parameter Name="product_id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="product_id" Type="Int32" />
                <asp:Parameter Name="product_Name" Type="String" />
                <asp:Parameter Name="category_id" Type="Int32" />
                <asp:Parameter Name="product_price" Type="Double" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="product_Name" Type="String" />
                <asp:Parameter Name="category_id" Type="Int32" />
                <asp:Parameter Name="product_price" Type="Double" />
                <asp:Parameter Name="product_id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
</asp:Content>
