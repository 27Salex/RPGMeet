<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SingUp.aspx.cs" Inherits="RPGMeet.SingUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="login-page bg-light">
    <div class="container">
        <div class="row">
            <div class="col-lg-10 offset-lg-1">
              <h3 class="mb-3">Crear Cuenta</h3>
                <div class="bg-white shadow rounded">
                    <div class="row">
                        <!-- Aqui empieza el cuadrado izquierdo-->
                        <div class="col-md-7 pe-0">
                            <div class="form-left h-100 py-5 px-5">
                                <div class="row g-4">
   
                                    <div class="col-12">
                                        <label>Nombre de usuario<span class="text-danger">*</span></label>
					                    <asp:TextBox ID="TxtBoxRegisterUser" CssClass="form-control" placeholder="Introduce un nombre de usuario" runat="server"></asp:TextBox>
					                    <asp:Label ID="lbErrorUser" runat="server" Text="Usuario no disponible" CssClass="form-text text-danger" Visible="False"></asp:Label>
                                    </div>

				                    <div class="col-12">
                                        <label>Email<span class="text-danger">*</span></label>
					                    <asp:TextBox ID="TxtBoxRegisterMail" CssClass="form-control" placeholder="Introduce un email" runat="server" TextMode="Email"></asp:TextBox>
					                    <asp:Label ID="lbErrorMail" runat="server" Text="Correo ya existente" CssClass="form-text text-danger" Visible="False"></asp:Label>
                                    </div>

				                    <div class="col-12">
                                        <label>Contraseña<span class="text-danger">*</span></label>
					                    <asp:TextBox ID="TxtBoxRegisterPsw" CssClass="form-control" placeholder="Introduce una contraseña" runat="server" TextMode="Password"></asp:TextBox>
					                    <asp:Label ID="lbErrorPsw" runat="server" Text="La contraseña debe tener: 8 caracteres, Mayuscula, Minuscula y un Simbolo" CssClass="form-text text-danger" Visible="False"></asp:Label>
                                    </div>

				                    <div class="col-12">
                                        <label>Repite tu contraseña<span class="text-danger">*</span></label>
					                    <asp:TextBox ID="TxtBoxRegisterPswCon" CssClass="form-control" placeholder="Confirma tu contraseña" runat="server" TextMode="Password"></asp:TextBox>
					                    <asp:Label ID="lbErrorPswCon" runat="server" Text="Las contraseñas no son iguales" CssClass="form-text text-danger" Visible="False"></asp:Label>
                                    </div>

				                    <div class="col-12">
                                        <label>Localidad</label>
					                    <asp:DropDownList ID="DropDownListRegisterLoc" CssClass="form-select" runat="server">           
					                    </asp:DropDownList>
                                    </div>

                                    <div class="col-sm-6">
					                    <asp:Label ID="LbCompulsoryCamps" runat="server" Text="Porfavor rellena los campos obligatorios" CssClass="text-danger" Visible="False"></asp:Label>
                                    </div>

                                    <div class="col-sm-6">
                                        <a href="/Login" class="float-end text-primary">Ya tienes una cuenta?</a>
                                    </div>

                                    <div class="col-12">
                                        <asp:Button runat="server" type="submit" class="btn btn-primary px-4 float-end mt-4" ID="BtnRegisterCreate" OnClick="BtnRegisterCreate_Click" Text="Crear Cuenta">
                                        </asp:Button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!--Aqui el cuadrado izquierdo-->
                        <div class="col-md-5 ps-0 d-none d-md-block">
                            <div class="form-right h-100 bg-dark text-white text-center pt-5">
                                <a href="/">
                                    <img width="100%" src="https://i.ibb.co/V26QgkG/Large-Logo-Inverted-Transparent.png"/>
                                </a>
                                <h2 class="fs-1">¿¿Listo para empezar tu aventura??</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>
