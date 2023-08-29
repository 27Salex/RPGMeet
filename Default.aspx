
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RPGMeet._Default" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<style>
        .slider {
        width: 100%;
        height: 100%;
        display: flex;
        align-items: center;
        justify-content: center;
    }

    .slider-content-container {
        width: 100%;
        position: relative;
    }

    .slider-content {
        display: flex;
        align-items: center; /* Centrar horizontalmente */
        justify-content: center; /* Centrar verticalmente */
        width: 50%;
        height: 60%;
        opacity: 0.8;
        filter: blur(5px);
        transition: transform 0.75s ease-in-out, height 0.75s ease-in-out, opacity 0.75s ease-in-out, filter 0.75s ease-in-out;
    }


    .main {
        height: 65%;
        width: 65%;
        transform: translate(-50%, -50%);
        opacity: 1;
        filter: blur(0px);
    }

    #slider-content-1 {
        position: absolute;
        transform: translate(0%, -50%);
    }

    #slider-content-2 {
        position: absolute;
    }

    #slider-content-3 {
        position: absolute;
        transform: translate(-100%, -50%);
    }

    @media (max-width: 575.98px) {
        .slider-container{
            height: 190px;
        }
    }

    @media (min-width: 575.98px) {
        .slider-container{
            height: 350px;
        }
    }

    /* Medium devices (tablets, 768px and up) */
    @media (min-width: 768px) {
        .slider-container{
            height: 400px;
        }
    }

    /* Large devices (desktops, 992px and up) */
    @media (min-width: 992px) {
        .slider-container{
            height: 550px;
        }
    }

    /* Extra large devices (large desktops, 1200px and up) */
    @media (min-width: 1200px) {
        .slider-container{
            height: 875px;
        }
    }
</style>
<div class="container BackTabern">
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
            <p>RPG Meet un portal de encuentros y aventuras: Donde las historias de juego de rol toman forma!</p>
        </div>
        <div id="partidaEjemplo" class="col-7 bg-glass shadow rounded-4 pt-3 pb-3">
            <div class="row">
                <div class="col-6 rounded-pill">
                    <h2>Titulo partida</h2>
                </div>
                <div class="col-6 d-flex justify-content-end">
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
                    <asp:Button ID="btnMasInfo" class="btn btn-partida btn-primary" runat="server" Text="Mas información" />
                </div>
                <div class="col-6 d-flex justify-content-end">
                    <asp:Button ID="btnApuntarse" class="btn btn-partida btn-primary" runat="server" Text="Apuntarse" />
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
            <asp:Button ID="btnCrearCuenta3" CssClass="btn btn-dark" runat="server" Text="Crear cuenta"/>
        </div>
    </div>
    <div class="row slider-container d-flex justify-content-center align-items-center">
                <div class="col-12 slider bg-light">
                    <button type="button" class="btn btn-light btn-lg h-25" id="slider-left-btn" value="-1"><</button>
                    <div class="col-11 slider-content-container h-100 w-100 d-flex align-items-center justify-content-center">
                        <div class="row">
                            <div class="slider-content shadow start-50 border border-dark rounded-3" id="slider-content-1" style="z-index: 0;">
                                <div class="row h-100">
                                    <div class="col-12">
                                        <h3>Tienda goku</h3>
                                    </div>
                                    <div class="col-6">
                                        lorem ipsum de la descripcion de la tienda somos especializados en oler mal y ver anime
                                    </div>
                                    <div class="col-6">
                                        <img src="" alt="Imagen Tienda"/>
                                    </div>
                                    <div class="col-12">
                                        <div class="row">
                                            <div class="col-6">
                                                C/Bailen 41, Barcelona, 08001
                                            </div>
                                            <div class="col-6">
                                                <a>www.mamilongas.es</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="slider-content shadow start-50 border border-dark rounded-3 main" id="slider-content-2" style="z-index: 2;">
                                <div class="row h-100">
                                    <div class="col-12">
                                        <h3>Tienda goku</h3>
                                    </div>
                                    <div class="col-6">
                                        lorem ipsum de la descripcion de la tienda somos especializados en oler mal y ver anime
                                    </div>
                                    <div class="col-6">
                                        <img src="" alt="Imagen Tienda"/>
                                    </div>
                                    <div class="col-12">
                                        <div class="row">
                                            <div class="col-6">
                                                C/Bailen 41, Barcelona, 08001
                                            </div>
                                            <div class="col-6">
                                                <a>www.mamilongas.es</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="slider-content shadow start-50 border border-dark rounded-3" id="slider-content-3" style="z-index: 1;">
                                <div class="row h-100">
                                    <div class="col-12">
                                        <h3>Tienda goku</h3>
                                    </div>
                                    <div class="col-6">
                                        lorem ipsum de la descripcion de la tienda somos especializados en oler mal y ver anime
                                    </div>
                                    <div class="col-6">
                                        <img src="" alt="Imagen Tienda"/>git 
                                    </div>
                                    <div class="col-12">
                                        <div class="row">
                                            <div class="col-6">
                                                C/Bailen 41, Barcelona, 08001
                                            </div>
                                            <div class="col-6">
                                                <a>www.mamilongas.es</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <button type="button" class="btn btn-light btn-lg h-25" id="slider-right-btn" value="1">></button>
                </div>
            </div>
    <script type="module" src="Default.js"></script>
</div>
</asp:Content>
