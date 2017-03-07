<%@ Page Title="Telefoncu" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DBSil.aspx.cs" Inherits="DBSil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Table ID="Table1" runat="server" Width="760px" CssClass="filters">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="sil_id" runat="server" Width="400px"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" runat="server" ControlToValidate="sil_id" ErrorMessage="Boş olamaz."> </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ForeColor="Red"  ControlToValidate="sil_id" runat="server" ErrorMessage="Hatalı giriş." ValidationExpression="([0-9])[0-9]*[.]?[0-9]*"></asp:RegularExpressionValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="status" Visible="false" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="sil" runat="server" Text="Sil" OnClick="sil_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label Text="" runat="server" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>

