<%@ Page Title="Lista de partidas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Parties.aspx.cs" Inherits="RPGMeet.Partidas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="container">
    <div class="row">
        <div class="col-md-3 col-sm-12 my-4">
            <div class="row">
                <div class="sidebar">
                    <div class="accordion " id="accordionExample">
                        <div class="accordion-item bg-glass">
                            <h2 class="accordion-header" id="headingFiltros">
                                <button class="accordion-button text-glass bg-dark " type="button" data-bs-toggle="collapse" data-bs-target="#collapseFiltros" aria-expanded="true" aria-controls="collapseFiltros">
                                    Filtros
                                </button>
                            </h2>
                            <div id="collapseFiltros" class="accordion-collapse collapse show" aria-labelledby="headingFiltros" data-bs-parent="#accordionExample">
                                <div class="accordion-body">
                                    <!-- Filtros -->
                                    <!-- Filtros Disponibilidad -->
                                    <div>
                                        <h4>Disponibilidad</h4>
                                        <asp:CheckBoxList ID="chkListDisponibilidad" CssClass="form-check" runat="server" >
                                            <asp:ListItem Text="&nbsp;&nbsp;Lunes" Value="Lunes" />
                                            <asp:ListItem Text="&nbsp;&nbsp;Martes" Value="Martes" />
                                            <asp:ListItem Text="&nbsp;&nbsp;Miércoles" Value="Miercoles" />
                                            <asp:ListItem Text="&nbsp;&nbsp;Jueves" Value="Jueves" />
                                            <asp:ListItem Text="&nbsp;&nbsp;Viernes" Value="Viernes" />
                                            <asp:ListItem Text="&nbsp;&nbsp;Sábado" Value="Sabado" />
                                            <asp:ListItem Text="&nbsp;&nbsp;Domingo" Value="Domingo" />
                                        </asp:CheckBoxList>
                                    </div>

                                    <!-- Filtro Número de Jugadores -->
                                    <div>
                                        <h4>Número de jugadores:<span class="text-glass" runat="server" id="valorJugadores">&nbsp;&nbsp;6</span></h4>
                                        <asp:TextBox ID="txtMaxJugadores" runat="server" CssClass="form-range" AutoPostBack="true" TextMode="Range" max="10" min="2"></asp:TextBox>
                                    </div>

                                    <!-- Filtros Temática -->
                                    <div>
                                        <h4>Temática</h4>
                                        <asp:CheckBoxList ID="cbListTematica" CssClass="form-check" runat="server">
                                        </asp:CheckBoxList>
                                        <h4>Juego</h4>
                                        <asp:CheckBoxList ID="cbListJuego" CssClass="form-check" runat="server">
                                        </asp:CheckBoxList>
                                        <br />
                                        <asp:Button ID="btnAplicarFiltros" CssClass="btn btn-info" runat="server" Text="Aplicar filtros" OnClick="btnAplicarFiltros_Click" />
                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-9 col-sm-12">
            <div class="scrollable-panel grid gap-3 p-3 shadow rounded animate__animated animate__fadeInUp">
                <asp:Panel class="row" runat="server" ID="PanelPartidas">
                </asp:Panel>
            </div>
        </div>
    </div>
</div>


</asp:Content>
