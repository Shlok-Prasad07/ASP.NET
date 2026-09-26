<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cal.aspx.cs" Inherits="lab4.cal" %>

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
                   <asp:Label ID="lbtext1" runat="server" Text="Enter a number "></asp:Label>
                   <asp:TextBox ID="tb1" runat="server"  >

                   </asp:TextBox> </br></br>

                   <asp:Label ID="server" runat="server" Text="Enter b number"></asp:Label>
                   <asp:TextBox ID="tb2" runat="server" ></asp:TextBox> </br></br>

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