<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="us_viewSubs.aspx.cs" Inherits="IWin.us_viewSubs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <div class="seller">
    <div class="container">
<%--    <div class="row clearfix"> <br />
  <div class="find-box">--%>
         <div style="margin-top: 70px;margin-left:20px;margin-right:20px;">
       <asp:DataList ID="DataList2" runat="server" DataSourceID="SqlDataSource2"  ForeColor="White">
                <ItemTemplate>
                    <br />
                    <table style="width:100%;">
                      <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text='<%# Eval("Name") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Product of Canada. Farm fresh. </td>
                            <td>
                                <asp:Image ID="Image1" runat="server" MaxHeight="300px" ImageUrl='<%# "~/images/" + Eval("Image") %>' MaxWidth="300px" />
                            </td>
                        </tr>
                    <div><%--<asp:Button ID="Button1" class="" runat="server" CommandArgument='<%# Eval("product_id")%>' CommandName="addtocart" Height="30px"  Text="Buy Now" Width="100px" ForeColor="Black" />--%>
                         </div>  &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                        <div><asp:Button ID="Button2" class="" runat="server" Height="30px"  Text="Go Back" Width="100px" ForeColor="Black" PostBackUrl="~/se_viewProd.aspx" />
                         </div>  
                    </table>
                </ItemTemplate>
            </asp:DataList>
        
        <p>
            &nbsp;</p>
 <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings: iwinConn %>" SelectCommand="SELECT product_id,Name,Image,Brand_Name FROM [v_allProducts] WHERE ([product_id] = @product_id)" >
            <SelectParameters>
                <asp:QueryStringParameter Name="product_id" QueryStringField="prod" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
       <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" ForeColor="White" OnItemCommand="DataList1_ItemCommand"  >
           <ItemTemplate>

               <table style="width:100%;border-color:white; border: 4px solid white">
                      <tr>
<%--       <td><asp:Label ID="mqu_idLabel" runat="server" Text='<%# Eval("mqu_id") %>' /></td>--%>
                  <td>Sold By:&nbsp&nbsp</td>
                  <td> <asp:Label ID="lblsellName" runat="server" Text='<%# Eval("SellerName") %>' />&nbsp&nbsp</td>
                 <td>Package:&nbsp&nbsp</td>
                 <td><asp:Label ID="lblqt" runat="server" Text='<%# Eval("quantity")%>' /><asp:Label ID="lblUom" runat="server" Text='<%# Eval("UOM_Desc")%>' /> &nbsp&nbsp</td>       
                 <td rowspan="2" colspan="4" style="border-left:2px thin white;">Quantity&nbsp&nbsp
                     <asp:DropDownList ID="ddlQty" runat="server" ForeColor="Black">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem Value="4"></asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                     </asp:DropDownList>&nbsp&nbsp
                     <asp:Button ID="btnSubscribe" runat="server" Text="subscribe" CommandArgument='<%#Eval("mqu_id")+","+Eval("Id")%>' 
                                    CommandName="subscribe" Height="25px" Width="100px" />

                   </td>     
                      </tr>
                       <tr>
                       <td>sellPrice:&nbsp&nbsp</td>
                        <td><asp:Label ID="lblsellPrice" runat="server" Text='<%# Eval("sellPrice") %>' />&nbsp&nbsp</td>
                        <td>Available Qty:&nbsp&nbsp</td>
                        <td><asp:Label ID="lblsellQty" runat="server" Text='<%# Eval("sellQty") %>' />&nbsp&nbsp</td>
                    </tr>
              </table>
           </ItemTemplate>
       </asp:DataList>
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:iwinConn %>" SelectCommand="sp_ViewProdForUser" SelectCommandType="StoredProcedure">
           <SelectParameters>
               <asp:SessionParameter Name="em" SessionField="user" Type="String" />
               <asp:QueryStringParameter Name="prodId" QueryStringField="prod" Type="Int32" />
               <asp:Parameter DefaultValue="1" Name="OP" Type="Int32" />
           </SelectParameters>
       </asp:SqlDataSource>
       <br />
      

       </div></div></div>

</asp:Content>

