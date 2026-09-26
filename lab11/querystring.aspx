<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="querystring.aspx.cs" Inherits="lab11.querystring" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="labelemail" runat="server">Enter Email:</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelpassword" runat="server">Enter Password:</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtpass" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Btnsubmit" runat="server" OnClick="Btnsubmit_Click" Text="Submit" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
