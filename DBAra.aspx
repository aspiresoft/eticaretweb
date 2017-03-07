<%@ Page Title="Telefoncu" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DBAra.aspx.cs" Inherits="DBAra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Table id="Table1" runat="server" width="760px" CssClass="filters">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label1" Width="200px" runat="server" Text="SQL Sorgusu"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                 <asp:TextBox ID="sorgula_sorgu" runat="server" Width="400px"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="status" Visible="false" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                 <asp:DropDownList ID="sorgula_telefonlistesi" Width="400px" Visible="false" runat="server"></asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                 <asp:Button ID="sorgula_sorgula" runat="server" Text="Sorgula" OnClick="sorgula_sorgula_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>

