<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RPGMeet._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
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
            #partidaEjemplo{
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
            .my-grey{
                background-color: #D9D9D9;
            }
            .container{
                display: flex;
                justify-content: center;
            }
            .box{
                border-radius: 10px;
            }

            .verde {
                background-color: rgb(53, 232, 71);
                width: 400px;
                height: 225px;
                position: relative;
            }

            .amarillo {
                background-color: rgb(232, 223, 53);
                position: absolute;
                left: 50%;
                transform: translate(0%, 50%);
            }

            .azul {
                background-color: rgb(53, 166, 232);
                position: absolute;
                left: 50%;
                transform: translate(-50%, 50%);
            }

            .rojo {
                background-color: rgb(232, 53, 53);
                position: absolute;
                left: 50%;
                transform: translate(-100%, 50%);
            }

            .content{
                height: 50%;
                width: 33%;
                transition: transform 1s ease-in-out, height 1s ease-in-out, opacity ;
            }

            .main {
                height: 55%;
                transform: translate(-50%, 40%);
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
                    <div class="col-6 rounded-pill" CssClass="background-color: #D9D9D9">
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
            <div class="col slider">
                <button type="button" id="slider-left-btn" value="-1"><</button>
                <div class="slider box verde">
                    <div style="z-index: 1"class="slider-content box content amarillo ">
                    </div>
                    <div style="z-index: 2" class="slider-content main box content azul ">
                    </div>
                    <div style="z-index: 0" class="slider-content box content rojo ">

                    </div>
                </div>
                <button type="button" id="slider-right-btn" value="1">></button>
            </div>
        </div>
        <script type="module" src="Default.js"></script>
    </main>
</asp:Content>
