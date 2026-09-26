<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookie12_2.aspx.cs" Inherits="lab11.cookie12_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Login</h2>

        <asp:Label ID="Labelname" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
        <br />

        <asp:Label ID="Labelpass" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
        <br />

        <asp:CheckBox ID="chkRememberMe" runat="server" Text=" Remember Me" /><br />
        <br />

        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><br />
        <br />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />
        <br />

    </form>
</body>
</html>
