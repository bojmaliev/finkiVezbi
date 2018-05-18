<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Theme="SkinFile" Inherits="_Default" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 84%;
        }
        .auto-style2 {
            width: 142px;
        }
        .auto-style3 {
            width: 142px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            width: 377px;
        }
        .auto-style5 {
            width: 377px;
        }
        .auto-style6 {
            width: 142px;
            height: 33px;
        }
        .auto-style7 {
            width: 377px;
            height: 33px;
        }
    </style>
    <link href="style/StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Име</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIme" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                    <td rowspan="11">
                        <asp:Panel ID="pnlPanela1" runat="server" BackColor="#FFFF99" ScrollBars="Vertical" Visible="False" Width="350px">
                            Почитуван патнику:<br />
                            <asp:Label ID="lblPatnik" runat="server" Text="Label" Font-Bold="True" ForeColor="Red"></asp:Label>
                            <br />
                            Издадена ви е карта за<br />
                            <asp:Label ID="lblSredstvo" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#000066" Text="Label"></asp:Label>
                            <br />
                            со почетна дестинација<br />
                            <asp:Label ID="lblOd" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#000066" Text="Label"></asp:Label>
                            <br />
                            и крајна дестинација<br />
                            <asp:Label ID="lblDo" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#000066" Text="Label"></asp:Label>
                            <br />
                            Времето на поаѓање ви е
                            <br />
                            <asp:Label ID="lblVreme" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#000066" Text="Label"></asp:Label>
                            <br />
                            Вашето место на седење ќе ви биде во зоната за
                            <asp:Label ID="lblZona" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#000066" Text="Label"></asp:Label>
                            &nbsp;во
                            <asp:Label ID="lblKlasa" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#000066" Text="Label"></asp:Label>
                            &nbsp;класа и во текот на патувањето ќе бидете послужени со
                            <asp:Label ID="lblPosluga" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#000066" Text="Label"></asp:Label>
                            <br />
                            <asp:Image ID="Image1" runat="server" Width="300px" />
                            <br />
                            Ви благодариме на довербата и ви посакуваме среќен пат.</asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Презиме</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPrezime" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Од</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlOd" runat="server">
                            <asp:ListItem>-од каде-</asp:ListItem>
                            <asp:ListItem>Скопје</asp:ListItem>
                            <asp:ListItem>Солун</asp:ListItem>
                            <asp:ListItem>Софиа</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlOd" ErrorMessage="*" InitialValue="-од каде-"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">До</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlDo" runat="server">
                            <asp:ListItem>-до каде-</asp:ListItem>
                            <asp:ListItem>Хелсинки</asp:ListItem>
                            <asp:ListItem>Франкфурт</asp:ListItem>
                            <asp:ListItem>Истанбул</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlDo" ErrorMessage="*" InitialValue="-до каде-"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Датум на тргање</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlDen" runat="server">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlMesec" runat="server">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlGodina" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Време на тргање</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlVreme" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Превозно средство</td>
                    <td class="auto-style5">
                        <asp:ListBox ID="lstSredstvo" runat="server">
                            <asp:ListItem>Авион</asp:ListItem>
                            <asp:ListItem>Воз</asp:ListItem>
                        </asp:ListBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="lstSredstvo" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Зона</td>
                    <td class="auto-style5">
                        <asp:RadioButtonList ID="rblZona" runat="server">
                            <asp:ListItem>Пушачи</asp:ListItem>
                            <asp:ListItem>Непушачи</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="rblZona" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Класа</td>
                    <td class="auto-style5">
                        <asp:RadioButtonList ID="rblKlasa" runat="server">
                            <asp:ListItem>Економска</asp:ListItem>
                            <asp:ListItem>Бизнис</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="rblKlasa" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Послуга</td>
                    <td class="auto-style5">
                        <asp:CheckBoxList ID="cblPosluga" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Пијалок</asp:ListItem>
                            <asp:ListItem>Кафе</asp:ListItem>
                            <asp:ListItem>Оброк</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7">
                        <asp:Button ID="btnPodnesi" runat="server" OnClick="btnPodnesi_Click" Text="Поднеси" />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
