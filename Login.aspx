<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RPGMeet.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="login-page bg-light">
        <div class="container">
            <div class="row">
                <div class="col-lg-10 offset-lg-1">
                  <h3 class="mb-3">Login</h3>
                    <div class="bg-white shadow rounded">
                        <div class="row">
                            <div class="col-md-7 pe-0">
                                <div class="form-left h-100 py-5 px-5">
                                    <div class="row g-4">
                                            <div class="col-12">
                                                <label>Email<span class="text-danger">*</span></label>
                                                <div class="input-group">
                                                    <div class="input-group-text"><i class="bi bi-person-fill"></i></div>
                                                        <asp:TextBox id="txtEmail" TextMode="Password" runat="server" class="form-control" placeholder="Introduce tu email">
                                                        </asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="col-12">
                                                <label>Password<span class="text-danger">*</span></label>
                                                <div class="input-group">
                                                    <div class="input-group-text"><i class="bi bi-lock-fill"></i></div>
                                                    <asp:TextBox id="txtPwd" TextMode="Password" runat="server" class="form-control" placeholder="Introduce tu contraseña">
                                                    </asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="col-sm-6">
                                                <div class="form-check">
                                                    <asp:CheckBox runat="server" class="form-check-input" type="checkbox" id="inlineFormCheck">
                                                    </asp:CheckBox>
                                                    <label class="form-check-label" for="inlineFormCheck">Recuérdame</label>
                                                </div>
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
                            <div class="col-md-5 ps-0 d-none d-md-block">
                                <div class="form-right h-100 bg-dark text-white text-center pt-5">
                                    <a href="/">
                                        <img width="100%" src="https://i.ibb.co/V26QgkG/Large-Logo-Inverted-Transparent.png"/>
                                    </a>
                                    <h2 class="fs-1">Bienvenido de nuevo!!!</h2>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

