<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DualAccountLogin.aspx.cs" Inherits="DualAccountLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

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
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Value="1">Buyer</asp:ListItem>
                            <asp:ListItem Value="2">Seller</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="login" OnClick="Button1_Click" /></td>
                </tr>
                </table>
        </div>

</asp:Content>

