<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_addSubcat.aspx.cs" Inherits="IWin.ad_addSubcat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
        <h1>Add a SubCategory</h1>
                      <br />
            <div class="adminform">
                  <div class="row">
                        <div class="col-sm-6">
                               <asp:Label ID="lblSCatName" runat="server" Text="SubCategory name"></asp:Label>&nbsp&nbsp
                               <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                               <br /><br />
                            
                         </div> <div class="col-sm-6">
                              <asp:Label ID="Label1" runat="server" Text="Category"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                            <asp:DropDownList ID="DropDownList1" runat="server" >
                                <asp:ListItem>choose a category</asp:ListItem>
                              </asp:DropDownList><br />
                               <br /><br />
                         </div></div>
                      <div class="row">
                            <div class="col-sm-12">
                              <div class="center">
                              <asp:Button ID="btn_saveSubCat" runat="server" Text="Save" OnClick="btn_saveSubCat_Click"/>&nbsp&nbsp
                              <asp:Button ID="btn_clearCat" runat="server" Text="Clear" OnClientClick="reset();" CausesValidation=False/>
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
