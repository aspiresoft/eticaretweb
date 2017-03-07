<%@ Page Title="Telefoncu" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Sepet.aspx.cs" Inherits="Sepet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Table ID="Table1" runat="server" CssClass="filters"></asp:Table>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Total"></asp:Label>
    <br /><br />
    <asp:Button ID="Button1" CssClass="aramaButonu" runat="server" Text="Checkout" OnClick="Button1_Click" />
    <br /><br /><br /><br /><br />
    <asp:Button ID="Button2" CssClass="aramaButonu" runat="server" Text="Alışverişe devam et" OnClick="Button2_Click" />
    <br /><br /><br /><br /><br />
</asp:Content>

