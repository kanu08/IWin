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
                               <asp:TextBox ID="txtUName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfv_txtUName" runat="server" ErrorMessage="!" Font-Bold="true" ForeColor="Red" ControlToValidate="txtUName"></asp:RequiredFieldValidator>
                               <br />
                               <br />
                               <br />
                        </div> 
                        <div class="col-sm-6">
                              <asp:Button ID="Verify" runat="server" Text="Click here to verify your email" Width="220px" OnClick="Verify_Click" />
                        </div>
                  </div>
                  <div class="row">
                        <div class="col-sm-6">
                               <asp:Label ID="lblUCont" runat="server" Text="Contact"></asp:Label>&nbsp&nbsp
                               <asp:TextBox ID="txtUCont" runat="server"></asp:TextBox><br />
                               <br /><br />
                         </div> 
                       <div class="col-sm-6">
                               <asp:Label ID="lblUPin" runat="server" Text="PinCode"></asp:Label>&nbsp&nbsp
                               <asp:DropDownList ID="ddlPinCode" runat="server" >
                               </asp:DropDownList> <br /><br />
                               <asp:Label ID="lblUCity" runat="server" ></asp:Label>
                               <br />
                         </div> 
                      </div>
                      <div class="row">
                            <div class="col-sm-12">
                              <div class="center">
                              <asp:Button ID="btn_editProfile" runat="server" Text="Edit" OnClick="btn_editProfile_Click" />&nbsp&nbsp
                              <asp:Button ID="btn_clearEdit" runat="server" Text="Clear" OnClientClick="reset();" CausesValidation=False/>
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
