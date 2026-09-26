<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sportstheme.aspx.cs" Inherits="lab7.sportstheme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="App_Themes/sports/sp.css" />
    <title>Sports Theme</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lbname" runat="server" Text="Select Your fav. sport"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:CheckBoxList ID="cblsport" runat="server">
                        <asp:ListItem Text="Cricket"></asp:ListItem>
                        <asp:ListItem Text="Chess"></asp:ListItem>
                        <asp:ListItem Text="volleball"></asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="btsubmit" runat="server" Text="Submit" OnClick="btsubmit_Click"></asp:Button>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lbfinalans" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
