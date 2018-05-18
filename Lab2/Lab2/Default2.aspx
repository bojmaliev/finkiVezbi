<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 43%;
        }
        .auto-style3 {
            width: 193px;
        }
        .auto-style5 {
            width: 193px;
            height: 29px;
        }
        .auto-style6 {
            width: 135px;
            height: 29px;
        }
        .auto-style7 {
            height: 29px;
        }
        .auto-style9 {
            width: 135px;
        }
        .auto-style10 {
            width: 100%;
        }
        .auto-style11 {
            width: 144px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Големи букви, евентуално _ и 2 броеви" ValidationExpression="[A-Z]+_{0,1}\d{2}"></asp:RegularExpressionValidator>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Македонски телефонски број. пр. +38978989478" ValidationExpression="\+3897[0125678]\d{6}"></asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            <asp:MultiView ID="mvNaracka" runat="server">
                <asp:View ID="vStep1" runat="server">
                    <asp:Label ID="Label1" runat="server" Text="Ова е првиот чекор"></asp:Label>
                    <br />
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">Име</td>
                            <td class="auto-style9">
                                <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtIme" Display="None" ErrorMessage="Името е задолжително"></asp:RequiredFieldValidator>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Презиме</td>
                            <td class="auto-style9">
                                <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPrezime" Display="None" ErrorMessage="Презимето е задолжително"></asp:RequiredFieldValidator>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">FINKI ID</td>
                            <td class="auto-style9">
                                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" Display="None" ErrorMessage="FinkiId е задолжително"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtEmail" Display="None" ErrorMessage="Неправилен формат на FINKI ID" ValidationExpression="[a-z0-9_]*\.{0,1}[a-z0-9_]*"></asp:RegularExpressionValidator>
                            </td>
                            <td>@finki.ukim.mk</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Лозинка</td>
                            <td class="auto-style9">
                                <asp:TextBox ID="txtLozinka1" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtLozinka1" Display="None" ErrorMessage="Лозинката е задолжително"></asp:RequiredFieldValidator>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Потврда</td>
                            <td class="auto-style6">
                                <asp:TextBox ID="txtLozinka2" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtLozinka1" ControlToValidate="txtLozinka2" Display="None" ErrorMessage="Двете лозинки треба да се еднакви"></asp:CompareValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtLozinka2" Display="None" ErrorMessage="Лозинката е задолжително"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style7"></td>
                        </tr>
                    </table>
                    <br />
                    <asp:Button ID="goTo2" runat="server" Text="&gt;&gt;" OnClick="goTo2_Click" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </asp:View>
                <asp:View ID="vStep2" runat="server">
                    <asp:Label ID="Label2" runat="server" Text="Ова е вториот чекор"></asp:Label>
                    <br />
                    <table class="auto-style10">
                        <tr>
                            <td class="auto-style11">Адреса</td>
                            <td>
                                <asp:TextBox ID="txtAdresa" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAdresa" Display="None" ErrorMessage="Адресата е задолжителна"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">Тел</td>
                            <td>
                                <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtTelefon" Display="None" ErrorMessage="Телефонот мора да биде во формат 070000000" ValidationExpression="07[0125678]\d{6}"></asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtTelefon" Display="None" ErrorMessage="Телефонот е задолжителен"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">Пол</td>
                            <td>
                                <asp:RadioButtonList ID="rblPol" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem>М</asp:ListItem>
                                    <asp:ListItem>Ж</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="rblPol" Display="None" ErrorMessage="Полот е задолжителен"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">Датум на раѓање</td>
                            <td>
                                <asp:Calendar ID="calDatum" runat="server" OnSelectionChanged="calDatum_SelectionChanged" OnVisibleMonthChanged="calDatum_VisibleMonthChanged" SelectedDate="2018-03-23" VisibleDate="2018-03-23"></asp:Calendar>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:Button ID="goTo1" runat="server" Text="&lt;&lt;" OnClick="goTo1_Click" />
                    <asp:Button ID="goTo3" runat="server" Text="&gt;&gt;" OnClick="goTo3_Click" />
                    <br />
                    <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" />
                </asp:View>
                <asp:View ID="vStep3" runat="server">
                    <asp:Label ID="Label4" runat="server" Text="Ова е третиот чекор"></asp:Label>
                    <br />
                    Занимање<br />
                    <asp:DropDownList ID="ddlZanimanje" runat="server">
                        <asp:ListItem>-занимање-</asp:ListItem>
                        <asp:ListItem>Програмер</asp:ListItem>
                        <asp:ListItem>Професор</asp:ListItem>
                        <asp:ListItem>Земјоделец</asp:ListItem>
                        <asp:ListItem>Маркетинг агент</asp:ListItem>
                        <asp:ListItem>Политичар</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddlZanimanje" Display="None" ErrorMessage="Занимање е задолжително" InitialValue="-занимање-"></asp:RequiredFieldValidator>
                    <br />
                    Години на вршење на избраната дејност<br />
                    <asp:TextBox ID="txtGodiniV" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtGodiniV" Display="None" ErrorMessage="Години извршување е задолжително"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtGodiniV" Display="None" ErrorMessage="Години на врешење може да биде само број" ValidationExpression="\d{0,2}"></asp:RegularExpressionValidator>
                    <br />
                    <asp:Button ID="goTo2prev" runat="server" Text="&lt;&lt;" OnClick="goTo2prev_Click" />
                    <asp:Button ID="goTo4" runat="server" OnClick="goTo4_Click" Text="Поднеси" />
                    <asp:ValidationSummary ID="ValidationSummary3" runat="server" ForeColor="Red" />
                </asp:View>
                <asp:View ID="vStep4" runat="server">
                    <asp:Label ID="Label5" runat="server" Text="Ова е четвртиот"></asp:Label>
                    <br />
                    Креиран е корисник со:
                    <asp:Label ID="lblUser" runat="server" Text="Label"></asp:Label>
                    @finki.ukim.mk<br />
                    <asp:Button ID="goTo3prev" runat="server" OnClick="goTo3prev_Click" style="height: 29px" Text="Врати се на почеток" />
                </asp:View>
            </asp:MultiView>
            <br />
        </div>
    </form>
</body>
</html>
