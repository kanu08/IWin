<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="us_registeration.aspx.cs" Inherits="IWin.us_registeration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="seller">
    <div class="container">
    <div class="row clearfix">
    <div class="find-box"><br />
        <h1>Registeration for new user</h1>
                      <br />
            <div class="adminform">
                  <div class="row">
                        <div class="col-sm-3">
                               <asp:Label ID="lblUName" runat="server" Text="User Name"></asp:Label><br /><br />
                               <asp:Label ID="lblUNum" runat="server" Text="User Contact"></asp:Label>
                         </div>
                        <div class="col-sm-3">
                                <asp:TextBox ID="txtUName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfv_txtUName" runat="server" ErrorMessage="*please enter a username" ControlToValidate="txtUName" Display="Dynamic" ForeColor="#CC0000" Font-Size="XX-Small" SetFocusOnError="True" ValidationGroup="registerUs"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txtUNum" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfv_txtUNum" runat="server" ErrorMessage="*please enter your contact num" ControlToValidate="txtUNum" Display="Dynamic" ForeColor="#CC0000" Font-Size="XX-Small" SetFocusOnError="True" ValidationGroup="registerUs"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="rev_txtUNum" runat="server" ErrorMessage="*please enter a valid number" ControlToValidate="txtUNum" Display="Dynamic" ForeColor="#CC0000" Font-Size="XX-Small" SetFocusOnError="True" ValidationGroup="registerUs" ValidationExpression="^[789]\d{9}$"></asp:RegularExpressionValidator>
                        </div>
                        <div class="col-sm-3">
                                <asp:Label ID="lblUEmail" runat="server" Text="User Email"></asp:Label><br /><br />
                                <asp:Label ID="lblUPassword" runat="server" Text="User Password"></asp:Label>             
                        </div>
                        <div class="col-sm-3">
                               <asp:TextBox ID="txtUEmail" runat="server" TextMode="Email"></asp:TextBox>
                               <asp:RequiredFieldValidator ID="rfv_txtUEmail" runat="server" ErrorMessage="*please enter email id" ControlToValidate="txtUEmail" Display="Dynamic" ForeColor="#CC0000" Font-Size="XX-Small" SetFocusOnError="True" ValidationGroup="registerUs"></asp:RequiredFieldValidator>
                               <asp:RegularExpressionValidator ID="rev_txtUEmail" runat="server" ControlToValidate="txtUEmail" Display="Dynamic" ErrorMessage="*please enter valid email id" ForeColor="#CC0000" SetFocusOnError="True" Font-Size="XX-Small" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                               <asp:TextBox ID="txtUPassword" runat="server" TextMode="Password" ></asp:TextBox>
                               <asp:RequiredFieldValidator ID="rfv_txtUPassword" runat="server" ErrorMessage="*please enter password" ControlToValidate="txtUPassword" Display="Dynamic" ForeColor="#CC0000" Font-Size="XX-Small" SetFocusOnError="True" ValidationGroup="registerUs"></asp:RequiredFieldValidator>
                        </div>
                      <div class="row"><br />
                          <div class="col-sm-12">
                              <div class="center">
                              <asp:Button ID="btn_saveUser" runat="server" Text="Register" OnClick="btn_saveUser_Click" ValidationGroup="registerUs"/>&nbsp&nbsp
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
        </div>
        </div>
        </div>
     </div>
</asp:Content>
