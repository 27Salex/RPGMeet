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
        .tarjeta{
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
            <asp:Panel ID="pnlFiltros" CssClass="col-3" runat="server">

            </asp:Panel>
            <asp:Panel ID="pnlPartidas" CssClass="col-9" runat="server">
                <asp:Panel ID="rowPartidas" CssClass="row" runat="server">
                </asp:Panel>
            </asp:Panel>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
