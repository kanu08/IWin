<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 72px;
            text-align: center;
            background-color: #FF0000;
        }
        .auto-style3 {
            height: 62px;
            text-align: center;
            background-color: #FF0000;
        }
        .auto-style4 {
            height: 83px;
            text-align: center;
            background-color: #FF0000;
        }
        .auto-style5 {
            height: 96px;
            text-align: center;
            background-color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            IWIN</p>
        <p>
            Product Page</p>
        <asp:DataList ID="DataList1" runat="server" BorderStyle="Ridge" DataKeyField="product_id" DataSourceID="SqlDataSource1" OnItemCommand="DataList1_ItemCommand" RepeatColumns="2" RepeatDirection="Horizontal">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">Product ID :
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("product_id") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("product_Name") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("product_id")%>' CommandName="addtocart" Height="47px" OnClick="Button1_Click" Text="Add To Cart" Width="123px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Button ID="Button2" runat="server" CommandArgument='<%# Eval("product_id")%>' CommandName="viewdetails" Height="47px" OnClick="Button1_Click" Text="View Details" Width="123px" />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:iwinConnectionString %>" SelectCommand="SELECT * FROM [tbl_lookup_product]"></asp:SqlDataSource>
    </form>
</body>
</html>
