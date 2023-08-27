
﻿using RPGMeet.Model;
using Microsoft.Ajax.Utilities;
﻿using Antlr.Runtime.Misc;
using RPGMeet.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    public partial class Profile : System.Web.UI.Page
    {
        private Usuario usuarioActivo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null && Session["UserID"] != null)
            {
                usuarioActivo = DalUsuario.SelectById(int.Parse(Session["UserID"].ToString()));
                if (usuarioActivo == null)
                    Response.Redirect("/Profile");
                else
                {
                    foreach (TextBox txtbox in this.Controls.OfType<TextBox>())
                        txtbox.CssClass = "form-control";
                    foreach (DropDownList dropDownList in this.Controls.OfType<DropDownList>())
                        dropDownList.CssClass = "form-select";
                    if (!IsPostBack)
                    {
                        List<string> localidades = new List<string>();
                        localidades.Add("Selecciona una opción");

                        foreach (Localidad loc in DalLocalidad.SelectAll())
                        {
                            localidades.Add(loc.NombreLocalidad);
                        }

                        DropDownListUpdateLoc.DataSource = localidades;
                        DropDownListUpdateLoc.DataBind();
                    }
                    LbUsername.Text = usuarioActivo.Username;
                    LbEmail.Text = usuarioActivo.Email;

                    Localidad localidad = DalLocalidad.SelectById(usuarioActivo.FKLocalidad);
                    LbLocalidad.Text = "No selecionado";
                    if (localidad != null)
                        LbLocalidad.Text = localidad.NombreLocalidad;

                    DropDownListUpdateLoc.DataBind();
                }
            }
            else
                Response.Redirect("/Login");
        }

        
        protected void BtnUpdateCreate_Click(object sender, EventArgs e)
        {
            bool camps = CheckCamps();
            bool pass = CheckPass();
            bool user = UsedUsername();

            if (camps && pass && user) //Comprovar todas las condiciones antes de crear el Usuario
            {
                UpdateUser();
            }
        }

        void UpdateUser()
        {
            string pass = TxtBoxUpdatePsw.Text.Trim();
            string username = TxtBoxUpdateUser.Text.Trim();
            int? idLocalidad = null;
            if (DropDownListUpdateLoc.SelectedIndex != 0)
                idLocalidad = DalLocalidad.GetIdByName(DropDownListUpdateLoc.SelectedValue);

            LbLocalidad.Text = DropDownListUpdateLoc.SelectedValue;
            LbUsername.Text = TxtBoxUpdateUser.Text;

            Usuario newUser = new Usuario(null, pass, username, idLocalidad);
            newUser.IdUsuario = int.Parse(Session["UserID"].ToString());
            Usuario createdUser = DalUsuario.Update(newUser);
            if (createdUser != null)
            {
                DesactivarEdicion(null, EventArgs.Empty);
            }
        }

        bool CheckCamps() //Mostrar si los campos estan vacios
        {
            bool correctCamps = true;

            if (TxtBoxUpdateUser.Text.IsNullOrWhiteSpace())
            {
                TxtBoxUpdateUser.CssClass = "form-control is-invalid";
                correctCamps = false;
            }
            else
            {
                TxtBoxUpdateUser.CssClass = "form-control is-valid";
            }
            if (TxtBoxUpdatePsw.Text.IsNullOrWhiteSpace())
            {
                TxtBoxUpdatePsw.CssClass = "form-control is-invalid";
                correctCamps = false;
            }
            else
            {
                TxtBoxUpdatePsw.CssClass = "form-control is-valid";
            }

            if (TxtBoxUpdatePswCon.Text.IsNullOrWhiteSpace())
            {
                TxtBoxUpdatePswCon.CssClass = "form-control is-invalid";
                correctCamps = false;
            }
            else
            {
                TxtBoxUpdatePswCon.CssClass = "form-control is-valid";
            }

            return correctCamps;
        }
        bool UsedUsername() //Devuelve si el Username ya esta seleccionado
        {
            bool notPicked = false;
            Usuario user = DalUsuario.CheckUsername(TxtBoxUpdateUser.Text.Trim());
            if (user == null || TxtBoxUpdateUser.Text.Trim() == Session["Username"].ToString())
            {
                notPicked = true;
                TxtBoxUpdateUser.CssClass = "form-control is-valid";
                lbErrorUser.Visible = false;
            }
            else
            {
                TxtBoxUpdateUser.CssClass = "form-control is-invalid";
                lbErrorUser.Visible = true;
            }
            return notPicked;
        }
        bool CheckPass() //Comprovar que la contraseña cumple los requisitos y mostrarle al usuario si no es el caso
        {
            var regexItem = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            bool completePsw = false;

            if (regexItem.IsMatch(TxtBoxUpdatePsw.Text)) //La contraseña cumple con los parámetros
            {
                lbErrorPsw.Visible = false;
                TxtBoxUpdatePsw.CssClass = "form-control is-invalid";
                TxtBoxUpdatePswCon.CssClass = "form-control is-invalid";

            }
            else
            {
                lbErrorPsw.Visible = true;
            }

            if (TxtBoxUpdatePswCon.Text == TxtBoxUpdatePsw.Text) //Las contraseñas son iguales
            {
                lbErrorPswCon.Visible = false;
            }
            else
            {
                lbErrorPswCon.Visible = true;
                TxtBoxUpdatePsw.CssClass = "form-control is-invalid";
                TxtBoxUpdatePswCon.CssClass = "form-control is-invalid";
            }

            //Si las dos condiciones son correctas permite la creación en este apartado
            if (regexItem.IsMatch(TxtBoxUpdatePsw.Text) && TxtBoxUpdatePswCon.Text == TxtBoxUpdatePsw.Text)
            {
                completePsw = true;
            }

            return completePsw;
        }
        public void ActivarEdicion(object sender, EventArgs e)
        {
            //Intercambiamos el formulario a modo edicion
            ShowUser.Visible = false;
            EditUser.Visible = true;

            //Cargamos los valores del usuario activo
            TxtBoxUpdateUser.Text = usuarioActivo.Username;
            TxtBoxUpdatePsw.Text = usuarioActivo.Pass;
            TxtBoxUpdatePswCon.Text = usuarioActivo.Pass; 
            
            if (usuarioActivo.FKLocalidad != null)
            {
                DropDownListUpdateLoc.SelectedIndex = (int)usuarioActivo.FKLocalidad;
            }
            TxtBoxUpdateUser.CssClass = "form-control";
            TxtBoxUpdatePswCon.CssClass = "form-control";
            TxtBoxUpdateUser.CssClass = "form-control";



        }
        public void DesactivarEdicion(object sender, EventArgs e)
        {
            ShowUser.Visible = true;
            EditUser.Visible = false;
            // Response.r
        }
    }
}