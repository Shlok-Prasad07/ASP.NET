<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookie.aspx.cs" Inherits="lab11.cookie" %>

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
                    <asp:Label ID="lblName" runat="server" Text="Enter Your Name:"></asp:Label>
                </td>  
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAge" runat="server" Text="Enter Your Age:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmitData" runat="server" Text="Generate Cookie" OnClick="btnSubmitData_Click" /></td>
                <td>
                    <asp:Button ID="btnGetData" runat="server" Text="Get Cookie" OnClick="btnGetData_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblData" runat="server"></asp:Label>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
