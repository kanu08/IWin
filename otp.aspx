<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="otp.aspx.cs" Inherits="IWin.UI.ad_addstore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="seller">
    <div class="container">
   <div class="row clearfix">
                  <div class="find-box"><br />
                     <h1>Add a Seller</h1>
                      <br />
                      <div class="adminform">
                        <div class="col-sm-12">
                             <asp:Label ID="lbl_SName" runat="server" Text="Enter Your Mobile No."></asp:Label>
                              &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
                             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send OTP" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Label ID="lbl_SImage" runat="server" Text="Enter OTP"></asp:Label>
                              &nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                             <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Verify" />
                             <br />
                             <br />
                             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </div>
                         </div>
                      </div>
        </div>
        </div>
        </div>
   <%-- <script>
        <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>

    </script>--%>
</asp:Content>
