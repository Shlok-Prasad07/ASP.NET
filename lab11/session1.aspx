<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session1.aspx.cs" Inherits="lab11.session1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <tr>
            <td>
                <asp:Label runat="server" ID="lblname" Text="Name:"></asp:Label>
                <asp:TextBox runat="server" ID="txtname"></asp:TextBox>
            </td>
        </tr>
        <br />
        <br />
        <tr>
            <td>
                <asp:Label runat="server" ID="lblage" Text="Age:"></asp:Label>
                <asp:TextBox runat="server" ID="txtage"></asp:TextBox>
            </td>
            <br />
            <br />
        </tr>
        <tr>
            <asp:Button runat="server" ID="btnretrive" OnClick="btnretrive_Click" Text="Retrive" />
            <asp:Button runat="server" ID="btnstore" OnClick="btnstore_Click" Text="Store" />
            <asp:Button runat="server" ID="btnabandon" OnClick="btnabandon_Click" Text="Abandon" />
        </tr>
        <br />
        <asp:Label runat="server" ID="lablinfo"></asp:Label>
        <asp:Label runat="server" ID="lblinfo2"></asp:Label>

    </form>
</body>
</html>
