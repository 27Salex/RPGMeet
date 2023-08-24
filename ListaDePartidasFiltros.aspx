<%@ Page Title="Lista de partidas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaDePartidasFiltros.aspx.cs" Inherits="RPGMeet.ListaDePartidasFiltros" %>

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
        .partida{
            border-radius: 3vh;
        }
        .imagen-perfil {
            width: 2.25rem;
            height: 2.25rem;
            margin-left: 0.5rem;
            margin-bottom: 0.5rem;
        }
        .joined {
            background-color: #8DD761;
        }
        .empty {
            background-color: #D76161;
        }
        .btn-partida {
            background-color: #8B8EDF;
        }
        .slider {
            width: 800px;
            height: 500px;
            background-color: var(--grey);
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
                            <h3>Disponibilidad</h3>
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
                            <h3>Número de jugadores </h3>
                            <asp:TextBox ID="txtMaxJugadores" runat="server" CssClass="form-control" type="number" max="50"></asp:TextBox>
                           
                        </div>

                        <!-- Filtro Temática -->
                        <div class="form-group">
                            <h3>Temática</h3>
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
                            <asp:Button ID="btnAplicarFiltros" runat="server" Text="Button" OnClick="btnAplicarFiltros_Click" />
                            <br />
                            <asp:Label ID="lblPrueba" runat="server" Text="Label"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-9">
                <div class="row">
                    <!-- Partida de Ejemplo -->
                    <div class="col-6 partida bg-grey pt-3 pb-3 m-1 d-flex justify-content-start">
                        <div class="row">
                            <!-- Encabezado -->
                            <div class="col-6 rounded-pill">
                                <h2>Titulo partida</h2>
                            </div>
                            <div class="col-6 d-flex justify-content-end">
                                <!-- Imágenes de Perfil -->
                                <img class="imagen-perfil joined rounded-circle" src="Img/pngegg.png" alt="fotoDePerfil"/>
                                <!-- Otras imágenes de perfil -->
                            </div>

                            <!-- Descripción -->
                            <div class="col-6">
                                <h4>Descripcíón breve:</h4>
                                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown </p>
                            </div>

                            <!-- Detalles -->
                            <div class="col-6 d-flex justify-content-end">
                                <div>
                                    <asp:Label ID="lblDisponibilidad" class="d-block" runat="server" Text="Disponibilidad: Fin de semana"></asp:Label>
                                    <asp:Label ID="Label1" class="d-block" runat="server" Text="Tematica: Medieval"></asp:Label>
                                    <asp:Label ID="Label2" class="d-block" runat="server" Text="Jugadores: 4/7"></asp:Label>
                                </div>
                            </div>

                            <!-- Botones -->
                            <div class="col-6">
                                <asp:Button ID="Button1" class="btn btn-partida" runat="server" Text="Mas información" />
                            </div>
                            <div class="col-6 d-flex justify-content-end">
                                <asp:Button ID="Button2" class="btn btn-partida" runat="server" Text="Apuntarse" />
                       </div>
                </div>
                    </div>
                    <div class="col-6 partida bg-grey pt-3 pb-3 m-1 d-flex justify-content-end">
                        <div class="row">
                            <!-- Encabezado -->
                            <div class="col-6 rounded-pill">
                                <h2>Titulo partida</h2>
                            </div>
                            <div class="col-6 d-flex justify-content-end">
                                <!-- Imágenes de Perfil -->
                                <img class="imagen-perfil joined rounded-circle" src="Img/pngegg.png" alt="fotoDePerfil"/>
                                <!-- Otras imágenes de perfil -->
                            </div>

                            <!-- Descripción -->
                            <div class="col-6">
                                <h4>Descripcíón breve:</h4>
                                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown </p>
                            </div>

                            <!-- Detalles -->
                            <div class="col-6 d-flex justify-content-end">
                                <div>
                                    <asp:Label ID="Label3" class="d-block" runat="server" Text="Disponibilidad: Fin de semana"></asp:Label>
                                    <asp:Label ID="Label4" class="d-block" runat="server" Text="Tematica: Medieval"></asp:Label>
                                    <asp:Label ID="Label5" class="d-block" runat="server" Text="Jugadores: 4/7"></asp:Label>
                                </div>
                            </div>

                            <!-- Botones -->
                            <div class="col-6">
                                <asp:Button ID="Button3" class="btn btn-partida" runat="server" Text="Mas información" />
                            </div>
                            <div class="col-6 d-flex justify-content-end">
                                <asp:Button ID="Button4" class="btn btn-partida" runat="server" Text="Apuntarse" />
                       </div>
                </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>
