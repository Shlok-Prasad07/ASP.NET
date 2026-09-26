<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="lab11.view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>view state</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="labelname" runat="server">Student Name:</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lablenroll" runat="server">Student Enrollment No:</asp:Label></td>
                <td>
                    <asp:TextBox ID="txten" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Btnsubmit" runat="server" OnClick="Btnsubmit_Click" Text="Submit" /></td>
                <td>
                    <asp:Button ID="Btnretrive" runat="server" OnClick="Btnretrive_Click" Text="Retrive" /></td>
            </tr>
        </table>

    </form>
</body>
</html>
