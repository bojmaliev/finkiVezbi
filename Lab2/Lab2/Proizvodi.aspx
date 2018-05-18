<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Proizvodi.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td colspan="2">
                <asp:Label ID="lblKategorija" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Производи</td>
            <td>Цени</td>
        </tr>
        <tr>
            <td>
                <asp:ListBox ID="lbProizvodi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lbProizvodi_SelectedIndexChanged"></asp:ListBox>
            </td>
            <td>
                <asp:ListBox ID="lbCeni" runat="server"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Katalog.aspx">Каталог</asp:HyperLink>
                <asp:Button ID="btnDodadiKosnicka" runat="server" OnClick="btnDodadiKosnicka_Click" Text="Dodadi vo kosnicka" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:ListBox ID="lbProizvodiKosnicka" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lbProizvodiKosnicka_SelectedIndexChanged"></asp:ListBox>
            </td>
            <td>
                <asp:ListBox ID="lbCeniKosnicka" runat="server"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnKupi" runat="server" OnClick="btnKupi_Click" Text="Kupi" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

