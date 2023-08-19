<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PruebaListaPartidas.aspx.cs" Inherits="RPGMeet.PruebaListaPartidas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- meter este style en el sire.master/head acciendo referencia a la carpeta de estilos Home.css -->
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
            padding: 2vh 3vh 2vh 3vh;
        }
        .imagen-perfil {
            width: 2.25rem;
            height: 2.25rem;
            margin: 0.25vh 0.5rem 0.25vh 0.5rem;
            border: 0 0.5rem 0 0.5rem;
            max-width: 100%;
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
        .my-grey{
            background-color: #D9D9D9;
        }
    </style>

    <asp:Panel CssClass="container" runat="server">
        <asp:Panel CssClass="row" runat="server">
            <asp:Panel ID="pnlFiltros" CssClass="col-2" runat="server">

            </asp:Panel>
            <asp:Panel ID="pnlPartidas" CssClass="col-10" runat="server">
                <asp:Panel CssClass="row" runat="server">
                    <asp:Panel ID="partida1" CssClass="col-md-12 col-xl-5 ms-4 me-4 partida bg-grey" runat="server">
                        <asp:Panel CssClass="row" runat="server">
                            <asp:Panel ID="pnlTituloPartida" CssClass="col-5 h4" runat="server">
                                <asp:Label ID="lblTituloPartida1" runat="server" Text="Titulo partida"></asp:Label>
                            </asp:Panel>
                            <asp:Panel ID="pnlFotoPerfil" CssClass="col-7 d-flex justify-content-end" runat="server">
                                <asp:Panel CssClass="d-inline" runat="server">
                                </asp:Panel>
                            </asp:Panel>
                            <asp:Panel ID="pnlDescripcion" CssClass="col-6 rounded-pill" runat="server">
                                <asp:Label CssClass="h4 d-block" runat="server">Descripción: </asp:Label>
                                <asp:Label ID="lblDescripcion" runat="server" Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown">
                                </asp:Label>
                            </asp:Panel>
                            <asp:Panel ID="pnlInfoCorta" CssClass="col-6 d-flex justify-content-end" runat="server">
                                <asp:Panel CssClass="row" runat="server">
                                    <asp:Panel CssClass="col-12 col-md-6 d-flex justify-content-md-end" runat="server">
                                        <asp:Label runat="server" Text="Disponibilidad:"></asp:Label>
                                    </asp:Panel>
                                    <asp:Panel CssClass="col-12 col-md-6" runat="server">
                                        <asp:Label ID="lblDisponibilidad" runat="server" Text="Fin de semana"></asp:Label>
                                    </asp:Panel>

                                    <asp:Panel CssClass="col-12 col-md-6 d-flex justify-content-md-end" runat="server">
                                        <asp:Label runat="server" Text="Tematica:"></asp:Label>
                                    </asp:Panel>
                                    <asp:Panel CssClass="col-12 col-md-6" runat="server">
                                        <asp:Label ID="lblTematica" runat="server" Text="Medieval"></asp:Label>
                                    </asp:Panel>

                                    <asp:Panel CssClass="col-12 col-md-6 d-flex justify-content-md-end" runat="server">
                                        <asp:Label runat="server" Text="Jugadores:"></asp:Label>
                                    </asp:Panel>
                                    <asp:Panel CssClass="col-12 col-md-6" runat="server">
                                        <asp:Label ID="lblNumJugadores" runat="server" Text="4/7"></asp:Label>
                                    </asp:Panel>
                                </asp:Panel>
                            </asp:Panel>
                            <asp:Panel ID="pnlBtnInfo" CssClass="col-6" runat="server">
                                <asp:Button ID="Button1" class="btn btn-partida" runat="server" Text="Mas información" />
                            </asp:Panel>
                            <asp:Panel ID="pnlBtnApuntarse" CssClass="col-6 d-flex justify-content-end" runat="server">
                                <asp:Button ID="Button2" class="btn btn-partida" runat="server" Text="Apuntarse" />
                            </asp:Panel>
                        </asp:Panel>
                    </asp:Panel>
                        <asp:Panel ID="Panel1" CssClass="col-md-12 col-xl-5 ms-4 me-4 partida bg-grey" runat="server">
                            <asp:Panel CssClass="row" runat="server">
                                <asp:Panel ID="Panel2" CssClass="col-5 h4" runat="server">
                                    <asp:Label ID="Label1" runat="server" Text="Titulo partida"></asp:Label>
                                </asp:Panel>
                                <asp:Panel ID="Panel3" CssClass="col-7 d-flex justify-content-end" runat="server">
                                    <asp:Panel CssClass="d-inline" runat="server">
                                    </asp:Panel>
                                </asp:Panel>
                                <asp:Panel ID="Panel4" CssClass="col-6 rounded-pill" runat="server">
                                    <asp:Label CssClass="h4 d-block" runat="server">Descripción: </asp:Label>
                                    <asp:Label ID="Label2" runat="server" Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                                        Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown">
                                    </asp:Label>
                                </asp:Panel>
                                <asp:Panel ID="Panel5" CssClass="col-6 d-flex justify-content-end" runat="server">
                                    <asp:Panel CssClass="row" runat="server">
                                        <asp:Panel CssClass="col-12 col-md-6 d-flex justify-content-end" runat="server">
                                            <asp:Label runat="server" Text="Disponibilidad:"></asp:Label>
                                        </asp:Panel>
                                        <asp:Panel CssClass="col-6" runat="server">
                                            <asp:Label ID="Label3" runat="server" Text="Fin de semana"></asp:Label>
                                        </asp:Panel>

                                        <asp:Panel CssClass="col-12 col-md-6 d-flex justify-content-end" runat="server">
                                            <asp:Label runat="server" Text="Tematica:"></asp:Label>
                                        </asp:Panel>
                                        <asp:Panel CssClass="col-12 col-md-6" runat="server">
                                            <asp:Label ID="Label4" runat="server" Text="Medieval"></asp:Label>
                                        </asp:Panel>

                                        <asp:Panel CssClass="col-12 col-md-6 d-flex justify-content-end" runat="server">
                                            <asp:Label runat="server" Text="Jugadores:"></asp:Label>
                                        </asp:Panel>
                                        <asp:Panel CssClass="col-12 col-md-6" runat="server">
                                            <asp:Label ID="Label5" runat="server" Text="4/7"></asp:Label>
                                        </asp:Panel>
                                    </asp:Panel>
                                </asp:Panel>
                                <asp:Panel ID="Panel6" CssClass="col-6" runat="server">
                                    <asp:Button ID="Button3" class="btn btn-partida" runat="server" Text="Mas información" />
                                </asp:Panel>
                                <asp:Panel ID="Panel7" CssClass="col-6 d-flex justify-content-end" runat="server">
                                    <asp:Button ID="Button4" class="btn btn-partida" runat="server" Text="Apuntarse" />
                                </asp:Panel>
                            </asp:Panel>
                        </asp:Panel>
                    </asp:Panel>
                </asp:Panel>
            </asp:Panel>
        </asp:Panel>
</asp:Content>
