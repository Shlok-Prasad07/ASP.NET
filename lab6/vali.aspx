<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vali.aspx.cs" Inherits="lab6.vali" %>

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
                    <asp:Label ID="lbname" runat="server" Text="Enter Name : "></asp:Label> 
                </td>

                <td>
                    <asp:TextBox ID="txbname" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvname" runat="server" ControlToValidate="txbname" ErrorMessage="Plz enter name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lbage" runat="server" Text="Enter Age : "></asp:Label> 
                </td>

                <td>
                    <asp:TextBox ID="txbage" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvage" Display="Dynamic" runat="server" ControlToValidate="txbage" ErrorMessage="Plz enter age" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvage" runat="server" ControlToValidate="txbage" ErrorMessage="Plz enter age b/w 18 to 100" MinimumValue="18" MaximumValue="100" Type="Integer" ForeColor="Red" Display="Dynamic"></asp:RangeValidator>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lbpass" runat="server" Text="Enter Password : "></asp:Label> 
                </td>

                <td>
                    <asp:TextBox ID="txbpass" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvfpass" Display="Dynamic" runat="server" ControlToValidate="txbpass" ErrorMessage="Plz enter password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lbcpass" runat="server" Text="Enter Conform Password : "></asp:Label> 
                </td>

                <td>
                    <asp:TextBox ID="txbcpass" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvfcpass" Display="Dynamic" runat="server" ControlToValidate="txbcpass" ErrorMessage="Plz enter conform password" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvcpass" runat="server" ControlToValidate="txbcpass" ControlToCompare="txbpass" ErrorMessage="Plz enter Same password" ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="btsubmit" runat="server" Text="Sumbit" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>