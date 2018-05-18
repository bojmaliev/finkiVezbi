<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblVreme1" runat="server" Font-Names="Arial" Font-Size="Medium" ForeColor="Navy" Text="Kонтрола за приказ на време"></asp:Label>
    <br />
    <asp:Label ID="lblVreme2" runat="server" Font-Names="Arial" Font-Size="Medium" ForeColor="Navy" Text="Label"></asp:Label>
    <asp:Button ID="btnVreme" runat="server" Font-Names="Arial" Font-Size="Medium" ForeColor="Navy" OnClick="btnVreme_Click" Text="Button" />
    <br />
    <br />
    <asp:HyperLink ID="hlSledno" runat="server" Font-Names="Arial" Font-Size="Medium" NavigateUrl="Default2.aspx">HyperLink</asp:HyperLink>
    <br />
</asp:Content>

