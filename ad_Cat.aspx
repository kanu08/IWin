<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_addSeller.aspx.cs" Inherits="IWin.UI.ad_addstore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
        <h1>Add a category</h1>
                      <br />
            <div class="adminform">
                  <div class="row">
                        <div class="col-sm-3" style="left: 27px; top: 1px; width: 742px;">
                               <asp:Label ID="lblSName" runat="server" Text="Category name"></asp:Label><br /><br />
                               <br /><br />
                         </div>
                        <div class="col-sm-3">
                                <br />
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <br />
                                <br />
                      <div class="row">&nbsp;<br />
                          &nbsp;&nbsp;
                          <asp:Button ID="Button1" runat="server" Text="Save" Width="90px" />
                          <br />
                          <br />
                          <asp:Button ID="Button2" runat="server" Height="22px" Text="Clear" Width="92px" />
                          <div class="col-sm-12" style="left: 25px; top: 5px">
                              <div class="center">
                                  &nbsp&nbsp
                              </div>
                          </div>
                      </div>
                                <br />
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
