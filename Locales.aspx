<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Locales.aspx.cs" Inherits="RPGMeet.Locales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
    .icon {
        height: 1.25rem;
    }
</style>

<asp:Panel CssClass="container" runat="server">
    <asp:Panel ID="pnlLocales" CssClass="row" runat="server">
        <div class="col-12 col-xl-6 ms-4 me-4 tarjeta bg-light shadow">
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
            <div class="col-12 d-flex justify-content-center">
                <div class="row text-center">
                    <div class="col-4">
                        <asp:Image runat="server" /> <!-- imagen icono de punto de locaclizacion de google -->
                        <asp:Label runat="server" Text="Pg. de St. Joan, 11, 08010 Barcelona"></asp:Label>
                    </div>

                    <div class="col-4">
                        <asp:Image runat="server" /> <!-- imagen icono de sitio web -->
                        <asp:HyperLink runat="server">kaburi.es</asp:HyperLink>
                    </div>

                    <div class="col-4">
                        <asp:Image runat="server" /> <!-- imagen icono de telefono -->
                        <asp:HyperLink runat="server">932 45 95 08</asp:HyperLink>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Panel>

</asp:Content>
