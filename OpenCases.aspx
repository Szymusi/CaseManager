<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterLoggedIn.master" AutoEventWireup="true" CodeBehind="WebForm11.aspx.cs" Inherits="ProjektKoncowyV5.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
    <Columns>
        <asp:BoundField DataField="Subject" HeaderText="Subject" SortExpression="Subject" />
        <asp:BoundField DataField="Sender" HeaderText="Sender" SortExpression="Sender" />
        <asp:BoundField DataField="Priority" HeaderText="Priority" SortExpression="Priority" />
        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
    </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Subject], [Sender], [Priority], [Description] FROM [Cases]"></asp:SqlDataSource>

</asp:Content>
