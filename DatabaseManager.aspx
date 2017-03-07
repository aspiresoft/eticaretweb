<%@ Page Title="Telefoncu" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DatabaseManager.aspx.cs" Inherits="DatabaseManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/DBEkle.aspx" runat="server">
        <asp:Image ID="Image1" runat="server" Width="240px" Height="240px" ImageUrl="~/Images/add.png"/>
    </asp:HyperLink>
    <asp:HyperLink ID="HyperLink2" NavigateUrl="~/DBAra.aspx" runat="server">
        <asp:Image ID="Image2" runat="server" Width="240px" Height="240px" ImageUrl="~/Images/search.png"/>
    </asp:HyperLink>
    <asp:HyperLink ID="HyperLink3" NavigateUrl="~/DBSil.aspx" runat="server">
        <asp:Image ID="Image3" runat="server" Width="240px" Height="240px" ImageUrl="~/Images/delete.png"/>
    </asp:HyperLink>


</asp:Content>

