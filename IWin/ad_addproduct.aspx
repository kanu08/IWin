<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_addProduct.aspx.cs" Inherits="IWin.ad_addProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
        <h1>Add a Product</h1>
                      <br />
            <div class="adminform">
                  <div class="row">
                        <div class="col-sm-6">
                               <asp:Label ID="lblSCatName" runat="server" Text="Product Name"></asp:Label>&nbsp&nbsp
                               <asp:TextBox ID="txtSCat" runat="server"></asp:TextBox>                             
                            
                         </div>
                       <div class="col-sm-6">
                               <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>&nbsp&nbsp
                               <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                         </div>
                      </div>
                <div class="row">
                      <div class="col-sm-6">
                              <asp:Label ID="Label2" runat="server" Text="SubCategory"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp

                            <asp:DropDownList ID="ddlSubCategory" runat="server" >
                              </asp:DropDownList>

                         </div>
                    <div class="col-sm-6">
                     <asp:Label ID="Label4" runat="server" Text="Brand"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp

                            <asp:DropDownList ID="ddlBrand" runat="server" >
                              </asp:DropDownList>
                </div>
                  </div>
                <br/>
                <div class="row"> 
                <div class="col-sm-6"> 
                    <asp:Label ID="Label5" runat="server" Text="Upload Image:"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <asp:FileUpload ID="FileUpload1" runat="server"/>
                    <asp:RegularExpressionValidator ID="regexValidator" runat="server"
                         ControlToValidate="FileUpload1"
                         ErrorMessage="Only images are allowed" 
                         ValidationExpression="(.*\.([Jj][Pp][Gg])|.*\.([Jj][Pp][Ee][Gg])$)">
                    </asp:RegularExpressionValidator>  
                </div>  
              
                        </div>
                   
                      <div class="row">
                            <div class="col-sm-12">
                              <div class="center">
                              <asp:Button ID="btn_saveProd" runat="server" Text="Save" OnClick="btn_saveProd_Click"/>&nbsp&nbsp
                              <asp:Button ID="btn_clearCat" runat="server" Text="Clear" OnClick="btn_clearCat_Click" CausesValidation=False/>
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
                      <br />
                </div>
        </div>
        </div>
        
   <%-- <script>
        <script src="Scripts/bootstrap.min.js" type="text/javascript"></script>
    </script>--%>
</asp:Content>
