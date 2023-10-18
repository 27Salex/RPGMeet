<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RPGMeet.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="login-page">
        <div class="container">
            <div class="row">
                <div class="col-lg-10 offset-lg-1">
                  <h3 class="mb-3">Login</h3>
                    <div class="bg-glass shadow rounded animate__animated animate__fadeInUp">
                        <div class="row">
                            <!-- Aqui empieza el cuadrado izquierdo-->
                            <div class="col-md-7 pe-0">
                                <div class="form-left h-100 py-5 px-5">
                                    <div class="row g-4">                                        
                                        <div class="col-12">
                                            <label>Email<span class="text-danger">*</span></label>
                                            <div class="input-group">
                                                <div class="input-group-text bg-glass"><i class="bi bi-envelope-fill"></i></div>
                                                <asp:TextBox id="txtEmail" TextMode="Email" runat="server" class="form-control" placeholder="Introduce tu email">
                                                </asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="col-12">
                                            <label>Password<span class="text-danger">*</span></label>
                                            <div class="input-group">
                                                <div class="input-group-text bg-glass"><i class="bi bi-lock-fill"></i></div>
                                                <asp:TextBox id="txtPwd" TextMode="Password" runat="server" CssClass="form-control" placeholder="Introduce tu contraseña">
                                                </asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="col-sm-6">
                                            <asp:CheckBox runat="server" type="checkbox" id="inlineFormCheck">
                                            </asp:CheckBox>
                                            <label class="form-check-label" for="inlineFormCheck">Recuérdame</label>
                                            <asp:label ID="Message" runat="server" CssClass="form-text text-danger"></asp:label>
                                        </div>

                                        <div class="col-sm-6">
                                            <a href="/SingUp" class="float-end text-primary">No tienes una cuenta?</a>
                                        </div>

                                        <div class="col-12">
                                            <asp:Button runat="server" type="submit" class="btn btn-primary px-4 float-end mt-4" Text="login" ID="btnLogin" OnClick="BtnLogin_Click">
                                            </asp:Button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!--Aqui el cuadrado izquierdo-->
                            <div class="col-md-5 ps-0 d-none d-md-block">
                                <div class="form-right h-100 text-center pt-5">
                                    <a href="/">
                                        <img width="100%" src="Img/LargeLogoNewTransparent.png"/>
                                    </a>
                                    <h2 class="fs-1">¡¡Bienvenido de nuevo!!</h2>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

