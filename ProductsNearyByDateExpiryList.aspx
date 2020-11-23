
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductsNearyByDateExpiryList.aspx.cs" Inherits="IWin.ProductsNearyByDateExpiryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    //  Best Before for viewing best before products
    <h1>Best Before Section</h1>
  <asp:GridView ID="grdproductDetails" runat="server" DataKeyNames="ProductID"
        AutoGenerateColumns="False"
        onpageindexchanging="grdproductDetails_PageIndexChanging"
        onrowcancelingedit="grdproductDetails_RowCancelingEdit"
        onrowediting="grdproductDetails_RowEditing"
        onrowupdating="grdproductDetails_RowUpdating" AllowPaging="True" PageSize="5"
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
    <asp:TemplateField HeaderText="Edit" ItemStyle-HorizontalAlign="Center">
    <ItemTemplate>
        <asp:ImageButton ID="imgEdit" runat="server" ImageUrl="~/Images/edit.jpg" CommandName="Edit" CausesValidation="false"/>
    </ItemTemplate>
    <EditItemTemplate>
    <asp:LinkButton ID="lnkUpdate" runat="server" Text="Update" CommandName="Update" CausesValidation="false"></asp:LinkButton>
    <asp:LinkButton ID="lnkCancel" runat="server" Text="Cancel" CommandName="Cancel" CausesValidation="false"></asp:LinkButton>
    </EditItemTemplate>
<ItemStyle HorizontalAlign="Center"></ItemStyle>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center">
    <ItemTemplate>
        <asp:ImageButton ID="imgDelete" runat="server" ImageUrl="~/Images/delete.jpg" CommandName="Delete" CausesValidation="false" onclientclick="return confirm('Are you sure you want to delete?')" />
    </ItemTemplate>
    <EditItemTemplate>       
    </EditItemTemplate>
<ItemStyle HorizontalAlign="Center"></ItemStyle>
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
</asp:Content>
