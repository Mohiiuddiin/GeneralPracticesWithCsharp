<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDetailsUI.aspx.cs" Inherits="StudentWebApp.UI.StudentDetailsUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                   <asp:GridView ID="studentListGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    
                    <asp:TemplateField HeaderText="Reg No">
                        <ItemTemplate>
                            <asp:HiddenField ID="idHiddenField" runat="server" Value='<%#Eval("Id")%>'/>
                            <asp:Label runat="server" Text='<%#Eval("RegNo")%>' ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                     <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("StudentName")%>' ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                     <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Email")%>' ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                     <asp:TemplateField HeaderText="Address">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Address")%>' ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                     <asp:TemplateField HeaderText="Department">
                        <ItemTemplate>                            
                            <asp:Label runat="server" Text='<%#Eval("DepartmentName")%>' ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>                            
                            <asp:LinkButton  runat="server" OnClick="UpdateLinkButton_Click">Update</asp:LinkButton>
                            <asp:LinkButton  runat="server" OnClick="DeleteLinkButton_Click">Delete</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    

                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>

    </div>
    </form>
</body>
</html>
