<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_addseller.aspx.cs" Inherits="IWin.UI.ad_addstore" %>
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
                               <asp:Label ID="lbl_SName" runat="server" Text="Seller Name"></asp:Label><br /><br />
                               <asp:Label ID="lbl_SImage" runat="server" Text="Seller Image"></asp:Label>
                         </div>
                        <div class="col-sm-3">
                                <asp:TextBox ID="txt_SName" runat="server"></asp:TextBox>
                                <asp:TextBox ID="txt_SImage" runat="server"></asp:TextBox>
                         </div>
                        <div class="col-sm-3">
                                <asp:Label ID="lbl_SLoc" runat="server" Text="Seller Location"></asp:Label><br /><br />
                                <asp:Label ID="lbl_SContact" runat="server" Text="Seller Contact"></asp:Label>             
                        </div>
                        <div class="col-sm-3">
                               <asp:TextBox ID="txt_SLoc" runat="server"></asp:TextBox>
                               <asp:TextBox ID="txt_SContact" runat="server"></asp:TextBox>
                        </div>
                      <div class="row"><br />
                          <div class="col-sm-12">
                              <div class="center">
                              <asp:Button ID="btn_saveSeller" runat="server" Text="Save" />&nbsp&nbsp
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
