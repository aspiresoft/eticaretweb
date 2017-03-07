<%@ Page Title="Telefoncu" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 1600px">
        <asp:Table id="Table1" runat="server" width="760px" CssClass="filters">
            <asp:TableRow>
                <asp:TableCell VerticalAlign="Top">
                    <p class="tableText">  MARKA</p>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        <asp:ListItem>APPLE</asp:ListItem>
                        <asp:ListItem>SAMSUNG</asp:ListItem>
                        <asp:ListItem>HTC</asp:ListItem>
                        <asp:ListItem>LG</asp:ListItem>
                        <asp:ListItem>SONY</asp:ListItem>
                        <asp:ListItem>ASUS</asp:ListItem>
                        <asp:ListItem>MICROSOFT</asp:ListItem>
                    </asp:CheckBoxList>
                </asp:TableCell>
                <asp:TableCell VerticalAlign="Top">
                    <p class="tableText">  FİYAT ARALIĞI</p>
                    <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                        <asp:ListItem>0-999</asp:ListItem>
                        <asp:ListItem>1000-1999</asp:ListItem>
                        <asp:ListItem>2000-2999</asp:ListItem>
                        <asp:ListItem>3000-</asp:ListItem>
                    </asp:CheckBoxList>
                </asp:TableCell>
                <asp:TableCell VerticalAlign="Top">
                    <p class="tableText">  İŞLETİM SİSTEMİ</p>
                    <asp:CheckBoxList ID="CheckBoxList3" runat="server">
                        <asp:ListItem>ANDROID</asp:ListItem>
                        <asp:ListItem>WINDOWS</asp:ListItem>
                        <asp:ListItem>IOS</asp:ListItem>
                    </asp:CheckBoxList>
                </asp:TableCell>
                <asp:TableCell VerticalAlign="Top">
                    <p class="tableText">  DAHİLİ HAFIZA</p>
                    <asp:CheckBoxList ID="CheckBoxList4" runat="server">
                        <asp:ListItem>8GB</asp:ListItem>
                        <asp:ListItem>16GB</asp:ListItem>
                        <asp:ListItem>32GB</asp:ListItem>
                        <asp:ListItem>64GB</asp:ListItem>
                    </asp:CheckBoxList>
                </asp:TableCell>
                <asp:TableCell VerticalAlign="Top" HorizontalAlign="Center">
                    <p class="tableText">  EKRAN BÜYÜKLÜĞÜ</p>
                    <asp:CheckBoxList ID="CheckBoxList5" runat="server">
                        <asp:ListItem>4-4,5 inç</asp:ListItem>
                        <asp:ListItem>4,5-5 inç</asp:ListItem>
                        <asp:ListItem>5-5,5 inç</asp:ListItem>
                        <asp:ListItem>5,5-6 inç</asp:ListItem>
                    </asp:CheckBoxList>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
        
        <asp:table id="Table3" runat="server" width="760px" class="filters">
            <asp:TableRow>
                <asp:TableCell>
                    <p>  SIRALAMA ÖLÇÜTÜ</p>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Selected="True">Fiyat</asp:ListItem>
                        <asp:ListItem>İsim</asp:ListItem>
                        <asp:ListItem>Ekran Büyüklüğü</asp:ListItem>
                        <asp:ListItem>Dahili Hafıza</asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
                <asp:TableCell>
                    <p>  SIRALAMA KRITERİ</p>
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem Selected="True">Azalan(Düşen)</asp:ListItem>
                        <asp:ListItem>Artan(Yükselen)</asp:ListItem>
                     </asp:DropDownList>
                    <br />
                </asp:TableCell>
            </asp:TableRow>
        </asp:table>
        <br /><br />
        <asp:button id="aramaButonu" runat="server" text="ARA" cssclass="aramaButonu" onclick="aramaButonu_Click" />
        <br /><br /><br /> <br /><br />
        <asp:label id="Label1" runat="server" text="Label" Visible="false"></asp:label>
        <br /><br />
        <asp:table id="Table2" runat="server"></asp:table>
        <br />
        <asp:DropDownList ID="indexer" Width="100" runat="server" Visible=" false"  OnSelectedIndexChanged="indexChanger" AutoPostBack="True"></asp:DropDownList>
        <br /><br />
     </div>
</asp:Content>

