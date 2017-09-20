<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Procedures.aspx.cs" Inherits="Procedures" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="SP_1" runat="server" OnClick="Button1_Click" Text="SP_1" />
        <asp:Button ID="SP_2" runat="server" OnClick="SP_2_Click" Text="SP_2" />
        <asp:Button ID="SP_3" runat="server" OnClick="SP_3_Click" Text="SP_3" />
        <asp:Button ID="SP_4" runat="server" OnClick="SP_4_Click" Text="SP_4" />
    
    </div>
    </form>
</body>
</html>
