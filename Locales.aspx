<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Locales.aspx.cs" Inherits="RPGMeet.Locales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- meter este style en el sire.master/head acciendo referencia a la carpeta de estilos Home.css -->
<style>
    :root {
        --grey: #D9D9D9;
    }

    div[class*="col"] {
        margin: 1vh 0 1vh 0;
    }
    .tarjeta{
        border-radius: 3vh;
        padding: 2vh 3vh 2vh 3vh;
        background-color: var(--grey);
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
        <asp:Panel ID="pnlLocales" CssClass="col-12 col-xl-6 ms-4 me-4 tarjeta bg-light shadow" runat="server">
            <div class="row">
                <div class="col-12 text-center h3">
                    <asp:Label runat="server" Text="Nombre del local"></asp:Label>
                </div>
                <div class="col-6 text-left align-self-center">
                    <asp:Label runat="server" Text="Local especializado en juegos de mesa, de rol, merchandising o cartas, con un café donde probar los artículos.git"></asp:Label>
                </div>
                <div class="col-6">
                    <asp:Image CssClass="img-fluid rounded-2" ImageUrl="https://www.carrerdesants.cat/media/carrerdesants/image/fotos//993_Foto.1648810055.png" runat="server"/> <!-- Imagen del local -->
                </div>
            </div>
            <div class="col-12 d-flex justify-content-end">
                <div class="row">
                    <div class="col-1">
                        <asp:Image runat="server" /> <!-- imagen icono de punto de locaclizacion de google -->
                    </div>
                    <div class="col-4">
                        <asp:Label runat="server" Text="Pg. de St. Joan, 11, 08010 Barcelona"></asp:Label>
                    </div>
                    <div class="col-1">
                        <asp:Image runat="server" /> <!-- imagen icono de sitio web -->
                    </div>
                    <div class="col-2">
                        <asp:HyperLink runat="server">kaburi.es</asp:HyperLink>
                    </div>

                    <div class="col-1">
                        <asp:Image runat="server" /> <!-- imagen icono de telefono -->
                    </div>
                    <div class="col-2">
                        <asp:HyperLink runat="server">932 45 95 08</asp:HyperLink>
                    </div>
                </div>
            </div>
        </asp:Panel>
    </asp:Panel>
</asp:Panel>
</asp:Content>
