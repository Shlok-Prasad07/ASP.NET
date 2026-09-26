<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="lab11.Data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <h2>Employee Information Received</h2>
            <tr>
                <td>
                    <b>Email:</b>
                    <asp:Label ID="labelemail" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Password:</b>
                    <asp:Label ID="labelpassword" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
