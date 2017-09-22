<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddAccount.aspx.cs" Inherits="AddAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.2.min.js" ></script>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body class="media-body">
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;" class="table-responsive table-hover">
            <tr>
                <td class="auto-style1 text-info">Account Number</td>
                <td>&nbsp;</td>
                <td><asp:TextBox ID="txt_AccNo" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1 text-info">Account Name</td>
                <td>&nbsp;</td>
                <td><asp:TextBox ID="txt_AccName" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1 text-info">Account Type</td>
                <td>&nbsp;</td>
                <td><asp:TextBox ID="txt_AccType" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1 text-info">Account Branch</td>
                <td>&nbsp;</td>
                <td><asp:TextBox ID="txt_AccBr" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1 text-info">Account Balance</td>
                <td>&nbsp;</td>
                <td><asp:TextBox ID="txt_AccBal" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
            <tr><td>&nbsp;</td></tr>
            <tr>
                <td class="auto-style1"><asp:Button ID="btn_Insert" runat="server" Text="Insert" CssClass="btn-success btn" OnClick="btn_Insert_Click" /></td>
                <td class="auto-style3"><asp:Button ID="btn_Update" runat="server" Text="Update" CssClass="btn-primary btn" OnClick="btn_Update_Click" /></td>
                <td class="auto-style2"><asp:Button ID="btn_Delete" runat="server" Text="Delete" CssClass="btn-danger btn" OnClick="btn_Delete_Click" /></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="SP1" runat="server" Text="SP1" CssClass="btn" OnClick="SP1_Click" Width="62px"/>
                </td>
                <td class="auto-style3">
                    <asp:Button ID="SP2" runat="server" Text="SP2" CssClass="btn" OnClick="SP2_Click"/>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="SP3" runat="server" Text="SP3" CssClass="btn" OnClick="SP3_Click"/>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
