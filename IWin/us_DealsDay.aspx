<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="us_DealsDay.aspx.cs" Inherits="IWin.us_DealsDay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div>
           
        
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" ForeColor="#000099" Text="IWIN"></asp:Label>
  </div>
        <asp:Label ID="Label1" runat="server" Text="DEALS OF THE DAY" Font-Bold="True" Font-Italic="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" EnableTheming="True" ForeColor="#990000"></asp:Label>
           
<div id="myCarousel" class="carousel slide" data-ride="carousel" data-interval="2000">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
      <li data-target="#myCarousel" data-slide-to="3"></li>
      <li data-target="#myCarousel" data-slide-to="4"></li>
     
    
  </ol>

  <!-- Wrapper for slides -->
  <div class="carousel-inner">
    <div class="item active">
      <img src="images/pic1.jpg" alt="groceries">
    </div>

    <div class="item">
      <img src="images/pic2.jpg" alt="fruits">
    </div>

    <div class="item">
      <img src="images/pic3.jpg" alt="bakery">
    </div>
         <div class="item">
      <img src="images/pic4.jpg" alt="bakery">
    </div>
    <div class="item">
      <img src="images/pic5.jpg" alt="bakery">
    </div>
      
  </div>

  <!-- Left and right controls -->
  <a class="left carousel-control" href="#myCarousel" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#myCarousel" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right"></span>
    <span class="sr-only">Next</span>
  </a>
</div>

</asp:Content>
