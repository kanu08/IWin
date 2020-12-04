<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="se_Reports.aspx.cs" Inherits="IWin.se_Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="seller">
    <div class="container">
  <div class="row clearfix">
   <div class="find-box">
      <asp:Button ID="btnCR" runat="server" Text="Raise a change request" Height="40px" Width="200px" PostBackUrl="~/se_reqChange.aspx" />
       <br />

  <asp:Label ID="lblrep" runat="server" ForeColor="White" Text="For Seller to see history of order accepted" Font-Size="Medium"  ></asp:Label>
       </div></div></div></div>
</asp:Content>
