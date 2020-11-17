<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewDetails.aspx.cs" Inherits="ViewDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 260px;
        }
        .auto-style2 {
            height: 70px;
            text-align: center;
        }
        .auto-style3 {
            height: 57px;
            text-align: center;
        }
        .auto-style4 {
            height: 94px;
            text-align: center;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            text-align: center;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            IWIN</p>
        <p>
            &nbsp;</p>
        <p>
            Product Details
        </p>
        <p>
            &nbsp;<asp:DataList ID="DataList1" runat="server" DataKeyField="product_id" DataSourceID="SqlDataSource1" OnItemCommand="DataList1_ItemCommand">
                <ItemTemplate>
                    <br />
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text='<%# Eval("product_Name") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">Product ID :
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("product_id") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Price :
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("product_price") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Description : Product of Canada. Farm fresh. </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("product_id")%>' CommandName="addtocart" Height="48px" OnClick="Button1_Click" Text="Buy Now" Width="139px" />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </p>
        <p>
            &nbsp;</p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:iwinConnectionString %>" SelectCommand="SELECT * FROM [tbl_lookup_product] WHERE ([product_id] = @product_id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="product_id" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
