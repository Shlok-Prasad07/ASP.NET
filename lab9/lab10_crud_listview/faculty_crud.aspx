<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="faculty_crud.aspx.cs" Inherits="lab10_crud_listview.faculty_crud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <table style="width: 520px" >
                <tr>
                    <td>
                        <asp:Label ID="lblFirstName" runat="server" Text="Enter your Firstname here:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblLastname" runat="server" Text="Enter your Lastname here:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblContactNo" runat="server" Text="Enter ContactNo here:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtContactNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmailID" runat="server" Text="Enter your EmailID here:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmailID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" Visible="False" />
                    </td>
                </tr>
            </table>
        </fieldset>


        <asp:HiddenField ID="hfRecord" runat="server" />
        <h3>Employee Information</h3>
        <asp:ListView ID="lstfaculty" runat="server" OnItemCommand="lstfaculty_ItemCommand" DataKeyNames="Faculty_ID">
            <ItemTemplate>
                <table>
                    <tr>
                        <td style="width: 100px"><b>Faculty_ID. :</b> <%#Eval("Faculty_ID") %> </td>
                        <td style="width: 200px"><b>FirstName :</b>  <%#Eval("Faculty_FirstName") %> </td>
                        <td style="width: 200px"><b>Lastname :</b>  <%#Eval("Faculty_LastName") %> </td>
                        <td style="width: 200px"><b>ContactNo :</b> <%#Eval("Faculty_ContactNo") %> </td>
                        <td style="width: 300px"><b>Email id:</b> <%#Eval("Faculty_EmailID") %> </td>
                        <td>
                            <asp:ImageButton ID="btndel" Width="25px" Height="20px" runat="server"  ImageUrl="~/image/delete icon.png"
                                ToolTip="Delete a record" OnClientClick="javascript:return confirm('Are you sure to delete record?')" 
                                CommandName="facDelete" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Faculty_ID")  %>'/>

                            <asp:ImageButton ID="btnupdt" runat="server" ImageUrl="~/image/update icon.png" Height="20px" Width-="25px" ToolTip="Update a record" 
                                CommandName="facEdit" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Faculty_ID") %>' />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:ListView>

    </form>
</body>
</html>
