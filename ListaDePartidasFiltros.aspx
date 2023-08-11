<%@ Page Title="Lista de partidas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaDePartidasFiltros.aspx.cs" Inherits="RPGMeet.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class="d-flex justify-content-start">
       <asp:RadioButtonList ID="rbListDisponibilidad" runat="server">
    <asp:ListItem Text="Lunes" Value="Lunes" />
    <asp:ListItem Text="Martes" Value="Martes" />
    <asp:ListItem Text="Miércoles" Value="Miércoles" />
    <asp:ListItem Text="Jueves" Value="Jueves" />
    <asp:ListItem Text="Viernes" Value="Viernes" />
    <asp:ListItem Text="Sábado" Value="Sábado" />
    <asp:ListItem Text="Domingo" Value="Domingo" />
</asp:RadioButtonList>

<asp:RadioButtonList ID="rbListNumeroJugadores" runat="server">
    <asp:ListItem Text="Corto (1 a 3 jugadores)" Value="Corto" />
    <asp:ListItem Text="Mediano (3 a 7 jugadores)" Value="Mediano" />
    <asp:ListItem Text="Grande (7 a 12 jugadores)" Value="Grande" />
    <asp:ListItem Text="Extra Grande (12 o más jugadores)" Value="ExtraGrande" />
</asp:RadioButtonList>

<asp:RadioButtonList ID="rbListEstadoPartida" runat="server">
    <asp:ListItem Text="Iniciada" Value="Iniciada" />
    <asp:ListItem Text="Por Iniciar" Value="PorIniciar" />
    <asp:ListItem Text="Acabada" Value="Acabada" />
</asp:RadioButtonList>
          </div>
</asp:Content>
