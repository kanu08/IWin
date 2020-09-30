<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_addseller.aspx.cs" Inherits="IWin.UI.ad_addstore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="seller">
    <div class="container">
   <div class="row clearfix">
                  <div class="find-box"><br />
                     <h1>Add a Seller</h1>
                      <br />
                      <div class="adminform">
                        <div class="col-sm-12">
                             <asp:Label ID="lbl_SName" runat="server" Text="Seller Name"></asp:Label>
                              <asp:TextBox ID="txt_SName" runat="server"></asp:TextBox>
                             <asp:Label ID="lbl_SImage" runat="server" Text="Seller Image"></asp:Label>
                              <asp:TextBox ID="txt_SImage" runat="server"></asp:TextBox>
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
