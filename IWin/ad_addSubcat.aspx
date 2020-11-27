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
                               <asp:TextBox ID="txtSCat" runat="server"></asp:TextBox><br />
                               <asp:RequiredFieldValidator ID="rfv_txtSCat" runat="server" ErrorMessage="please fill subcategory name" Forecolor="Red" Font-Size="X-Small" ControlToValidate="txtSCat" ValidationGroup="vg_saveSubCat"></asp:RequiredFieldValidator>
                               <br />
                            
                         </div> <div class="col-sm-6">
                              <asp:Label ID="Label1" runat="server" Text="Category"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                            <asp:DropDownList ID="ddlCategory" runat="server" >
                              </asp:DropDownList><br />
                             <asp:RequiredFieldValidator ID="rfv_ddlCategory" runat="server" ErrorMessage="category is mandatory" Forecolor="Red" Font-Size="X-Small" ControlToValidate="ddlCategory" InitialValue="0" ValidationGroup="vg_saveSubCat"></asp:RequiredFieldValidator><br />
                               <br />
                         </div></div>
                      <div class="row">
                            <div class="col-sm-12">
                              <div class="center">
                              <asp:Button ID="btn_saveSubCat" runat="server" Text="Save" OnClick="btn_saveSubCat_Click" ValidationGroup="vg_saveSubCat"/>&nbsp&nbsp
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
