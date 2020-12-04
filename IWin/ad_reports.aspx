<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ad_Reports.aspx.cs" Inherits="IWin.ad_reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <div class="seller">
    <div class="container">
<div style="margin-top: 70px;margin-left:20px;margin-right:20px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"
                BackColor="#654321" 
                BorderColor="#654321" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="330px"
                ShowFooter="True" Width="1050px" 
                >
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Brand_Name" HeaderText="Brand_Name" SortExpression="Brand_Name" />
                    <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
                    <asp:BoundField DataField="UOM_Desc" HeaderText="UOM_Desc" SortExpression="UOM_Desc" />
                    <asp:BoundField DataField="SellerName" HeaderText="SellerName" SortExpression="SellerName" />
                    <asp:BoundField DataField="sellPrice" HeaderText="sellPrice" SortExpression="sellPrice" />
                    <asp:BoundField DataField="sellQty" HeaderText="sellQty" SortExpression="sellQty" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:iwinConn %>" 
           SelectCommand="SELECT Name, Brand_Name, quantity, UOM_Desc, SellerName , sellPrice, sellQty FROM v_CartView"></asp:SqlDataSource>
            <br />


    </div></div></div>

</asp:Content>
