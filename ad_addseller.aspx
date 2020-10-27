<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_addSeller.aspx.cs" Inherits="IWin.UI.ad_addstore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
        <h1>Add a Seller</h1>
                      <br />
            <div class="adminform">
                  <div class="row">
                        <div class="col-sm-3">
                               <asp:Label ID="lblSName" runat="server" Text="Seller Name"></asp:Label><br /><br />
                               <asp:Label ID="lblSImage" runat="server" Text="Seller Image"></asp:Label><br /><br />
                               <asp:Label ID="lblSAddr" runat="server" Text="Seller Address"></asp:Label>
                         </div>
                        <div class="col-sm-3">
                                <asp:TextBox ID="txtSName" runat="server"></asp:TextBox>
                                <asp:TextBox ID="txtSImage" runat="server"></asp:TextBox>
                                <asp:TextBox ID="txtSAddr" runat="server"></asp:TextBox>
                         </div>
                        <div class="col-sm-3">
                                <asp:Label ID="lblSPro" runat="server" Text="Seller Province"></asp:Label><br /><br />
                                <asp:Label ID="lblSContact" runat="server" Text="Seller Contact"></asp:Label><br /><br />
                                <asp:Label ID="lblSPincode" runat="server" Text="Seller Pincode"></asp:Label>            
                        </div>
                        <div class="col-sm-3">
                               <asp:TextBox ID="txtSPro" runat="server"></asp:TextBox>
                               <asp:TextBox ID="txtSContact" runat="server"></asp:TextBox>
                               <asp:TextBox ID="txtSPin" runat="server"></asp:TextBox>
                        </div>
                      <div class="row"><br />
                          <div class="col-sm-12">
                              <div class="center">
                              <asp:Button ID="btn_saveSeller" runat="server" Text="Save" OnClick="btn_saveSeller_Click" />&nbsp&nbsp
                              <asp:Button ID="btn_clearSeller" runat="server" Text="Clear" />
                                  </div>
                          </div>
                      </div>
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
