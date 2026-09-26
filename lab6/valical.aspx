<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="valical.aspx.cs" Inherits="lab6.valical" %>

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
                    <asp:Label ID="lbtext1" runat="server" Text="Enter number a here"></asp:Label>
                    <asp:TextBox ID="tb1" runat="server"  ></asp:TextBox> 
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="tb1" ErrorMessage="Please enter the number!" Display="Dynamic" ForeColor="Red"/>
                    </br></br>

                    <asp:Label ID="server" runat="server" Text="Enter number b here"></asp:Label>
                    <asp:TextBox ID="tb2" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="tb2" ErrorMessage="Please enter the number!" Display="Dynamic" ForeColor="Red" />
                    <asp:CompareValidator ErrorMessage="Invalid Number!" ControlToValidate="tb2" Display="Dynamic" ForeColor="Red" Operator="DataTypeCheck" Type="Double"  runat="server" />
                    </br></br>

                    <asp:Button ID="btadd" runat="server"  Text="+" OnClick="btn"/>
                    <asp:Button ID="btsub" runat="server"  Text="-" OnClick="btn"/>
                    <asp:Button ID="btmul" runat="server"  Text="*" OnClick="btn"/>
                    <asp:Button ID="btdiv" runat="server"  Text="/" OnClick="btn"/>
                    <asp:Button ID="btmod" runat="server"  Text="%" OnClick="btn"/> </br></br>

                    <asp:Label ID="lbres" runat="server" Text="Result" ></asp:Label>
                    <asp:Button ID="btres" runat="server"  Width="100"/>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
