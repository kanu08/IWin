<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="se_register.aspx.cs" Inherits="IWin.se_register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box">
       <br />
         <h1>Register as a Seller</h1>
                      <br />
      <div class="adminform"><br />
          <div class="row">
                  <div class="col-sm-12">
                        <asp:Label ID="lblDisc" runat="server" ForeColor="Black" Text="Before entering your details here, please make sure that your details are approved by admin."></asp:Label><a href="se_faq.aspx">See here</a><br />
                 </div><br /><br />
           </div>
          <div class="row">
               <div class="col-sm-3">
                   <asp:Label ID="lblDtlId" runat="server" Text="Detail Id"></asp:Label><br /><br />
                   <asp:Label ID="lblEmail" runat="server" Text="Email Id"></asp:Label><br /><br />
               </div>
               <div class="col-sm-3">
                   <asp:TextBox ID="txtDtlId" runat="server" placeholder="check your approval sms"></asp:TextBox>
                   <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
               </div>
               <div class="col-sm-3">
                   <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label><br /><br />
                   <asp:CheckBox ID="chkActive" runat="server" Text="Ready to take orders&nbsp&nbsp&nbsp" TextAlign="Left" /><br />
               </div>
              <div class="col-sm-3">
                   <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
               </div>
          </div>
           <div class="row">
               <div class="col-sm-12">
                   <div class="center">
                      <asp:Button ID="btn_regSell" runat="server" Text="Verify" Onclick="btn_regSell_Click" />&nbsp&nbsp
                      <asp:Button ID="btn_clearUser" runat="server" Text="Clear" OnClientClick="reset();" CausesValidation=False/>
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
   </div>
   </div></div></div>
</asp:Content>
