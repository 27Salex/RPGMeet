<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="RPGMeet.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Perfil</h2>
    </div>
    <div id="EditUser" class="container h5 p-5 bg-white shadow rounded" runat="server" visible="false">
        <div class="row">
            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Nombre de Usuario:</Label>
                <asp:TextBox CssClass="Form-Control" ID="TxtBoxUpdateUser" runat="server"></asp:TextBox>
                <asp:Label ID="lbErrorUser" runat="server" Text="Usuario no disponible" Font-Italic="True" ForeColor="#FF3300" Visible="False"></asp:Label>
            </div>
            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Contraseña:</Label>
                <asp:Label ID="lbErrorPsw" runat="server" Text="La contraseña debe tener: 8 caracteres, Mayuscula, Minuscula y un Simbolo" Font-Italic="True" ForeColor="#FF3300" Visible="False"></asp:Label>
            </div>
            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Confirmar Contraseña:</Label>
                <asp:TextBox CssClass="Form-Control" ID="TxtBoxUpdatePswCon" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="lbErrorPswCon" runat="server" Text="Las contraseñas no son iguales" Font-Italic="True" ForeColor="#FF3300" Visible="False"></asp:Label>
            </div>
            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Localidad:</Label>
                <asp:DropDownList CssClass="dropdown" ID="DropDownListUpdateLoc" runat="server">
                </asp:DropDownList>
            </div>
            <div class="col-md-6 col-sm-12">
                <asp:Label ID="LbCompulsoryCamps" runat="server" Text="Porfavor rellena los campos obligatorios" Font-Bold="True" Font-Italic="True" ForeColor="Red" Visible="False"></asp:Label>
                <br/>
                <asp:Button Class="btn btn-success" ID="BtnUpdateCreate" runat="server" OnClick="BtnUpdateCreate_Click" Text="Actualizar datos" />
                <asp:Button onclick="DesactivarEdicion" id="BtnCancelarEdicion" runat="server" Class="btn btn-danger" role="button" Text="Cancelar"/>
            </div>
        </div>
        
    </div>
    

    <div id="ShowUser" class="container h5 bg-white p-5 shadow rounded" runat="server">
        <div class="row">
            <!--Campos User -->
            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Nombre de Usuario:</Label>
                <asp:Label CssClass="form-control" id="LbUsername" runat="server"></asp:Label>
            </div>
            <!--Campos Email -->
            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Email:</Label>
                <asp:Label CssClass="form-control" id="LbEmail" runat="server"></asp:Label>
            </div>
            <!--Campos Localidad -->
            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Localidad:</Label>
                <asp:Label CssClass="form-control" id="LbLocalidad" runat="server"></asp:Label>
            </div>
            <!--Boton Activar Edicion -->
            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Editar:</Label> <br />
                <asp:Button onclick="ActivarEdicion" id="BtnEditarPerfil" runat="server" Class="btn btn-warning" role="button" Text="🖊Editar Perfil"/>
            </div>
        </div>
        
    </div>
</asp:Content>
