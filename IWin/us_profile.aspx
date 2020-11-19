<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="us_profile.aspx.cs" Inherits="IWin.us_profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="seller">
   <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
         <h1>Your profile</h1>
                      <br />
            <div class="adminform">
                  <div class="row">
                        <div class="col-sm-6">
                               <asp:Label ID="lblUName" runat="server" Text="Username"></asp:Label>&nbsp&nbsp
                               <asp:TextBox ID="txtUName" runat="server"></asp:TextBox><br />
                               <br /><br />
                         </div> <div class="col-sm-6">
                              <asp:Button ID="Verify" runat="server" Text="Click here to verify your email" Width="220px" />
                         </div>
                  </div>
                      <div class="row">
                            <div class="col-sm-12">
                              <div class="center">
                              <asp:Button ID="btn_saveSubCat" runat="server" Text="Save" OnClick="btn_saveSubCat_Click"/>&nbsp&nbsp
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
</asp:Content>
