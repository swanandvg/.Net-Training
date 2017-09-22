<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Banking_CacheingForm.aspx.cs" Inherits="Banking_CacheingForm" %>

<%--hold page for 5 seconds in cache, known as full page cache--%>
<%@ OutputCache Duration="5" VaryByParam="none" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
