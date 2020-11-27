<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="se_viewProd.aspx.cs" Inherits="IWin.se_viewProd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--contributed by lourdu--%>
     <div class="seller">
    <div class="container" >
   <%--<div class="row clearfix">--%>
<%--   <div class="find-box">--%>
    <div style="margin-top: 70px;margin-left:20px;margin-right:20px;">
            <br />
            <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblprod" runat="server" ForeColor="#FFFFFF" Text="Products" Font-Size="XX-Large" Font-Bold="true"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" ForeColor="#FFFFFF" Text="You have"></asp:Label>
            <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
&nbsp;<asp:Label ID="Label4" runat="server" ForeColor="#FFFFFF" Text="products in your cart"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Italic="False" NavigateUrl="~/AddToCart.aspx" ForeColor="White">Show Cart</asp:HyperLink>
            <br />
            <br />
<asp:DataList ID="DataList1" runat="server" BorderColor="#654321" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyField="product_id" DataSourceID="SqlDataSource1" GridLines="Both" OnItemCommand="DataList1_ItemCommand" RepeatColumns="5" RepeatDirection="Horizontal">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#ccbcaf" ForeColor="#8C4510" />
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>
                                <%--<asp:Label ID="Label4" runat="server" Text="Product ID"></asp:Label>
                                &nbsp;<asp:Label ID="Label5" runat="server" Text='<%# Eval("product_id") %>'></asp:Label>--%>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:ImageButton ID="Image1" runat="server" Height="200px" ImageUrl='<%# "~/images/" + Eval("Image") %>' Width="250px" CommandArgument='<%# Eval("product_id")%>' 
                                    CommandName="viewDetail"/>
                            </td>
                        </tr>
                       <%-- <tr>
                            <td>
                                <asp:Image ID="Imag" runat="server" Height="200px" Width="200px" OnClientClick="ProductDetail()" />
                            </td>
                        </tr>--%>
                        <tr>
                            <td>Price
                                <asp:Label ID="Label7" runat="server" Text='<%# Eval("price") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Quantity
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem Value="4"></asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("product_id")%>' 
                                    CommandName="addtocart" Height="50px" ImageUrl="~/images/addtocart.jpg" Width="100px" />
                            </td>
                        </tr>
                    </table>
                    <br />
                </ItemTemplate>
                <SelectedItemStyle BackColor="#aa917c" Font-Bold="True" ForeColor="White" />
            </asp:DataList>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:iwinConn %>" SelectCommand="SELECT * FROM [tbl_lookup_product]"></asp:SqlDataSource>
            <br />
        </div>
       </div></div><%--</div></div>--%>
</asp:Content>
