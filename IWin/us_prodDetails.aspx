<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="us_prodDetails.aspx.cs" Inherits="IWin.us_prodDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
                &nbsp;<asp:DataList ID="DataList1" runat="server" DataKeyField="product_id" DataSourceID="SqlDataSource1" OnItemCommand="DataList1_ItemCommand">
                <ItemTemplate>
                    <br />
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text='<%# Eval("Name") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">Product ID :
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("product_id") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Price :
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("price") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Description : Product of Canada. Farm fresh. </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("product_id")%>' CommandName="addtocart" Height="48px"  Text="Buy Now" Width="139px" />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        
        <p>
            &nbsp;</p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings: iwinConn %>" SelectCommand="SELECT * FROM [tbl_lookup_product] WHERE ([product_id] = @product_id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="product_id" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource></div></div></div></div>
</asp:Content>
