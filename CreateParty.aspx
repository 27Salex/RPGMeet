<%@ Page Title="Crear Grupo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateParty.aspx.cs" Inherits="RPGMeet.CreateParty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="login-page bg-light">
        <div class="container">
            <div class="row">
                <div class="col-lg-10 offset-lg-1">
                    <h2 class="mb-3 h2">Crear Partida</h2>
                    <div class="bg-white shadow rounded p-4 animate__animated animate__fadeInUp">
                        <div class="row">
                            <div class="col-md-6 col-sm-12">
                                <label for="TxtBoxCreateTitle" class="form-label">Título:</label>
                                <asp:TextBox type="text" id="TxtBoxCreateTitle" class="form-control" runat="server"></asp:TextBox>
                                <asp:Label ID="LbTitleError" runat="server" Font-Italic="True" ForeColor="Red" Text="Se requiere un titulo" Visible="False"></asp:Label>
                            </div>
                            <div class="col-md-6 col-sm-12">
                                <label for="TxtBoxCreateMaxPly" class="form-label">Máximo de Jugadores:<span runat="server" id="numJugadores"></span></label> <br />
                                <asp:TextBox OnTextChanged="TxtBoxCreateMaxPly_TextChanged" AutoPostBack="true" type="range" min="2" max="10" id="TxtBoxCreateMaxPly" class="form-range" runat="server"></asp:TextBox>
                                <asp:Label ID="LbMaxPlyError" runat="server" Font-Italic="True" ForeColor="Red" Text="Se requiere un número de Jugadores Máximos" Visible="False"></asp:Label>
                            </div>
                            <div class="col-md-6 col-sm-12">
                                <label class="form-label">Dias a jugar:</label>
                                <div class="list-group">
                                    <asp:CheckBoxList ID="CheckBoxDays" runat="server">
                                        <asp:ListItem>Lunes</asp:ListItem>
                                        <asp:ListItem>Martes</asp:ListItem>
                                        <asp:ListItem>Miercoles</asp:ListItem>
                                        <asp:ListItem>Jueves</asp:ListItem>
                                        <asp:ListItem>Viernes</asp:ListItem>
                                        <asp:ListItem>Sabado</asp:ListItem>
                                        <asp:ListItem>Domingo</asp:ListItem>
                                    </asp:CheckBoxList>
                                </div>
                                <asp:Label ID="LbDaysError" runat="server" Font-Italic="True" ForeColor="Red" Text="Selecciona un dia mínimo" Visible="False"></asp:Label>
                            </div>
                            <div class="col-md-6 col-sm-12">
                                <label for="TextBox1" class="form-label">Descripción:</label>
                                <asp:TextBox id="TextBox1" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div class="col-md-4 col-sm-12">
                                <label for="DropDownPri" class="form-label">Temática principal:</label>
                                <asp:DropDownList ID="DropDownPri" runat="server" CssClass="form-select">
                                    <asp:ListItem>Selecciona una opción</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LbTemaPriError" runat="server" Font-Italic="True" ForeColor="Red" Text="Selecciona una temática principal" Visible="False"></asp:Label>
                            </div>
                            <div class="col-md-4 col-sm-12">
                                <label for="DropDownSec" class="form-label">Temática secundaria:</label>
                                <asp:DropDownList ID="DropDownSec" runat="server" CssClass="form-select">
                                    <asp:ListItem>Selecciona una opción</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-4 col-sm-12">
                                <label for="DropDownGame" class="form-label">Juego:</label>
                                <asp:DropDownList ID="DropDownGame" runat="server" AutoPostBack="True" CssClass="form-select">
                                    <asp:ListItem>Selecciona una opción</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="LbGameError" runat="server" Font-Italic="True" ForeColor="Red" Text="Selecciona un juego" Visible="False"></asp:Label> <br />
                            </div>
                            <div class="col-md-12 col-sm-12">
                                <asp:Button ID="BtnCreateParty" runat="server" Text="Crear Partida" OnClick="BtnCreateParty_Click" CssClass="btn btn-primary" />
                           </div>
                         </div>
                     </div>
                </div>
            </div>
         </div>
    </div>     
</asp:Content>
