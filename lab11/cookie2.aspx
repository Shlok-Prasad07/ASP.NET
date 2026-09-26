<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookie2.aspx.cs" Inherits="lab11.cookie2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Cookie Demonstration</h2>
        <tr>
            <td>
                <asp:Label ID="lblName" runat="server" Text="Enter Your Name:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <br />
        <tr>
            <td>
                <asp:Label ID="lblpass" runat="server" Text="Enter Your Password:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            </td>
        </tr>
        <br />
        <br />
        <asp:Button ID="btnNonPersistent" runat="server" Text="Create Non-Persistent Cookie"
            OnClick="btnNonPersistent_Click" />
        <br />
        <br />

        <asp:Button ID="btnPersistent" runat="server" Text="Create Persistent Cookie"
            OnClick="btnPersistent_Click" />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Blue"></asp:Label>
        <br />
        <br />

    </form>
</body>
</html>
