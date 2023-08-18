<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="RPGMeet.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Perfil</h2>
    </div>
    <div id="EditUser" runat="server" visible="false">
        <div>
            <Label>Nombre de Usuario:</Label>
            <asp:TextBox ID="TxtBoxUpdateUser" runat="server"></asp:TextBox>
            <asp:Label ID="lbErrorUser" runat="server" Text="Usuario no disponible" Font-Italic="True" ForeColor="#FF3300" Visible="False"></asp:Label>
        </div>
        <div>
            <Label>Contraseña:</Label>
            <asp:TextBox ID="TxtBoxUpdatePsw" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lbErrorPsw" runat="server" Text="La contraseña debe tener: 8 caracteres, Mayuscula, Minuscula y un Simbolo" Font-Italic="True" ForeColor="#FF3300" Visible="False"></asp:Label>
        </div>
        <div>
            <Label>Confirmar Contraseña:</Label>
            <asp:TextBox ID="TxtBoxUpdatePswCon" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lbErrorPswCon" runat="server" Text="Las contraseñas no son iguales" Font-Italic="True" ForeColor="#FF3300" Visible="False"></asp:Label>
        </div>
        <div>
            <Label>Localidad:</Label>
            <asp:DropDownList ID="DropDownListUpdateLoc" runat="server">
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="LbCompulsoryCamps" runat="server" Text="Porfavor rellena los campos obligatorios" Font-Bold="True" Font-Italic="True" ForeColor="Red" Visible="False"></asp:Label>
            <br/>
            <asp:Button ID="BtnUpdateCreate" runat="server" OnClick="BtnUpdateCreate_Click" Text="Actualizar datos" />
        </div>
    </div>
    

    <div id="ShowUser" runat="server">
        <Label>Nombre de Usuario:</Label>
        <br />
        <asp:Label id="LbUsername" runat="server"></asp:Label>
        <br />
        <Label>Email:</Label>
        <br />
        <asp:Label id="LbEmail" runat="server"></asp:Label>
        <br />
        <Label>Localidad:</Label>
        <br />
        <asp:Label id="LbLocalidad" runat="server"></asp:Label>
    </div>
</asp:Content>
