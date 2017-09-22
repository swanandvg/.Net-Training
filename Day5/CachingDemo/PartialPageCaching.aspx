<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PartialPageCaching.aspx.cs" Inherits="PartialPageCaching" %>
<%--vary by param = DropDownList for partial page caching as page should change according to DropDownList 
    selected value--%>
<%@ OutputCache Duration="60" VaryByParam="DropDownList1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" >
            <asp:ListItem Selected="True">Savings</asp:ListItem>
            <asp:ListItem>Current</asp:ListItem>
            <asp:ListItem>PF</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="accNo" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="accNo" HeaderText="accNo" ReadOnly="True" SortExpression="accNo" />
                <asp:BoundField DataField="accName" HeaderText="accName" SortExpression="accName" />
                <asp:BoundField DataField="accType" HeaderText="accType" SortExpression="accType" />
                <asp:BoundField DataField="accBalance" HeaderText="accBalance" SortExpression="accBalance" />
                <asp:BoundField DataField="accBranch" HeaderText="accBranch" SortExpression="accBranch" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BankingDBConnectionString %>" SelectCommand="SELECT * FROM [AccountDetail] WHERE ([accType] = @accType)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="accType" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
