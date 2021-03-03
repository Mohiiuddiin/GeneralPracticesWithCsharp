<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListViewUI.aspx.cs" Inherits="WebFormProjectWebApp.ListViewUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
        <br />
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" />
        <br />
        <asp:ListBox ID="nameListBox" runat="server" Height="363px" Width="243px"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
