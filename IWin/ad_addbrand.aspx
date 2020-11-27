<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_addBrand.aspx.cs" Inherits="IWin.ad_addbrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
        <h1>Add Brand</h1>
                      <br />
            <div class="adminform">
                   <div class="row">
                      <div class="col-sm-3">
                               <asp:Label ID="lblSName" runat="server" Text="Brand name"></asp:Label>
                         </div>
                        <div class="col-sm-3">
                                <asp:TextBox ID="txtBrand" runat="server"></asp:TextBox>
                           </div>
                       </div>
                      <div class="row">
                          <div class="col-sm-12" style="left: 25px; top: 5px">
                              <div class="center">
                                  <asp:Button ID="Button1" runat="server" Text="Save" Width="90px" OnClick="btn_SaveBrand_Click" />
                              &nbsp&nbsp&nbsp
                                  <asp:Button ID="Button2" runat="server" Text="Clear" />
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
   <%-- <script>
        <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>
    </script>--%>
</asp:Content>
