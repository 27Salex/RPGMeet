<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateParty.aspx.cs" Inherits="RPGMeet.CreateParty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Crear Partida</h2>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Título:"></asp:Label>
            <asp:TextBox ID="TxtBoxCreateTitle" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Descripción:"></asp:Label>
            <asp:TextBox ID="TxtAreaCreateDesc" runat="server" TextMode="MultiLine"></asp:TextBox>
            &nbsp;</div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Máximo de Jugadores:"></asp:Label>
            <asp:TextBox ID="TxtBoxCreateMaxPly" runat="server" TextMode="Number"></asp:TextBox>
        </div>
        <asp:Label ID="Label3" runat="server" Text="Dias a jugar:"></asp:Label>
        <asp:CheckBoxList ID="SelDays" runat="server">
            <asp:ListItem>Lunes</asp:ListItem>
            <asp:ListItem>Martes</asp:ListItem>
            <asp:ListItem>Miercoles</asp:ListItem>
            <asp:ListItem>Jueves</asp:ListItem>
            <asp:ListItem>Viernes</asp:ListItem>
            <asp:ListItem>Sabado</asp:ListItem>
            <asp:ListItem>Domingo</asp:ListItem>
        </asp:CheckBoxList>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Temática principal:"></asp:Label>
        <asp:DropDownList ID="SelPri" runat="server">

        </asp:DropDownList>

        <asp:Label ID="Label6" runat="server" Text="Temática secundaria:"></asp:Label>
        <asp:DropDownList ID="SelSec" runat="server">

        </asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="Label7" runat="server" Text="Juego:"></asp:Label>
        <asp:DropDownList ID="SelGame" runat="server">
            
        </asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="BtnCreateParty" runat="server" Text="Crear Partida" OnClick="BtnCreateParty_Click" />
    </div>
</asp:Content>
