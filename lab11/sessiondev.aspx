<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sessiondev.aspx.cs" Inherits="lab11.sessiondev" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 20px;">
            <h2>ASP.NET Session Demo</h2>

            <asp:TextBox ID="txtName" runat="server" Placeholder="Enter Name"></asp:TextBox><br />
            <br />
            <asp:TextBox ID="txtEmail" runat="server" Placeholder="Enter Email"></asp:TextBox><br />
            <br />

            <asp:Button ID="btnStore" runat="server" Text="Store Session Data" OnClick="btnStore_Click" /><br />
            <br />
            <asp:Button ID="btnRetrieve" runat="server" Text="Retrieve Session Data" OnClick="btnRetrieve_Click" /><br />
            <br />
            <asp:Button ID="btnAbandon" runat="server" Text="Abandon Session" OnClick="btnAbandon_Click" /><br />
            <br />

            <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label><br />
            <br />
            <asp:Label ID="lblSessionStatus" runat="server" ForeColor="Red"></asp:Label>
        </div>

    </form>
</body>
</html>
