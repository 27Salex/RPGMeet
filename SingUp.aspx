<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SingUp.aspx.cs" Inherits="RPGMeet.SingUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Image ID="LogoRegister" runat="server" />
    </div>
    <div>
        <h2>Crear Cuenta</h2>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario:"></asp:Label>
        <asp:TextBox ID="TxtBoxRegisterUser" runat="server"></asp:TextBox>
        <asp:Label ID="lbErrorUser" runat="server" Text="Usuario no disponible" Font-Italic="True" ForeColor="#FF3300" Visible="False"></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Mail:"></asp:Label>
        <asp:TextBox ID="TxtBoxRegisterMail" runat="server" TextMode="Email"></asp:TextBox>
        <asp:Label ID="lbErrorMail" runat="server" Text="Correo Erroneo" Font-Italic="True" ForeColor="#FF3300" Visible="False"></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Contraseña:"></asp:Label>
        <asp:TextBox ID="TxtBoxRegisterPsw" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lbErrorPsw" runat="server" Text="La contraseña debe tener: 8 caracteres, Mayuscula, Minuscula y un Simbolo" Font-Italic="True" ForeColor="#FF3300" Visible="False"></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label4" runat="server" Text="Confirmar Contraseña:"></asp:Label>
        <asp:TextBox ID="TxtBoxRegisterPswCon" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lbErrorPswCon" runat="server" Text="Las contraseñas no son iguales" Font-Italic="True" ForeColor="#FF3300" Visible="False"></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Localidad"></asp:Label>
        <asp:DropDownList ID="DropDownListRegisterLoc" runat="server">
            
        </asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="LbCompulsoryCamps" runat="server" Text="Porfavor rellena los campos obligatorios" Font-Bold="True" Font-Italic="True" ForeColor="Red" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="BtnRegisterCreate" runat="server" OnClick="BtnRegisterCreate_Click" Text="Crear Cuenta" />
    </div>
</asp:Content>
