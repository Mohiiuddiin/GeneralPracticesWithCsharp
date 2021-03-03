<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="HelloWorldWebApp.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <%--<asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>--%>
        <input name="nameTextBox" runat="server" type="text" id="nameTextBox" />
        <br/>
        <asp:Button ID="showButton" runat="server"  Text="Show" OnClick="showButton_Click" />
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Output:"></asp:Label>
        <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>
    </div>
        
    </form>
</body>
</html>
