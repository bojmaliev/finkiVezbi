<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Katalog.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:HyperLink ID="HyperLink1" OnClick="Hyper1_Click"  runat="server" NavigateUrl="~/Proizvodi.aspx?id=1&amp;ime=Возила">Возила</asp:HyperLink>
&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Proizvodi.aspx?id=2&amp;ime=Технологија">Технологија</asp:HyperLink>
&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Proizvodi.aspx?id=3&amp;ime=Недвижности">Недвижности</asp:HyperLink>
</asp:Content>

