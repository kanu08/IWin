
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductsNearyByDateExpiryList.aspx.cs" Inherits="IWin.ProductsNearyByDateExpiryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <%--  Best Before for viewing best before products--%>
    <table style="align-content:center;margin-top:40px"; >
        <tr>
    <h1>Best Before Section</h1>
  <asp:GridView ID="grdproductDetails" runat="server" DataKeyNames="ProductID"
        AutoGenerateColumns="False"
        onpageindexchanging="grdproductDetails_PageIndexChanging"
        AllowPaging="True" PageSize="5"
        CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
    <asp:TemplateField HeaderText="Product Name">
    <ItemTemplate>
        <asp:Label ID="lblProductName" runat="server" Text='<%#Eval("ProductName")%>'></asp:Label>
    </ItemTemplate>
    <EditItemTemplate>
        <asp:TextBox ID="txtProductNameEdit" runat="server" Text='<%#Eval("ProductName")%>'></asp:TextBox></EditItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Product Description">
    <ItemTemplate>
        <asp:Label ID="lblDescription" runat="server" Text='<%#Eval("ProductDescription")%>'></asp:Label>
    </ItemTemplate>
    <EditItemTemplate>
        <asp:TextBox ID="txtDescription" runat="server" Text='<%#Eval("ProductDescription")%>'></asp:TextBox>
    </EditItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="ProductExpiryDate">
    <ItemTemplate>
        <asp:Label ID="lblProductExpiryDate" runat="server" Text='<%#Eval("ProductExpiryDate")%>'></asp:Label>
    </ItemTemplate>
    <EditItemTemplate>
        <asp:TextBox ID="txtProductExpiryDateEdit" runat="server" Text='<%#Eval("ProductExpiryDate")%>'></asp:TextBox>
     </EditItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Price">
    <ItemTemplate>
        <asp:Label ID="lblPrice" runat="server" Text='<%#Eval("Price")%>'></asp:Label>
    </ItemTemplate>
    <EditItemTemplate>
        <asp:TextBox ID="txtPriceEdit" runat="server" Text='<%#Eval("Price")%>'></asp:TextBox>
    </EditItemTemplate>
    </asp:TemplateField>
    

    </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
            </tr>
        </table>
</asp:Content>
