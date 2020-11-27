<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="us_prodDetails.aspx.cs" Inherits="IWin.us_prodDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
                &nbsp;<asp:DataList ID="DataList1" runat="server" DataKeyField="product_id" DataSourceID="SqlDataSource1" OnItemCommand="DataList1_ItemCommand" ForeColor="White">
                <ItemTemplate>
                    <br />
                    <table style="width:100%;">
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
                                <asp:Image ID="Image1" runat="server" Height="300px" ImageUrl='<%# "~/images/" + Eval("Image") %>' Width="300px" />
                            </td>
                        </tr>
                    <div><asp:Button ID="Button1" class="" runat="server" CommandArgument='<%# Eval("product_id")%>' CommandName="addtocart" Height="30px"  Text="Buy Now" Width="100px" ForeColor="Black" />
                         </div>  &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                        <div><asp:Button ID="Button2" class="" runat="server" Height="30px"  Text="Go Back" Width="100px" ForeColor="Black" PostBackUrl="~/se_viewProd.aspx" />
                         </div>  
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
