<%@ Page Title="Telefoncu" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DBEkle.aspx.cs" Inherits="DBEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Table id="Table1" runat="server" width="760px" CssClass="filters">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="ekle_label_1" runat="server">İsmi</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="ekle_isim" Width="400px"  runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="ekle_check_1" ForeColor="Red" ControlToValidate="ekle_isim" runat="server" ErrorMessage="Boş olamaz."></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="ekle_label_2" runat="server">Fiyatı</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="ekle_fiyat" Width="400px"  runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="ekle_check_2" ForeColor="Red" runat="server" ControlToValidate="ekle_fiyat" ErrorMessage="Boş olamaz."> </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="ekle_check_3" ForeColor="Red"  ControlToValidate="ekle_fiyat" runat="server" ErrorMessage="Hatalı giriş." ValidationExpression="([0-9])[0-9]*[,]?[0-9]*"></asp:RegularExpressionValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="ekle_label_3" runat="server">Açıklaması</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="ekle_desc" Width="400px"  runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
               <asp:RequiredFieldValidator ID="ekle_check_4" ForeColor="Red" runat="server" ControlToValidate="ekle_desc" ErrorMessage="Boş olamaz."> </asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="ekle_label_4" runat="server">Uzunuğu</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="ekle_length" Width="400px" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="ekle_check_5" ForeColor="Red" runat="server" ControlToValidate="ekle_length" ErrorMessage="Boş olamaz."> </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="ekle_check_6" ForeColor="Red"  ControlToValidate="ekle_length" runat="server" ErrorMessage="Hatalı giriş." ValidationExpression="([0-9])[0-9]*[,]?[0-9]*"></asp:RegularExpressionValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="ekle_label_5" runat="server">Markası</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ekle_firma" Width="400px"  runat="server">
                    <asp:ListItem>APPLE</asp:ListItem>
                    <asp:ListItem>SAMSUNG</asp:ListItem>
                    <asp:ListItem>HTC</asp:ListItem>
                    <asp:ListItem>LG</asp:ListItem>
                    <asp:ListItem>SONY</asp:ListItem>
                    <asp:ListItem>ASUS</asp:ListItem>
                    <asp:ListItem>MICROSOFT</asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="ekle_label_6" runat="server">İşletim Sistemi</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ekle_os" Width="400px" runat="server">
                    <asp:ListItem>WINDOWS</asp:ListItem>
                    <asp:ListItem>IOS</asp:ListItem>
                    <asp:ListItem>ANDROID</asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="ekle_label_7" runat="server">Dahili Hafızası</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ekle_boyut"  Width="400px" runat="server">
                    <asp:ListItem>8GB</asp:ListItem>
                    <asp:ListItem>16GB</asp:ListItem>
                    <asp:ListItem>32GB</asp:ListItem>
                    <asp:ListItem>64GB</asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="ekle_telefon" runat="server" Text="Ekle" OnClick="ekle_telefon_Click" Width="89px"></asp:Button>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    
    <br />
    <asp:Label ID="status" runat="server" Text="Label" Visible="False"></asp:Label>

</asp:Content>

