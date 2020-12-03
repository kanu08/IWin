<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PlaceOrder.aspx.cs" Inherits="PlaceOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 32%;
            height: 148px;
            margin-bottom: 0px;
        }
        .auto-style2 {
            width: 149px;
        }
        .auto-style3 {
            width: 34%;
            height: 296px;
            background-color: #FFFF99;
        }
        .auto-style4 {
            width: 218px;
            height: 9px;
        }
        .auto-style5 {
            text-align: center;
            height: 9px;
        }
        .auto-style6 {
            width: 218px;
            height: 276px;
        }
        .auto-style7 {
            height: 276px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Place order"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#0066FF" Text="Checkout in Shopping cart"></asp:Label>
            <br />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Order ID</td>
                    <td>
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Order Date</td>
                    <td>
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="40px" ShowFooter="True" Width="651px">
            <Columns>
                <asp:BoundField DataField="sno" HeaderText="S.No" />
                <asp:BoundField DataField="product_id" HeaderText="Product ID" />
                <asp:BoundField DataField="product_Name" HeaderText="Product Name" />
                <asp:BoundField DataField="product_price" HeaderText="Price" />
                <asp:BoundField DataField="quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="totalprice" HeaderText="Total price" />
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
        <br />
        <br />
        <table border="1" class="auto-style3">
            <tr>
                <td class="auto-style6">Please type your address</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox1" runat="server" Height="152px" TextMode="MultiLine" Width="305px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Mobile number</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server" Height="32px" Width="279px"></asp:TextBox>
                    <br />
                    <br />
                </td>
            </tr>
        </table>
        <p>
            <asp:Button ID="Button1" runat="server" BorderColor="#FF6666" Height="55px" OnClick="Button1_Click" Text="Place Order" Width="185px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
