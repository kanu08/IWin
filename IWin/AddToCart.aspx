<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="IWin.AddToCart1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="seller">
    <div class="container">
   <%--<div class="row clearfix">--%>
   <%--<div class="find-box">--%>
<div style="margin-top: 70px;margin-left:20px;margin-right:20px;">
            <br />
         <asp:Label ID="you" runat="server" Text="You have" ForeColor="White"></asp:Label>
            <asp:Label ID="Label2" runat="server" ForeColor="White"></asp:Label>
&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Text="products in your cart" ForeColor="White"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/se_viewProd.aspx" ForeColor="White">Continue Shopping</asp:HyperLink>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnPlaceOrder" runat="server" Width="250px" Text="Click To Place Order" OnClick="btnPlaceOrder_Click"/>
            <br />&nbsp;&nbsp;&nbsp<asp:Label ID="Label10" runat="server" ForeColor="White"></asp:Label>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  BackColor="#654321" 
                BorderColor="#654321" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="330px"
                ShowFooter="True" Width="1050px" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="sno" HeaderText="no" SortExpression="sno" ReadOnly="True"/>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" ReadOnly="True"/>
                   <%-- <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" ReadOnly="True" />--%>
                  <%--  <asp:TemplateField>
                        <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" MaxHeight="300px" ImageUrl='<%# "~/images/" + Eval("Image") %>' MaxWidth="300px" />
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                    <asp:BoundField DataField="Brand" HeaderText="BrandName" SortExpression="Brand" ReadOnly="True" />
                    <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" ReadOnly="True"/>
                    <asp:BoundField DataField="uom" HeaderText="(quantity in )" SortExpression="uom" ReadOnly="True"/>
                    <asp:BoundField DataField="MRP" HeaderText="MRP" SortExpression="MRP" ReadOnly="True"/>
                    <asp:BoundField DataField="sname" HeaderText="Sold By" SortExpression="sname" ReadOnly="True"/>
                    <asp:BoundField DataField="sprice" HeaderText="sellPrice" SortExpression="sprice" ReadOnly="True" />
                    <asp:BoundField DataField="sQty" HeaderText="sellQty" SortExpression="sQty" visible="false"/>
                    <asp:BoundField DataField="dis" HeaderText="discount" ReadOnly="True" SortExpression="dis" />
                    <asp:TemplateField HeaderText="To Order">
                        <ItemTemplate >
                       <asp:DropdownList ID="ddlQty" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlQty_SelectedIndexChanged" 
                           SelectedValue='<%# Eval("order") %>'>
                            <asp:ListItem Value="1">1</asp:ListItem>
                                    <asp:ListItem Value="2">2</asp:ListItem>
                                    <asp:ListItem Value="3">3</asp:ListItem>
                                    <asp:ListItem Value="4"></asp:ListItem>
                                    <asp:ListItem Value="5">5</asp:ListItem>
                       </asp:DropdownList>
                       </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:BoundField DataField="totalprice"  HeaderText="Total price" SortExpression="totalprice" ReadOnly="true" />
                    <asp:CommandField DeleteText="Remove" ShowDeleteButton="True" />
                </Columns>
             <FooterStyle BackColor="#997d64" ForeColor="#FFFFFF" />
                <HeaderStyle BackColor="#654321" Font-Bold="True" ForeColor="White" Height="50px" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
            <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:iwinConn %>" SelectCommand="sp_user_cartView" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter Name="pid" QueryStringField="pid" Type="Int32" />
                    <asp:QueryStringParameter Name="sid" QueryStringField="se" Type="Int32" />
                    <asp:QueryStringParameter DefaultValue="" Name="mquid" QueryStringField="mqu" Type="Int32" />
                    <asp:Parameter DefaultValue="1" Name="OP" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>--%>
       </div></div></div>
</asp:Content>
