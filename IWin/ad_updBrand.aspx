<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_updBrand.aspx.cs" Inherits="IWin.ad_updBrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="seller">
    <div class="container">
   <div class="row clearfix">
   <div class="find-box"><br />
<%--    <div class="container" style="margin-top:110px;margin-left:380px">--%>
        <asp:Label runat="server" Font-Size="Medium" ForeColor="White">Search:</asp:Label>&nbsp&nbsp&nbsp&nbsp
       <asp:TextBox ID="txtSearch" runat="server" AutoPostBack="true" OnTextChanged="txtSearch_TextChanged"></asp:TextBox><br />
        <br /><br />
     <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Brand_Id" OnRowCancelingEdit="GridView2_RowCancelingEdit" 
         OnRowDeleting="GridView2_RowDeleting" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating" 
         OnRowCreated="GridView2_RowCreated" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" 
         BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="50%" >  
                    <Columns>  
                        <asp:BoundField DataField="Brand_Id" Visible="false" />  
                        <asp:BoundField DataField="Brand_Name" HeaderText="Brand Name" />  
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
        <table border="1" style="border-collapse: collapse"><tr>
            <td style="width: 107px">Brand Name:</td>
             <td style="width: 100px">              
                <asp:TextBox ID="txtBrand" runat="server" Width="140" />
            </td>
            <td style="width: 58px">
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </td>
        </tr>
        </table>
        </div></div></div></div>
</asp:Content>
