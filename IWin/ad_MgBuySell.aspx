<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_MgBuySell.aspx.cs" Inherits="IWin.ad_MgBuySell" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="seller">
 <div class="row">
 <!-- Sidebar -->
 <div id="sidebar-wrapper">
 <ul class="sidebar-nav">
 <li><a runat="server" href="~/us_registeration.aspx" style="color:white;padding-bottom:8px;">Add Buyer</a></li>
 <li><a runat="server" href="~/" style="color:white;padding-bottom:8px;">View/Edit Buyer</a></li>
 <li><a runat="server" href="~/ad_addSeller.aspx" style="color:white;padding-bottom:8px;">Add Seller</a></li>
 <li><a runat="server" href="~/" style="color:white;padding-bottom:8px;">View/Edit Seller</a></li>
<li><a runat="server" href="~/ad_suggestSeller" style="color:white;padding-bottom:8px;">Suggest/Wish a Seller</a></li>
 </ul></div>
    <div class="container">
   <div class="row clearfix">
   <div class="find-box">
       <br />
                      <br />
            <div class="adminform">
                  <div class="row">
                         <h2>choose an operation to continue</h2>
                </div>
        </div>

   </div>
   </div>
   </div>
 </div>
     </div>
</asp:Content>
