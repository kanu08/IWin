<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="us_emailVerify.aspx.cs" Inherits="IWin.us_emailVerify" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box">
       <br />
         <h1>Email Verification</h1>
                      <br />
       <div class="adminform">
       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp
    <asp:Label ID="Label3" runat="server" ForeColor="Black" ></asp:Label><br />
        <asp:Label ID="Label4" runat="server" ForeColor="Green" ></asp:Label> <br /><br />

       <asp:Button ID="btnVerifyOtp" runat="server" Text="Verify" Onclick="btnVerifyOtp_Click" />
           <asp:Button ID="btnToProfile" runat="server" Text="Go To Profile" Onclick="btnToProfile_Click" />
   </div></div></div></div></div>
</asp:Content>
