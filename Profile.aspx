<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="RPGMeet.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Perfil</h2>
    </div>
    <div id="EditUser" class="container h5 p-5 bg-white shadow rounded" runat="server" visible="false">
        <div class="row">
            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Nombre de Usuario:</Label>
                <div class="input-group">
                    <div class="input-group-text"><i class="bi bi-person-fill"></i></div>
                    <asp:TextBox CssClass="form-Control" ID="TxtBoxUpdateUser" runat="server"></asp:TextBox>
                </div>
                <asp:Label ID="lbErrorUser" CssClass="form-text text-danger" runat="server" Text="Usuario no disponible" Visible="False"></asp:Label>
            </div>

            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Localidad:</Label>
                <div class="input-group">
                    <div class="input-group-text"><i class="bi bi-flag-fill"></i></div>
                    <asp:DropDownList CssClass="form-select" ID="DropDownListUpdateLoc" runat="server"></asp:DropDownList>
                </div>
            </div>

            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Nueva Contraseña:</Label>
                <div class="input-group">
                    <div class="input-group-text"><i class="bi bi-lock-fill"></i></div>
                    <asp:TextBox CssClass="form-Control" ID="TxtBoxUpdatePsw" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <asp:Label ID="lbErrorPsw" runat="server" CssClass="form-text text-danger" Text="La contraseña debe tener: 8 caracteres, Mayuscula, Minuscula y un Simbolo" Visible="False"></asp:Label>
            </div>

            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Confirmar Contraseña:</Label>
                <div class="input-group">
                    <div class="input-group-text"><i class="bi bi-lock-fill"></i></div>
                    <asp:TextBox CssClass="form-Control" ID="TxtBoxUpdatePswCon" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <asp:Label ID="lbErrorPswCon" runat="server" CssClass="form-text text-danger" Text="Las contraseñas no son iguales" Visible="False"></asp:Label>
            </div>
            
            <div class="col-md-6 col-sm-12">
                <asp:Label ID="LbCompulsoryCamps" CssClass="form-text text-danger" runat="server" Text="Porfavor rellena los campos obligatorios" Visible="False"></asp:Label>
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
                <div class="input-group">
                    <div class="input-group-text"><i class="bi bi-person-fill"></i></div>
                    <asp:Label CssClass="form-control" id="LbUsername" runat="server"></asp:Label>
                </div>
            </div>
            <!--Campos Email -->
            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Email:</Label>
                <div class="input-group">
                    <div class="input-group-text"><i class="bi bi-envelope-fill"></i></div>
                    <asp:Label CssClass="form-control" id="LbEmail" runat="server"></asp:Label>
                </div>
                
            </div>
            <!--Campos Localidad -->
            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Localidad:</Label>
                <div class="input-group">
                    <div class="input-group-text"><i class="bi bi-flag-fill"></i></div>
                    <asp:Label CssClass="form-control" id="LbLocalidad" runat="server"></asp:Label>
                </div>
            </div>
            <!--Boton Activar Edicion -->
            <div class="col-md-6 col-sm-12">
                <Label class="form-label">Editar:</Label> <br />
                <asp:Button onclick="ActivarEdicion" id="BtnEditarPerfil" runat="server" Class="btn btn-warning" role="button" Text="📝Editar Perfil"/>
            </div>
        </div>
        
    </div>
</asp:Content>
