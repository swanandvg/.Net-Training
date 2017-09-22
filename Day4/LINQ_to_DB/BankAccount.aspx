<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BankAccount.aspx.cs" Inherits="BankAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Entity Framework</title>
    <%--<link rel="stylesheet" href="Con"
--%></head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Show Accounts" Height="46px" Width="149px" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Height="44px" OnClick="Button2_Click" Text="Acc_Branch" Width="144px" />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
        
    </form>
</body>
</html>
