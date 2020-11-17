<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox ID="txtuser" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtpass" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Select User Type</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>Buyer</asp:ListItem>
                            <asp:ListItem>Seller</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="login" OnClick="Button1_Click" /></td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
