<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownListExample.aspx.cs" Inherits="ToolBoxExamples1.DropDownListExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Raju</asp:ListItem>
            <asp:ListItem>Kumar</asp:ListItem>
            <asp:ListItem>Prakash</asp:ListItem>
            <asp:ListItem>Lakshmi</asp:ListItem>
            <asp:ListItem>Rama</asp:ListItem>
        </asp:DropDownList>

        <br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
