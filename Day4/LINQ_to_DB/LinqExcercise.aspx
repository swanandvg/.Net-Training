<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LinqExcercise.aspx.cs" Inherits="LinqExcercise" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LINQ Excercise</title>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" CssClass="btn"/>
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="table-responsive table">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
