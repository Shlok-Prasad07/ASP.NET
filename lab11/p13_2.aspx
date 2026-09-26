<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="p13_2.aspx.cs" Inherits="lab11.p13_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" Text="Email"></asp:Label>
        <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Password:"></asp:Label>
        <asp:TextBox runat="server" ID="txtPass"></asp:TextBox>
        <br />

        <asp:Button runat="server" Text="Log in" OnClick="Unnamed_Click" />
        <br />
        <asp:Label runat="server" ID="lblResult" />

    </form>
</body>
</html>
