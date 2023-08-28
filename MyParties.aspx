<%@ Page Title="Crear Grupo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyParties.aspx.cs" Inherits="RPGMeet.MyParties" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-12 my-4">
                <div class="row">
                    <div class="sidebar">
                        <div class="accordion " id="accordionMisPartidas">
                            <div class="accordion-item bg-glass">
                                <h2 class="accordion-header" id="headingMisPartidas">
                                    <button class="accordion-button text-glass bg-dark " type="button" data-bs-toggle="collapse" data-bs-target="#collapseMisPartidas" aria-expanded="true" aria-controls="collapseMisPartidas">
                                        Mis Partidas
                                    </button>
                                </h2>
                                <div id="collapseMisPartidas" class="accordion-collapse collapse show" aria-labelledby="headingMisPartidas" data-bs-parent="#accordionExample">
                                    <div class="accordion-body">
                                        <div class="col-12">
                                            <div class="scrollable-panel grid gap-3 p-3 shadow rounded animate__animated animate__fadeInUp">
                                                <asp:Panel class="row" runat="server" ID="PanelMisPartidas">
                                                </asp:Panel>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-12 my-4">
                <div class="row">
                    <div class="sidebar">
                        <div class="accordion " id="accordionPartidas">
                            <div class="accordion-item bg-glass">
                                <h2 class="accordion-header" id="headingPartidas">
                                    <button class="accordion-button text-glass bg-dark " type="button" data-bs-toggle="collapse" data-bs-target="#collapsePartidas" aria-expanded="true" aria-controls="collapsePartidas">
                                        Partidas en las que participo
                                    </button>
                                </h2>
                                <div id="collapsePartidas" class="accordion-collapse collapse show" aria-labelledby="headingPartidas" data-bs-parent="#accordionExample">
                                    <div class="accordion-body">
                                        <div class="col-12">
                                            <div class="scrollable-panel grid gap-3 p-3 shadow rounded animate__animated animate__fadeInUp">
                                                <asp:Panel class="row" runat="server" ID="PanelPartidasParticipa">
                                                </asp:Panel>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
