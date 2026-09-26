<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="extra.aspx.cs" Inherits="lab5.extra" %>

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
<asp:ListBox ID="lstSports" runat="server" SelectionMode="Multiple" Rows="9" >
    <asp:ListItem Text="Cricket" Value="CRIC"></asp:ListItem>
<asp:ListItem Text="Football" Value="FB"></asp:ListItem>
<asp:ListItem Text="Basketball" Value="BB"></asp:ListItem>
<asp:ListItem Text="Kabbadi" Value="KABBADI"></asp:ListItem>
</asp:ListBox>
</td>
<td> <asp:Button ID="btnSubmit" runat="server" Text="Submit"
OnClick="btnSubmit_Click" /> </td>
</tr>
<tr> <td> <asp:Label ID="lblinfo" runat="server"></asp:Label> </td> </tr>
</table>
    </form>
</body>
</html>
