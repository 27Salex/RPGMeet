<%@ Page Title="Crear Grupo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateParty.aspx.cs" Inherits="RPGMeet.CreateParty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-10 offset-lg-1">
                <h2 class="mb-3 h2">Crear Partida</h2>
                <div class="bg-glass shadow rounded p-4 animate__animated animate__fadeInUp">
                    <asp:Panel runat="server" id="RowControls" CssClass="row">
                        <div class="col-md-6 col-sm-12">
                            <label for="TxtBoxCreateTitle" class="form-label">T&iacute;tulo:</label>
                            <asp:TextBox type="text" id="TxtBoxCreateTitle" class="form-control" runat="server"></asp:TextBox>
                            <asp:Label ID="LbTitleError" runat="server" CssCLass="form-text text-danger" Text="Se requiere un titulo" Visible="False"></asp:Label>
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <label for="TxtBoxCreateMaxPly" class="form-label">M&aacute;ximo de Jugadores:<span runat="server" id="numJugadores">&nbsp;6</span></label> <br />
                            <asp:TextBox OnTextChanged="TxtBoxCreateMaxPly_TextChanged" AutoPostBack="true" TextMode="Range" min="2" max="10" id="TxtBoxCreateMaxPly" class="form-range" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <label class="form-label">Dias a jugar:</label>
                            <div class="list-group">
                                <asp:CheckBoxList ID="CheckBoxDays" runat="server">
                                    <asp:ListItem>&nbsp;Lunes</asp:ListItem>
                                    <asp:ListItem>&nbsp;Martes</asp:ListItem>
                                    <asp:ListItem>&nbsp;Miercoles</asp:ListItem>
                                    <asp:ListItem>&nbsp;Jueves</asp:ListItem>
                                    <asp:ListItem>&nbsp;Viernes</asp:ListItem>
                                    <asp:ListItem>&nbsp;Sabado</asp:ListItem>
                                    <asp:ListItem>&nbsp;Domingo</asp:ListItem>
                                </asp:CheckBoxList>
                            </div>
                            <asp:Label ID="LbDaysError" runat="server" CssCLass="form-text text-danger" Text="Selecciona un dia m&iacute;nimo" Visible="False"></asp:Label>
                        </div>
                        <div class="col-md-6 col-sm-12">
                            <label for="TextBox1" class="form-label">Descripci&oacute;n:</label>
                            <asp:TextBox id="TxtAreaCreateDesc" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </div>
                        <div class="col-md-4 col-sm-12">
                            <label for="DropDownPri" class="form-label">Tem&aacute;tica principal:</label>
                            <asp:DropDownList ID="DropDownPri" runat="server" CssClass="form-select">
                                <asp:ListItem>Selecciona una opci&oacute;n</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="LbTemaPriError" runat="server" CssCLass="form-text text-danger" Text="Selecciona una tem&aacute;tica principal" Visible="False"></asp:Label>
                        </div>
                        <div class="col-md-4 col-sm-12">
                            <label for="DropDownSec" class="form-label">Tem&aacute;tica secundaria:</label>
                            <asp:DropDownList ID="DropDownSec" runat="server" CssClass="form-select">
                                <asp:ListItem>Selecciona una opci&oacute;n</asp:ListItem>                      
                            </asp:DropDownList>
                            <asp:Label ID="LbTemaSecError" runat="server" CssCLass="form-text text-danger" Text="Selecciona una tem&aacute;tica secundaria" Visible="False"></asp:Label>
                        </div>
                        <div class="col-md-4 col-sm-12">
                            <label for="DropDownGame" class="form-label">Juego:</label>
                            <asp:DropDownList ID="DropDownGame" runat="server" AutoPostBack="True" CssClass="form-select">
                                <asp:ListItem>Selecciona una opci&oacute;n</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="LbGameError" runat="server" CssCLass="form-text text-danger" Text="Selecciona un juego" Visible="False"></asp:Label> <br />
                        </div>
                        <div class="col-md-12 col-sm-12">
                            <asp:Button ID="BtnCreateParty" runat="server" Text="Crear Partida" OnClick="BtnCreateParty_Click" CssClass="btn btn-primary" />
                        </div>
                        </asp:Panel>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
