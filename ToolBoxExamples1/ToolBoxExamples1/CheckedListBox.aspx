<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckedListBox.aspx.cs" Inherits="ToolBoxExamples1.CheckedListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>B</asp:ListItem>
            <asp:ListItem>D</asp:ListItem>
            <asp:ListItem>E</asp:ListItem>
            <asp:ListItem>F</asp:ListItem>
        </asp:CheckBoxList>


        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>

    </div>
    </form>
</body>
</html>
