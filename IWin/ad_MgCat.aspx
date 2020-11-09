<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_MgCat.aspx.cs" Inherits="IWin.ad_mngCat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="seller">
 <div class="row">
 <!-- Sidebar -->
 <div id="sidebar-wrapper">
 <ul class="sidebar-nav">
 <li><a runat="server" href="~/ad_addCat.aspx" style="color:white;padding-bottom:8px;">Add Category</a></li>
 <li><a runat="server" href="~/" style="color:white;padding-bottom:8px;">View/Edit Category</a></li>
 <li><a runat="server" href="~/ad_addSubcat.aspx" style="color:white;padding-bottom:8px;">Add SubCategory</a></li>
 <li><a runat="server" href="~/" style="color:white;padding-bottom:8px;">View/Edit SubCategory</a></li>
 <li><a runat="server" href="~/ad_addProduct.aspx" style="color:white;padding-bottom:8px;">Add Product</a></li>
 <li><a runat="server" href="~/" style="color:white;padding-bottom:8px;">View/Edit Product</a></li>
 <li><a runat="server" href="~/ad_addBrand.aspx" style="color:white;padding-bottom:8px;">Add Brand</a></li>
 <li><a runat="server" href="~/" style="color:white;padding-bottom:8px;">View/Edit Brand</a></li>
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
