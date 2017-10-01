<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>StateManagement - Home</title>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" CssClass="btn" />
        <br />
        <br />
        <br />
        <div class="divider">
            <asp:Label ID="Label1" runat="server" Text="Label" CssClass="text-info"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="nav" NavigateUrl="~/Home2.aspx">Home2</asp:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
