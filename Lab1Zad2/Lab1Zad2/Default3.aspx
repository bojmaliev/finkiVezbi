<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtPoraka" runat="server" ReadOnly="True" Rows="5" TextMode="MultiLine" OnTextChanged="txtPoraka_TextChanged"></asp:TextBox>
            <br />
            <asp:Button ID="btnProveri" runat="server" OnClick="btnProveri_Click" Text="Провери" />
            <asp:Button ID="btnPrvaStrana" runat="server" EnableViewState="False" Text="Прва Страна" Enabled="False" OnClick="btnPrvaStrana_Click" />
        </div>
    </form>
</body>
</html>
