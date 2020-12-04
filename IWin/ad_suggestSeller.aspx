<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_suggestSeller.aspx.cs" Inherits="IWin.ad_suggestSeller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
        <h1>Send Suggestion/Wishes</h1>
                      <br />
            <div class="adminform">
                  <div class="row">
                       <div class="col-sm-6">
                              <asp:Label ID="Label1" runat="server" Text="Choices"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                            <asp:DropDownList ID="ddlChoices" runat="server" OnSelectedIndexChanged="ddlChoices_SelectedIndexChanged" AutoPostBack="True" >
                                <asp:ListItem Value="0">Select Choices</asp:ListItem>
                                <asp:ListItem Value="1">To All Sellers</asp:ListItem>
                                <asp:ListItem Value="2">To All Sellers of a Particular Pincode</asp:ListItem>
                                <asp:ListItem Value="3">To a Particular Sellers</asp:ListItem>                                
                              </asp:DropDownList>
                               <br /><br />
                         </div>
                      <div class="col-sm-6">
                          <asp:Label ID="lbltypes" runat="server" Text="Types"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                           <asp:DropDownList ID="ddlTypes" runat="server" >
                                <asp:ListItem Value="0">Select Type</asp:ListItem>
                                <asp:ListItem Value="1">Wishes</asp:ListItem>
                                <asp:ListItem Value="2">Any Product</asp:ListItem>
                                <asp:ListItem Value="3">Scheduled Maintenance</asp:ListItem>
                                <asp:ListItem Value="4">Something Suspicious</asp:ListItem>
                                <asp:ListItem Value="5">Others</asp:ListItem>                                
                              </asp:DropDownList>
                               <br /><br />
                            
                          </div>
                  </div>
                <div class="row">
                    <div class="col-sm-4">
                     <asp:Label ID="lblCmt" runat="server" Text="Describe"></asp:Label><br/>
                            <asp:TextBox ID="txtTinyMCE" runat="server" TextMode="MultiLine" Height="108px" Width="257px"></asp:TextBox>
                           </div>
                     <div class="col-sm-4">
                          <asp:Label ID="lblPincode" runat="server" Text="PinCode"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                           <asp:DropDownList ID="ddlPinCode" runat="server" >
                                 </asp:DropDownList>
                               <br /><br />
                            
                          </div>
                    <div class="col-sm-4">
                          <asp:Label ID="lblSeller" runat="server" Text="Seller Id"></asp:Label>
                            <asp:TextBox ID="txtSeller" runat="server"></asp:TextBox>
                    
                        </div>
                 
                    </div>
                      <div class="row">
                            <div class="col-sm-12">
                              <div class="center">
                              <asp:Button ID="btn_saveSubCat" runat="server" Text="Send" OnClick="btn_saveSubCat_Click"/>&nbsp&nbsp
                              <asp:Button ID="btn_clearCat" runat="server" Text="Clear" OnClientClick="reset();" CausesValidation=False/>
                              </div>
                          </div>
                          <div class="col-sm-12">
                              <div class="center">
                              <asp:Label class="lblsuccess" ID="lblmessage" runat="server" Text="" Visible="false">
                              </asp:Label>
                              </div>
                      </div>
                          </div>
                      </div>
                      <br />
                </div>
        </div>
        </div>
        </div>
   <%-- <script>
        <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>
    </script>--%>

</asp:Content>
