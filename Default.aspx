<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RPGMeet._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <!-- meter este style en el sire.master/head acciendo referencia a la carpeta de estilos Home.css -->
        <style>
            .imagen-perfil {
                width: 2.25rem;
                height: 2.25rem;
                margin-right: 0.5rem;
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
                background-color: #B0B0B0;
            }
        </style>
        <div class="row m-3">
            <div class="col-6">
                <h2>Nombre App</h2>
                <p>Expliación de la página: consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Morbi tristique senectus et netus. Ut venenatis tellus in metus. Id diam maecenas ultricies mi eget mauris pharetra et. Ullamcorper dignissim cras tincidunt lobortis.</p>
            </div>
            <div class="col-6">
                <img />
            </div>
            <asp:Button ID="btnCrearCuenta1" runat="server" Text="Crear cuenta" />
        </div>

        <div class="row m-3">
            <div class="col-3">
                <h2>Conoce gente:</h2>
                <p>Expliación de la página:consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Morbi tristique senectus et netus. </p>
            </div>
            <div class="col-9">
                <div class="row">
                    <div class="col-6 rounded-pill" CssClass="background-color: #D9D9D9">
                        <h2>Titulo partida</h2>
                    </div>
                    <div class="col-6">
                        <img class="imagen-perfil joined rounded-circle" src="Img/pngegg.png" alt="fotoDePerfil"/>
                        <img class="imagen-perfil joined rounded-circle" src="Img/pngegg.png" alt="fotoDePerfil"/>
                        <img class="imagen-perfil joined rounded-circle" src="Img/pngegg.png" alt="fotoDePerfil"/>
                        <img class="imagen-perfil joined rounded-circle" src="Img/pngegg.png" alt="fotoDePerfil"/>
                        <img class="imagen-perfil empty rounded-circle" src="Img/pngegg.png" alt="fotoDePerfil"/>
                        <img class="imagen-perfil empty rounded-circle" src="Img/pngegg.png" alt="fotoDePerfil"/>
                        <img class="imagen-perfil empty rounded-circle" src="Img/pngegg.png" alt="fotoDePerfil"/>
                    </div>
                    <div class="col-6">
                        <h4>Descripcíón breve:</h4>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown </p>
                    </div>

                    <div class="col-6">
                        <asp:Label ID="lblDisponibilidad" class="d-block" runat="server" Text="Disponibilidad: Fin de semana"></asp:Label>

                        <asp:Label ID="Label1" class="d-block" runat="server" Text="Tematica: Medieval"></asp:Label>

                        <asp:Label ID="Label2" class="d-block" runat="server" Text="Jugadores: 4/7"></asp:Label>
                    </div>

                    <div class="col-6">
                        <asp:Button ID="Button1" class="btn-partida" runat="server" Text="Mas información" />
                    </div>
                    <div class="col-6 d-flex justify-content-end">
                        <asp:Button ID="Button2" class="btn-partida" runat="server" Text="Apuntarse" />
                    </div>
                </div>
            </div>
        </div>
        <div class="col d-flex justify-content-end">
            <asp:Button ID="btnCrearCuenta2" runat="server" Text="Crear cuenta" />
        </div>

        <div class="row m-3 d-flex justify-content-center align-content-center">
            <div class="col-12">
                <h2>Descubre Locales:</h2>
                <p>Expliación de la página:consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Morbi tristique senectus et netus</p>
            </div>
            <div class="col-6">
                <h2>Locales colaboradores</h2>
            </div>
            <div class="col-6 d-flex justify-content-end">
                <asp:Button ID="btnCrearCuenta3" runat="server" Text="Crear cuenta" />
            </div>
            <div class="col-12 slider d-flex justify-content-center">

            </div>
        </div>
</div>
    </main>
</asp:Content>
