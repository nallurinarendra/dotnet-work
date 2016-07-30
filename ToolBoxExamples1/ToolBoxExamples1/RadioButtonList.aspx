<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButtonList.aspx.cs" Inherits="ToolBoxExamples1.RadioButtonList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Select Gender : <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    </div>
    </form>
</body>
</html>
