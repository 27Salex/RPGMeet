<%@ Page Title="Partida" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PartyDetails.aspx.cs" Inherits="RPGMeet.PartidaInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="MainContainer" runat="server">
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click"/>
            <div class="row rounded-3 shadow" style="background-color: rgba(0, 0, 0, 0.5);">
                <div class="col-12 col-xl-8 text-center d-flex justify-content-center justify-content-xl-start">
                    <h2><asp:Literal ID="lblTituloPartida" runat="server"></asp:Literal></h2>
                </div>
                <div class="col-12 col-xl-4 text-end d-flex justify-content-start justify-content-xl-end text-break">
                    <h5>Creador: <asp:Literal ID="lblGameMasterNombre" runat="server">Xx_PakitoGameMaster79_xX</asp:Literal></h5>
                </div>
                <div class="col-12">
                    <h3>Juego:</h3>
                    <p class="h4"><asp:Literal ID="lblJuego" runat="server"></asp:Literal></p>
                </div>
                <div class="col-12">
                    <h3>Descripción:</h3>
                    <p class="text-break h5"><asp:Literal ID="lblDescripcion" runat="server"></asp:Literal></p>
                </div>
                <div class="col-12">
                    <h3>Disponibilidad:</h3>
                    <p class="text-break h4"><asp:Literal ID="lblDiasDisponibles" runat="server"></asp:Literal></p>
                </div>
                <div class="col-12">
                    <h3>Tematica:</h3>
                    <p class="text-break h4"><asp:Literal ID="lblTemas" runat="server"></asp:Literal></p>
                </div>
                <div class="col-12">
                    <h3>Jugadores:</h3>
                    <p class="h4"><asp:Literal ID="lblJugadores" runat="server"></asp:Literal></p>
                </div>
            </div>
    </asp:Panel>
</asp:Content>
