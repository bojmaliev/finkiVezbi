<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="form1"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" Display="None" ErrorMessage="RegularExpressionValidator" ValidationExpression="07[0-2|5-8]\d{6}" ValidationGroup="form1"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="form1" Display="None" ErrorMessage="RequiredFieldValidator" ValidationGroup="form1"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" ValidationGroup="form1" />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="form1" />
    </form>
</body>
</html>
