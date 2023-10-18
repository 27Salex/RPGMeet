
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RPGMeet._Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="container BackTabern">
    <div class="row m-3">
        <div class="col-6">
            <h2>¡Bienvenidos a RPG Meet!</h2>
            <p>
               Tu plataforma de encuentros para los amantes de los juegos de rol y afines.
                Conecta con personas apasionadas por los mundos de fantasía mientras recuperamos
                el contacto físico post-pandemia. 
                <br>
                <br>
                Aquí, podrás crear y unirte a quedadas
                presenciales donde la diversión cobra vida a través de aventuras de rol, estrategia
                y más. Ya sea que quieras ser un valiente caballero o un astuto mago, nuestra
                comunidad te espera para explorar reinos y forjar amistades en el mundo real.
                Únete a la emocionante travesía de volver a compartir risas, dados y momentos épicos
                en persona. ¡Tu próxima aventura comienza aquí en RPG Meet!
            </p>
            <asp:Button ID="btnCrearCuenta1" CssClass="btn btn-dark" runat="server" Text="Crear cuenta"/>
        </div>
        <div class="col-6 text-center text-white align-content-center">
            <img src="Img/tabernero.png" alt="tabernero" class="img-fluid">
        </div>
    </div>
    <div class="row m-3">
        <div class="col-5">
            <h2>Conoce gente:</h2>
            <p>
                Conoce compañeros de rol en tu área uniéndote a eventos locales o crea los tuyos.
                RPG Meet te conecta con jugadores apasionados para compartir aventuras y crear vínculos duraderos.
            </p>
        </div>
        <div id="pnlPartida{TargetGrupo.IdGrupo}" class="text-dark col-sm-12 col-md-6 col-xl-5 mx-auto tarjeta animate__animated animate__fadeIn">
            <div class="row">
                <div class="col-12">
                    <label>Titulo:</label>
                    <h4 class="h2">Empieza a buscar partidas!</h4>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6 col-sm-12">
                    <label class="d-block">Descripción:</label>                            
                        ¡Únete hoy y forma parte de nuestra comunidad en RPG Meet! Conoce a amantes del rol,
                        organiza quedadas y disfruta de emocionantes aventuras juntos. ¡La diversión te espera!
                </div>
                <div class="col-md-6 col-sm-12">
                    <label>Temas:</label>
                    <div class="form-control-plaintext text-glass">Para todo el mundo <3</div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6 col-sm-12">
                    <label>Máximo de Jugadores:</label>                            
                    <div class="form-control-plaintext text-glass">0/&infin;</div>
                </div>
                <div class="col-md-6 col-sm-12">
                    <label>Juego:</label>
                    <div class="form-control-plaintext text-glass">El que quieras</div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12 col-sm-12">
                    <label>Disponibilidad:</label>                            
                    <div class="form-control-plaintext text-glass">¡Siempre!</div>
                </div>
            </div>
            <div class="row">
                <div class="col-6">
                    <a href="Parties.aspx"class="btn btn-info">Empezar a buscar!</a>
                </div>
                <div class="col-6">
                    <a  href="Profile.aspx" class="btn btn-info">Unete a nosotros!</a>
                </div>
            </div>
        </div>
            <div class="col-6">
                <asp:Button ID="btnCrearCuenta2" Class="btn btn-dark" runat="server" Text="Crear cuenta"></asp:Button>
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
    <div id="carouselLocales" class="carrouseLocales carousel slide shadow rounded-5 border border-3 border-light" data-bs-touch="false">
      <div class="carousel-inner rounded-5">
        <div class="carousel-item active">
          <img src="img/bgTabern.jpeg" class="d-block w-100" alt="...">
        </div>
        <div class="carousel-item">
          <img src="img/bgTabern.jpeg" class="d-block w-100" alt="...">
        </div>
        <div class="carousel-item">
          <img src="img/bgTabern.jpeg" class="d-block w-100" alt="...">
        </div>
      </div>
      <button class="carousel-control-prev" type="button" data-bs-target="#carouselLocales" data-bs-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Previous</span>
      </button>
      <button class="carousel-control-next" type="button" data-bs-target="#carouselLocales" data-bs-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Next</span>
      </button>
    </div>
</div>
</asp:Content>
