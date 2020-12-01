<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="us_Feedback.aspx.cs" Inherits="IWin.us_Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <link href="Content/star-rating.css" rel="stylesheet" />
    <link href="Content/rateit.css" rel="stylesheet" />
    <script src="Scripts/jquery.rateit.js"></script>
  <script type="text/javascript">
   //   var v = $('#customer_rating').rateit('value');
   
      function despite() {
          var v = $('#customer_rating').rateit('value');
          document.getElementById("<%= hdfRatingValue.ClientID %>").value = v;
         // alert(v);
      }

</script>
<div class="seller">
   
 <div class="row">
                  
    <div class="container">
   <div class="row clearfix">
   <div class="find-box">
       <br />
        <h1>GIVE US FEEDBACK</h1>
                      <br />
            <div class="adminform">
                  <div class="row">
                     <div class="col-sm-6" >
                               <asp:Label ID="lblSName" runat="server" Text="FeedBack Type"></asp:Label>&nbsp&nbsp
                             <asp:DropDownList ID="ddlFeedBack" runat="server" >
                              </asp:DropDownList>
                               <br />
                         </div> 
                        <div class="col-sm-6" >
                               <asp:Label ID="lblCmt" runat="server" Text="Describe Your FeedBack"></asp:Label><br/>
                            <asp:TextBox ID="txtTinyMCE" runat="server" TextMode="MultiLine" Height="108px" Width="257px"></asp:TextBox>
                             
                               <br />
                         </div> 
                </div>
                <div class="row">
                       <div class="col-sm-6" >
                               <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label><br/>
                            <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
                             
                               <br />
                         </div> 
                     <div class="col-sm-6" >
                               <asp:Label ID="lblRating" runat="server" Text="Rating"></asp:Label><br/>
                          <select id="backing3c">
    <option value="1">Bad</option>
    <option value="2">OK</option>
    <option value="3">Good</option>
    <option value="4">Great</option>
    <option value="5">Excellent</option>
</select>
<div class="rateit" data-rateit-backingfld="#backing3c" id="customer_rating" onclick="despite();" data-rateit-min="0"></div>
                               <br />
                         </div> 
                    </div>
                <div class="row">
                    <asp:Button id="input_2" runat="server" text="Submit Feedback" style="background-color: #18bd5b;border-color: #18bd5b;color: #fff;width:20%;" OnClick="input_2_Click"></asp:Button>
                   <br />
                     <asp:Label ID="lblmessage" runat="server" Visible="false"></asp:Label>
                     </div>
        </div>
      
   </div>
   </div>
   </div>
 </div>
     </div>
          <asp:HiddenField ID="hdfRatingValue" runat="server" />  
      
</asp:Content>
