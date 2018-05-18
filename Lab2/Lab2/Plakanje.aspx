<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Plakanje.aspx.cs" Inherits="Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Sodrzinka na kosnicka</p>
    <p>
        <asp:ListBox ID="lbKosnicka" runat="server"></asp:ListBox>
    </p>
    <p>
        &nbsp;</p>
    VKupno za plakanje:
    <asp:Label ID="Vkupno" runat="server" Text="Label"></asp:Label>
</asp:Content>

