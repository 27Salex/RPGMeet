<%@ Page Title="Crear Grupo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyParties.aspx.cs" Inherits="RPGMeet.MyParties" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="BackTabern">
        <div class="container">
            <div class="row">
                <div class="col-lg-11 offset-lg-1">
                    <h2 class="mb-3 h2 text-light">Buscar Partida</h2>
                    <div class="scrollable-panel grid gap-3 shadow rounded animate__animated animate__fadeInUp">
                        <asp:Panel class="row" runat="server" ID="PanelPartidas">
                        </asp:Panel>
                    </div>
                </div>
            </div>
        </div>   
    </div>
</asp:Content>
