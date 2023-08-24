<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RPGMeet._Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .verde {
            background-color: rgb(53, 232, 71);
            width: 400px;
            height: 225px;
            position: relative;
        }

        #slider-content-1 {
            position: absolute;
            transform: translate(0%, 50%);
        }

        #slider-content-2 {
            position: absolute;
        }

        #slider-content-3 {
            position: absolute;
            transform: translate(-100%, 50%);
        }

        .slider-content {
        }

        .content {
            height: 50%;
            width: 33%;
            opacity: 0.8;
            filter: blur(2px);
            transition: transform 1s ease-in-out, height 1s ease-in-out, opacity, opacity 1s ease-in-out, filter 1s ease-in-out;
        }

        .main {
            height: 55%;
            transform: translate(-50%, 40%);
            opacity: 1;
            filter: blur(0px);
        }
    </style>
    <div class="row m-3">
        <div class="col-6">
            <h2>Nombre App</h2>
            <p>Expliación de la página: consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Morbi tristique senectus et netus. Ut venenatis tellus in metus. Id diam maecenas ultricies mi eget mauris pharetra et. Ullamcorper dignissim cras tincidunt lobortis.</p>
        </div>
        <div class="col-6 bg-black text-center text-white align-content-center">
            <p> Aquí va una imagen...</p>
        </div>
        <div class="col-6">
            <asp:Button ID="btnCrearCuenta1" CssClass="btn btn-dark" runat="server" Text="Crear cuenta"/>
        </div>
    </div>

    <div class="row m-3">
        <div class="col-5">
            <h2>Conoce gente:</h2>
            <p>Expliación de la página:consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Morbi tristique senectus et netus. </p>
        </div>
        <div id="partidaEjemplo" class="col-7 bg-grey pt-3 pb-3">
            <div class="row">
                <div class="col-6 rounded-pill">
                    <h2>Titulo partida</h2>
                </div>
                <div class="col-6 d-flex justify-content-end">
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

                <div class="col-6 d-flex justify-content-end">
                    <div>
                        <asp:Label ID="lblDisponibilidad" class="d-block" runat="server" Text="Disponibilidad: Fin de semana"></asp:Label>

                        <asp:Label ID="lblTematica" class="d-block" runat="server" Text="Tematica: Medieval"></asp:Label>

                        <asp:Label ID="lblNumJugadores" class="d-block" runat="server" Text="Jugadores: 4/7"></asp:Label>
                    </div>
                </div>

                <div class="col-6">
                    <asp:Button ID="Button1" class="btn btn-partida" runat="server" Text="Mas información" />
                </div>
                <div class="col-6 d-flex justify-content-end">
                    <asp:Button ID="Button2" class="btn btn-partida" runat="server" Text="Apuntarse" />
                </div>
            </div>
        </div>
        <div class="col-6">
            <asp:Button ID="btnCrearCuenta2" CssClass="btn btn-dark" runat="server" Text="Crear cuenta"  />
        </div>
    </div>

    <div class="row m-3 d-flex justify-content-center align-content-center">
        <div class="col-12">
            <h2>Descubre Locales:</h2>
            <p><span class="d-block">Expliación de la página:</span>
                consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Morbi tristique senectus et netus</p>
        </div>
        <div class="col-8">
            <h2>Locales colaboradores</h2>
        </div>
        <div class="col-4 d-flex justify-content-end">
            <asp:Button ID="btnCrearCuenta3" CssClass="btn btn-dark" runat="server" Text="Crear cuenta" />
        </div>
        <div class="col-12 d-flex align-content-center justify-content-center">
            <div class="d-flex align-items-center ms-2 me-2">
                <button id="slider-left-btn" class="btn btn-primary btn-lg" value="-1"><</button>
            </div>
            <div class="slider box verde">
                <div id="slider-content-1" class="slider-content content" style="z-index: 0;">
                    <h6>ALEJANDRO</h6>
                </div>
                <div id="slider-content-2" class="slider-content content main" style="z-index: 2;">
                    <h6>HOLA</h6>
                </div>
                <div id="slider-content-3" class="slider-content content" style="z-index: 1;">
                    <h6>ME LLAMO</h6>
                </div>
            </div>
            <div class="d-flex align-items-center ms-2 me-2">
                <button id="slider-right-btn" class="btn btn-primary btn-lg" value="1">></button>
            </div>
        </div>
    </div>
    <script src="Default.js"></script>
</asp:Content>
