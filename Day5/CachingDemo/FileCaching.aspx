<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileCaching.aspx.cs" Inherits="FileCaching" %>
<%@ OutputCache Duration="5000000" VaryByParam="none" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show Books</title>
    <script type="text/javascript" src="Scripts/jquery-1.10.2.min.js"></script>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Show Books" OnClick="Button1_Click" CssClass="success" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="table table-responsive">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    
    </div>
        
    </form>
</body>
</html>
