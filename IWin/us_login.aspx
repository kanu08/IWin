<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="us_login.aspx.cs" Inherits="IWin.us_login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="login-form">
    <div class="find-box"><br /><br />
    <h2><strong>Login with password or OTP</strong></h2><br />
        <div class="loginbox" style="float:left;">
                         <div class="col-sm-5">
                               <asp:Label ID="lblUName" runat="server" Text="UserName"></asp:Label><br /><br />
                               <asp:Label ID="lblUPass" runat="server" Text="Password"></asp:Label>
                         </div>
                         <div class="col-sm-6">
                              <asp:TextBox ID="txtUName" runat="server" placeholder="enter email or contact"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="rfv_txtUName" runat="server" ErrorMessage="*please enter username" ControlToValidate="txtUName" Display="Dynamic" ForeColor="#CC0000" Font-Size="XX-Small" SetFocusOnError="True" ValidationGroup="loginPs"></asp:RequiredFieldValidator>
                              <asp:TextBox ID="txtUPassword" runat="server" TextMode="Password" ></asp:TextBox>
                              <asp:RequiredFieldValidator ID="rfv_txtUPassword" runat="server" ErrorMessage="*please enter password" ControlToValidate="txtUPassword" Display="Dynamic" ForeColor="#CC0000" Font-Size="XX-Small" SetFocusOnError="True" ValidationGroup="loginPs"></asp:RequiredFieldValidator>
                     <br /><br /><asp:Button ID="btn_loginPsd" runat="server" Text="Login" ValidationGroup="loginPs" OnClick="btn_loginPs_Click"/>   
                        </div><br /><br /><br /><br /><br /><br /><br />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                          <asp:Label class="lblsuccess" ID="lblmessage" runat="server" Text="" Visible="false">
                              </asp:Label>
            </div>
            <div class="loginbox" style="float:right;">
                         <div class="col-sm-5">
                               <asp:Label ID="lblUNum" runat="server" Text="UserContact"></asp:Label><br /><br />
                               <asp:Label ID="lblOtp" runat="server" Text="OTP"></asp:Label>
                             </div>
                   <div class="col-sm-7">
                             <asp:TextBox ID="txtUNum" runat="server" placeholder="enter contact"></asp:TextBox>
                       <a href="#" onserverclick="btn_sendOtp" runat="server">send OTP</a>
                       <asp:RequiredFieldValidator ID="rfv_txtUNum" runat="server" ErrorMessage="*please enter contact" ControlToValidate="txtUNum" Display="Dynamic" ForeColor="#CC0000" Font-Size="XX-Small" SetFocusOnError="True" ValidationGroup="loginOt"></asp:RequiredFieldValidator>
                       <asp:RegularExpressionValidator ID="rev_txtUNum" runat="server" ErrorMessage="*enter valid number" ControlToValidate="txtUNum" Display="Dynamic" ForeColor="#CC0000" Font-Size="XX-Small" SetFocusOnError="True" ValidationGroup="loginOt" ValidationExpression="^[789]\d{9}$"></asp:RegularExpressionValidator>       
                       <asp:TextBox ID="txtOtp" runat="server" placeholder="check your msgs"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="rfv_txtOtp" runat="server" ErrorMessage="*please enter otp" ControlToValidate="txtUPassword" Display="Dynamic" ForeColor="#CC0000" Font-Size="XX-Small" SetFocusOnError="True" ValidationGroup="loginOt"></asp:RequiredFieldValidator>
                    <br /><br /><asp:Button ID="btn_loginOtp" runat="server" Text="Login" ValidationGroup="loginOt" OnClick="btn_verifyOtp"/>   
                   </div>
                <br /><br /><br /><br /><br /><br /><br />&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                          <asp:Label class="lblsuccess" ID="lblOtpmsg" runat="server" Text="" Visible="false">
                              </asp:Label>
               </div>
        </div></div>
</asp:Content>
