<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BankingAccount.aspx.cs" Inherits="BankingAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 133px;
            background-color: #CCCCCC;
        }
        .auto-style4 {
            width: 443px;
            background-color: #CCCCCC;
        }
        .auto-style5 {
            height: 26px;
            width: 558px;
            text-align: center;
        }
        .auto-style6 {
            width: 251px;
            text-align: right;
            background-color: #CCCCCC;
        }
        .auto-style7 {
            text-align: center;
        }
        .auto-style8 {
            text-align: left;
            background-color: #CCCCCC;
        }
        .auto-style9 {
            width: 676px;
            background-color: #CCCCCC;
        }
        .auto-style10 {
            height: 26px;
            width: 443px;
            text-align: center;
        }
        .auto-style11 {
            width: 443px;
            background-color: #CCCCCC;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style7">
    <div>
    <h1> My Banking Web Site</h1>
        <table style="width:100%;">
            <tr>
                <td class="auto-style6">Account Number</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txt_AccountNumber" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style11">
                    <asp:Button ID="btn_GetDetails" runat="server" OnClick="btn_GetDetails_Click" Text="Get Details" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Account Name</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txt_AccountName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Account Type</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txt_AccountType" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Account Balance</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txt_AccountBalance" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Branch Number</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txt_BranchNumber" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                
                <td class="auto-style5" colspan="3">
                    
                    <asp:Button ID="btn_AddAccount" runat="server" Text="Add Account" OnClick="btn_AddAccount_Click" />
                    <asp:Button ID="btn_DeleteAccount" runat="server" Text="Delete Account" OnClick="btn_DeleteAccount_Click" />
                    <asp:Button ID="btn_EditAccount" runat="server" Text="Edit Account" OnClick="btn_EditAccount_Click" />
                
                    <br />
                    <br />
                    <br />
                
            </tr>
                
                <td class="auto-style10">
                    
                    &nbsp;</tr>
        </table>
    
    </div>
            <asp:Button ID="btn_Summary" runat="server" OnClick="btn_Summary_Click" Text="Summary" />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
