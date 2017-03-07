<%@ Page Title="Telefoncu" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Urun.aspx.cs" Inherits="Urun" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div>
        <asp:table id="Table1" runat="server" width="760px">
            <asp:TableRow>
                <asp:TableCell VerticalAlign="Middle">
                </asp:TableCell>
                <asp:TableCell VerticalAlign="Middle" HorizontalAlign="Center">
                </asp:TableCell>
            </asp:TableRow>
        </asp:table>
   </div>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" Width="100" >
        <asp:ListItem Selected="True">1</asp:ListItem>
        <asp:ListItem >2</asp:ListItem>
        <asp:ListItem >3</asp:ListItem>
        <asp:ListItem >4</asp:ListItem>
        <asp:ListItem >5</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button cssClass="aramaButonu" ID="satinAl" runat="server" Text="Sepete Ekle" OnClick="satinAl_Click" />
    <br /><br /><br /><br /><br />
    <asp:Button cssClass="aramaButonu" ID="Button1" runat="server" Text="Alışverişe Devam et" OnClick="Button1_Click"/>
    <br /><br /><br /><br /><br />
    <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
    <br />
</asp:Content>

