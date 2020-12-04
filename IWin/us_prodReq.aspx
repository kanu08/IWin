<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="us_prodReq.aspx.cs" Inherits="IWin.us_prodReq" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="seller">
   
 <div class="row">
                  
    <div class="container">
   <div class="row clearfix">
   <div class="find-box">
      
       <br />
        <h1>Product Request</h1>
                      <br />
            <div class="adminform">
                  <div class="row">
                      <div class="col-sm-3"></div>
                     <div class="col-sm-9" >
                               <asp:Label ID="lblSName" runat="server" Text="Did You See this Product before on Our Website"></asp:Label>&nbsp&nbsp
                             <asp:RadioButtonList ID="RBList1" runat="server" RepeatDirection="Horizontal" AutoPostBack="true" OnSelectedIndexChanged="RBList1_SelectedIndexChanged">
                                 <asp:ListItem Value="1"> Yes</asp:ListItem>
                                 <asp:ListItem Value="2"> No</asp:ListItem>
                            </asp:RadioButtonList>
                               <br />
                         </div> 
                       
                </div>
                <div class="row">
                   <div class="col-sm-5">
                        <asp:Label ID="lblPro" runat="server" Text="Product"></asp:Label><br/>
                            <asp:DropDownList ID="ddlProducts" runat="server" >
                              </asp:DropDownList>
                   </div>
                     <div class="col-sm-3" >
                               <asp:Label ID="lblProduct" runat="server" Text="Product Name"></asp:Label><br/>
                            <asp:TextBox ID="txtProduct" runat="server" ></asp:TextBox>
                             
                               <br />
                         </div> 
                     <div class="col-sm-4" >
                               <asp:Label ID="lblBrand" runat="server">Name of Brand(If Known)</asp:Label><br/>
                            <asp:TextBox ID="txtBrand" runat="server" ></asp:TextBox>
                             
                               <br />
                         </div> 
                
                     <div class="col-sm-3" >
                               <asp:Label ID="lblCmt" runat="server" Text="Details"></asp:Label><br/>
                            <asp:TextBox ID="txtTinyMCE" runat="server" TextMode="MultiLine" Height="108px" Width="257px"></asp:TextBox>
                             
                               <br />
                         </div> 
                      
                    </div>
                <div class="row">
               <br />     <asp:Button id="input_2" runat="server" text="Send" style="background-color: #18bd5b;border-color: #18bd5b;color: #fff;width:20%;" OnClick="input_2_Click"></asp:Button>
                   <br />
                     <asp:Label ID="lblmessage" runat="server" Visible="false"></asp:Label>
                     </div>
        </div>
      
   </div>
   </div>
   </div>
 </div>
     </div>
        
</asp:Content>
