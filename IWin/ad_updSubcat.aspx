<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_updSubcat.aspx.cs" Inherits="IWin.ad_updSubcat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
<%--    <div class="container" style="margin-top:110px;margin-left:380px">--%>
        <asp:Label runat="server" Font-Size="Medium" ForeColor="White">Search:</asp:Label>&nbsp&nbsp&nbsp&nbsp
       <asp:TextBox ID="txtSearch" runat="server" AutoPostBack="true" OnTextChanged="txtSearch_TextChanged1"></asp:TextBox><br />
        <br /><br />
     <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="subcategory_id" OnRowCancelingEdit="GridView2_RowCancelingEdit" 
         OnRowDeleting="GridView2_RowDeleting" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating" OnRowDataBound="GridView2_RowDataBound"    
         OnRowCreated="GridView2_RowCreated" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" 
         BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="50%" >  
                    <Columns>  
                        <asp:BoundField DataField="subcategory_id" Visible="false" />
                        <asp:BoundField DataField="subcategory_Name" HeaderText="SubCategory Name" />
                         <asp:BoundField DataField="category_id" Visible="false" />  
                        <asp:TemplateField HeaderText="Category Name">
                            <ItemTemplate>
                                <asp:Label ID="lblBrand" runat="server" Text='<%# Eval("category_Name")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList ID="ddlCategory" runat="server">
                                </asp:DropDownList>
                            </EditItemTemplate>
                        </asp:TemplateField>  
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
        <table border="1" cellpadding="0" cellspacing="0" style="border-collapse: collapse"><tr>
            <td style="width: 100px">SubCategory Name:</td>
             <td style="width: 100px">              
                <asp:TextBox ID="txtSubCat" runat="server" Width="140" />
            </td>
            <td style="width: 100px">
                 <asp:DropDownList ID="ddlCategory" runat="server" >
                              </asp:DropDownList>
                </td>
            <td style="width: 58px">
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </td>
        </tr>
        </table>
        </div></div></div></div>

</asp:Content>
