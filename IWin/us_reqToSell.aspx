<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="us_reqToSell.aspx.cs" Inherits="IWin.us_reqToSell" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        
<div class="seller">
   
 <div class="row">
                  
    <div class="container">
   <div class="row clearfix">
   <div class="find-box">
       <br />
        <h1>Request to become seller</h1>
                      <br />
            <div class="adminform">
                  <div class="row">
                     <div class="col-sm-4">
                               <asp:Label ID="lblSName" runat="server" Text="Store/Seller Display Name"></asp:Label>
                            <asp:TextBox ID="txtSellerName" runat="server"></asp:TextBox>
                               <br />
                         </div> 
                       <div class="col-sm-4">
                           <asp:Label ID="Label1" runat="server" Text="Seller Image"></asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                               <br />
                       </div>
                      <div class="col-sm-4">
                          <asp:Label ID="Label2" runat="server" Text="Seller Province"></asp:Label>
                            <asp:TextBox ID="txtProvience" runat="server"></asp:TextBox>
                               <br />
                      </div>
                </div>
                <div class="row">
                     <div class="col-sm-4">
                               <asp:Label ID="lblCmt" runat="server" Text="Seller Address"></asp:Label><br/>
                            <asp:TextBox ID="txtTinyMCE" runat="server" TextMode="MultiLine" Height="108px" Width="180px"></asp:TextBox>                             
                               <br />
                         </div>
                    <div class="col-sm-4">
                        <asp:Label ID="Label3" runat="server" Text="Seller Pin"></asp:Label> <br />
                            <asp:TextBox ID="txtPin" runat="server"></asp:TextBox>
                               <br />
                    </div> 
                    <div class="col-sm-4">
                        <asp:Label ID="Label4" runat="server" Text="Seller Contact"></asp:Label>
                            <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
                               <br />
                    </div> 
                </div>
              
                <div class="row">
                    <br/>
                    <asp:Button id="input_2" runat="server" text="Send" style="background-color: #18bd5b;border-color: #18bd5b;color: #fff;width:20%;" OnClick="input_2_Click"></asp:Button>
                   <br />
                     <asp:Label ID="lblmessage" runat="server" Visible="false"></asp:Label>
                     </div>
        </div>
      
   </div>
   </div>
   </div>
 </div>
     </div>
</asp:Content>
