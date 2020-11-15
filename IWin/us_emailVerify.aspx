<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="us_emailVerify.aspx.cs" Inherits="IWin.us_emailVerify" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div class="seller">
    <div class="container">
   <%--<div class="row clearfix">--%>
   <div class="find-box">
       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" ForeColor="#FFFFFF" ></asp:Label>
        <asp:Label ID="Label4" runat="server" ForeColor="#FFFFFF" ></asp:Label> 

       <asp:Button ID="Button1" runat="server" Text="Verify" Onclick="Button1_Click" />

       </div></div></div>
</asp:Content>
