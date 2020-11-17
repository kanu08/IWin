<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="email.aspx.cs" Inherits="IWin.email" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box">
    Name <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
  Email   <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
     <asp:Button ID="Button1" runat="server" Text="Verify" Onclick="Button1_Click" /></div></div></div></div>
</asp:Content>
