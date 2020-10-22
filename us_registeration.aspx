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
                                <asp:TextBox ID="txtUNum" runat="server"></asp:TextBox>
                         </div>
                        <div class="col-sm-3">
                                <asp:Label ID="lblUEmail" runat="server" Text="User Email"></asp:Label><br /><br />
                                <asp:Label ID="lblUPassword" runat="server" Text="User Password"></asp:Label>             
                        </div>
                        <div class="col-sm-3">
                               <asp:TextBox ID="txtUEmail" runat="server"></asp:TextBox>
                               <asp:TextBox ID="txtUPassword" runat="server"></asp:TextBox>
                        </div>
                      <div class="row"><br />
                          <div class="col-sm-12">
                              <div class="center">
                              <asp:Button ID="btn_saveUser" runat="server" Text="Register" OnClick="btn_saveUser_Click" />&nbsp&nbsp
                              <asp:Button ID="btn_clearUser" runat="server" Text="Clear" />
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
