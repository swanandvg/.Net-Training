<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home2.aspx.cs" Inherits="Home2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Button" CssClass="btn" OnClick="Button1_Click" style="height: 26px" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" CssClass="text-primary"></asp:Label>
    
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
