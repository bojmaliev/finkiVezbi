<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" align="center">
                <tr>
                    <td>
                        <asp:Panel ID="pnlPanela" runat="server" BackColor="Yellow" Font-Names="Arial">
                            <asp:TextBox ID="txtOperand1" runat="server" EnableViewState="False"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="txtOperand2" runat="server" AutoPostBack="True" OnTextChanged="txtOperand2_TextChanged"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblRezultat" runat="server" Text="Label" EnableViewState="False"></asp:Label>
                            <br />
                            <asp:Button ID="btnSoberi" runat="server" Text="Собери" />
                        </asp:Panel>
                        <asp:CheckBox ID="chbVidlivo" runat="server" AutoPostBack="True" OnCheckedChanged="chbVidlivo_CheckedChanged" Text="Видливо" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
