<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_viewProd.aspx.cs" Inherits="IWin.ad_viewProd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
       <%-- <td style="width: 100px">              
                <asp:DropDownList ID="ddlCategory" runat="server" >
                              </asp:DropDownList>
            </td>--%>
        <asp:Label runat="server" Font-Size="Medium" ForeColor="White">Search:</asp:Label>&nbsp&nbsp&nbsp&nbsp
       <asp:TextBox ID="txtSearch" runat="server" AutoPostBack="true" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
       <asp:Label runat="server" Font-Size="Medium" ForeColor="White">Max Price:</asp:Label>&nbsp&nbsp&nbsp&nbsp
       <asp:TextBox ID="txtMaxPrice" runat="server" AutoPostBack="true"></asp:TextBox><br />
       <asp:Label runat="server" Font-Size="Medium" ForeColor="White">Brand:</asp:Label>&nbsp&nbsp<asp:CheckBoxList ID="BrandList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Brand_Name" DataValueField="Brand_Id" Font-Size="Medium" ForeColor="White" style="color:white;">
       </asp:CheckBoxList>
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:iwinConn %>" SelectCommand="SELECT [Brand_Id],[Brand_Name] FROM [tbl_lookup_brand]"></asp:SqlDataSource>
     <%-- <asp:Button ID="btn_sortPrice" runat="server" Text="Sort" OnClick="btnSort_Click" />--%>
&nbsp;<%--<asp:TextBox ID="txtBrand" runat="server" AutoPostBack="true" ></asp:TextBox>--%>
      <asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="btnFilter_Click" />
      
       <br />
        <br />
     <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="product_id" OnRowCancelingEdit="GridView2_RowCancelingEdit" 
         OnRowDeleting="GridView2_RowDeleting" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating" OnRowDataBound="GridView2_RowDataBound" 
         BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" 
         BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="100%" >  
                    <Columns>  
                        <asp:BoundField DataField="product_id" Visible="false" />  
                        <asp:BoundField DataField="Name" HeaderText="Product Name" />  
                         <asp:BoundField DataField="price" HeaderText="Product Price"/> 
                       <asp:BoundField DataField="Brand_Id" Visible="false" /> 
                         <asp:TemplateField HeaderText="Brand Name">
                            <ItemTemplate>
                                <%--<asp:Label ID="lblBrand" runat="server" Text='<%# Eval("Brand_Name")%>'></asp:Label>--%>
                                <asp:Label ID="lblBrand" runat="server" Text='<%#(String.IsNullOrEmpty(Eval("Brand_Name").ToString()) ? "choose" : Eval("Brand_Name"))%>' ></asp:Label>
                               <%-- <asp:Label ID="lblBrand" runat="server" Text=<%#(Eval("Data") == null ? "0" : Eval("Data"))%>></asp:Label>--%>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList ID="ddlBrand" runat="server">
                                </asp:DropDownList>
                            </EditItemTemplate>
                        </asp:TemplateField> 
                         <asp:BoundField DataField="category_id" Visible="false" />                          
                         <asp:TemplateField HeaderText="SubCategory Name">
                            <ItemTemplate>
                                <asp:Label ID="lblSubCategory" runat="server" Text='<%# Eval("subcategory_Name")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList ID="ddlSubCategory" runat="server">
                                </asp:DropDownList>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="subcategory_id" Visible="false" />
                         <asp:BoundField DataField="Image" HeaderText="Image" ReadOnly="true" />
                          
<%--                    <asp:BoundField DataField="category_id" HeaderText="category_ID" />  --%>                      
                        <asp:CommandField ShowEditButton="true" />  
                        <asp:CommandField ShowDeleteButton="true" /> 
                       
                    </Columns>  
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>  
        <table BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" CellPadding="1" CellSpacing="2" Width="100%" >
            <tr>
            <td style="width: 80px"><asp:TextBox ID="txtSCat" runat="server"></asp:TextBox></td>
             <td style="width: 80px">              
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </td>
           <%-- <td style="width: 100px">              
                <asp:DropDownList ID="ddlCategory" runat="server" >
                              </asp:DropDownList>
            </td>--%>
            <td style="width: 100px">              
               <asp:DropDownList ID="ddlBrand" runat="server" >
                              </asp:DropDownList>
            </td>
             <td style="width: 100px">              
               <asp:DropDownList ID="ddlSubCategory" runat="server" >
                              </asp:DropDownList>
            </td>
             <td style="width: 100px">             
              <asp:label runat="server" Text="UploadImage:" ForeColor="White"></asp:label><asp:FileUpload ID="FileUpload1" runat="server" ForeColor="White"/>
            </td>
            <td style="width: 58px">
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </td>
        </tr>
        </table>
        </div></div></div></div>

</asp:Content>
