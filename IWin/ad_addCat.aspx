<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_addCat.aspx.cs" Inherits="IWin.ad_addCat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
        <h1>Add a category</h1>
                      <br />
            <div class="adminform">
                  <div class="row">
                        <div class="col-sm-6" >
                               <asp:Label ID="lblSName" runat="server" Text="Category name"></asp:Label>&nbsp&nbsp
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                               <br /><br />
                         </div></div>
                      <div class="row">
                            <div class="col-sm-12">
                              <div class="center">
                              <asp:Button ID="btn_saveCat" runat="server" Text="Save" OnClick="btn_saveCat_Click"/>&nbsp&nbsp
                              <asp:Button ID="btn_clearCat" runat="server" Text="Clear" OnClientClick="reset();" CausesValidation=False/>
                              </div>
                          </div>
                          <div class="col-sm-12">
                              <div class="center">
                              <asp:Label class="lblsuccess" ID="lblMessage" runat="server" Text="" Visible="false">
                              </asp:Label>
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
