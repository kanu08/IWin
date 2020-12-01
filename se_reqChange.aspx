<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="se_reqChange.aspx.cs" Inherits="IWin.se_reqChange" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
        <h1>Manage Seller</h1>
                      <br />
            <div class="adminform">
                  <div class="row">
                      <div class="col-sm-6">
                              <asp:Label ID="Label1" runat="server" Text="Seller Attribute"></asp:Label>&nbsp&nbsp&nbsp
                            <asp:DropDownList ID="ddlSellerAttr" runat="server" >
                                <asp:ListItem Value="0">Select Seller</asp:ListItem>
                                <asp:ListItem Value="1">Seller Name</asp:ListItem>
                                <asp:ListItem Value="2">Seller Contact</asp:ListItem>
                                <asp:ListItem Value="3">Seller Address</asp:ListItem>
                                <asp:ListItem Value="4">Seller Agency</asp:ListItem>
                                <asp:ListItem Value="5">More than once</asp:ListItem>
                              </asp:DropDownList>
                               <br /><br />
                         </div>
                        <div class="col-sm-6">
                               <asp:Label ID="lblSCatName" runat="server" Text="Change Description"></asp:Label>&nbsp&nbsp
                               <asp:TextBox ID="txtSeller" runat="server"></asp:TextBox><br />
                               <br /><br />
                            
                         </div> 

                  </div>
                      <div class="row">
                            <div class="col-sm-12">
                              <div class="center">
                              <asp:Button ID="btn_saveSubCat" runat="server" Text="Send" OnClick="btn_saveSubCat_Click"/>&nbsp&nbsp
                              <asp:Button ID="btn_clearCat" runat="server" Text="Clear" OnClientClick="reset();" CausesValidation=False/>
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
                      <br />
                </div>
        </div>
        </div>
        </div>
   <%-- <script>
        <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>
    </script>--%>
</asp:Content>
