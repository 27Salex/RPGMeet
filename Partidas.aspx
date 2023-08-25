<%@ Page Title="Lista de partidas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Partidas.aspx.cs" Inherits="RPGMeet.Partidas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
     :root {
        --grey: #D9D9D9;
    }
    .bg-grey{
        background-color: var(--grey);
    }

    div[class*="col"] {
        margin: 1vh 0 1vh 0;
    }
    .tarjeta{
        border-radius: 3vh;
        padding: 2vh 3vh 2vh 3vh;
    }
    .imagen-perfil {
        width: 2.25rem;
        height: 2.25rem;
        margin: 0.25vh 0.5rem 0.25vh 0.5rem;
        border: 0 0.5rem 0 0.5rem;
        max-width: 100%;
    }
    .btn-partida {
        background-color: #8B8EDF;
    }
    .slider {
        width: 800px;
        height: 500px;
        background-color: var(--grey);
    }
    .my-grey{
        background-color: #D9D9D9;
    }
    .scrollable-panel {
        max-height: 700px; 
        overflow-y: auto; 
    }
</style>
<div class="container">
    <div class="row">
        <div class="col-md-3">
            <div class="row">
                <div class="sidebar">
                    <h2>Filtros</h2>

                    <!-- Filtro Disponibilidad -->
                    <div class="form-group">
                        <h4>Disponibilidad</h4>
                        <asp:CheckBoxList ID="chkListDisponibilidad" CssClass="form-check" runat="server" >
                            <asp:ListItem Text="Lunes" Value="Lunes" />
                            <asp:ListItem Text="Martes" Value="Martes" />
                            <asp:ListItem Text="Miércoles" Value="Miercoles" />
                            <asp:ListItem Text="Jueves" Value="Jueves" />
                            <asp:ListItem Text="Viernes" Value="Viernes" />
                            <asp:ListItem Text="Sábado" Value="Sabado" />
                            <asp:ListItem Text="Domingo" Value="Domingo" />
                        </asp:CheckBoxList>
                    </div>

                    <!-- Filtro Número de Jugadores -->
                    <div class="form-group">
                        <h4>Número de jugadores </h4>
                        <asp:TextBox ID="txtMaxJugadores" runat="server" CssClass="form-control" type="number" max="10" min="2"></asp:TextBox>
                    </div>

                    <!-- Filtro Temática -->
                    <div class="form-group">
                        <h4>Temática</h4>
                        <asp:CheckBoxList ID="cbListTematica" CssClass="form-check" runat="server">
                            <asp:ListItem Text="Fantasía medieval" Value="FantasiaMedieval" />
                            <asp:ListItem Text="Ciencia ficción espacial" Value="CienciaFiccionEspacial" />
                            <asp:ListItem Text="Mundo postapocalíptico" Value="MundoPostapocaliptico" />
                            <asp:ListItem Text="Ciberpunk" Value="Ciberpunk" />
                            <asp:ListItem Text="Superhéroes" Value="Superheroes" />
                            <asp:ListItem Text="Piratas y corsarios" Value="PiratasCorsarios" />
                            <asp:ListItem Text="Viajes en el tiempo" Value="ViajesTiempo" />
                            <asp:ListItem Text="Mitología nórdica" Value="MitologiaNordica" />
                            <asp:ListItem Text="Espionaje y conspiraciones" Value="EspionajeConspiraciones" />
                            <asp:ListItem Text="Fantasía oscura" Value="FantasiaOscura" />
                        </asp:CheckBoxList>
                        <br />
                        <asp:Button ID="btnAplicarFiltros" runat="server" Text="Aplicar filtros" OnClick="btnAplicarFiltros_Click" />
                        <br />
                    </div>
                </div>
            </div>
        </div>
        <asp:Panel ID="pnlPartidas" CssClass="col-9" runat="server">
            <asp:Panel ID="rowPartidas" CssClass="row" runat="server">
            </asp:Panel>
        </asp:Panel>
    </div>
</div>
</asp:Content>
