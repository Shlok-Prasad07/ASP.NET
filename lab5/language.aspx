<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="language.aspx.cs" Inherits="lab5.language" %>

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
                    <asp:Label ID="lbtitle" runat="server" Text="Select Your language"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:RadioButtonList ID="rbllan" runat="server" OnSelectedIndexChanged="rbllan_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Text="Python"></asp:ListItem>
                        <asp:ListItem Text="C"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:DropDownList ID="ddlty" runat="server"></asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>
                     <asp:Button ID="btsubmit" runat="server" Text="Submit" OnClick="btsubmit_Click"></asp:Button>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lbselres" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
