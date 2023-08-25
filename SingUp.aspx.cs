using RPGMeet.Model;
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
    //TO DO:
    //Mostrar si falla
    public partial class SingUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> localidades = new List<string>();
            localidades.Add("Selecciona una opción");

            foreach (Localidad localidad in DalLocalidad.SelectAll())
            {
                localidades.Add(localidad.NombreLocalidad);
            }

            DropDownListRegisterLoc.DataSource = localidades;
            DropDownListRegisterLoc.DataBind();
            foreach (TextBox txtbox in this.Controls.OfType<TextBox>())
                txtbox.CssClass = "form-control";
            foreach (DropDownList dropDownList in this.Controls.OfType<DropDownList>())
                dropDownList.CssClass = "form-select";
        }
                
        protected void BtnRegisterCreate_Click(object sender, EventArgs e)
        {
            bool camps = CheckCamps();
            bool pass = CheckPass();
            bool user = UsedUsername();
            bool mail = UsedMail();

            if (camps && user && pass && mail) //Comprovar todas las condiciones antes de crear el Usuario
                CreateUser();
        }

        void CreateUser()
        {
            string email = TxtBoxRegisterMail.Text.Trim();
            string pass = TxtBoxRegisterPsw.Text.Trim();
            string username = TxtBoxRegisterUser.Text.Trim();
            int localidad = DropDownListRegisterLoc.TabIndex;
            Usuario newUser = new Usuario(email, pass, username, localidad);
            
            
            if (DalUsuario.Register(newUser))
            {
                Response.Redirect("/Login");
            }           
        }

        bool CheckCamps() //Mostrar si los campos estan vacios
        {
            bool correctCamps = true;

            if (TxtBoxRegisterUser.Text.IsNullOrWhiteSpace())
            {
                TxtBoxRegisterUser.CssClass = "form-control is-invalid";
                correctCamps = false;
            }
            else
            {
                TxtBoxRegisterUser.CssClass = "form-control is-valid";
            }

            if (TxtBoxRegisterMail.Text.IsNullOrWhiteSpace())
            {
                TxtBoxRegisterMail.CssClass = "form-control is-invalid";
                correctCamps = false;
            }
            else
            {
                TxtBoxRegisterMail.CssClass = "form-control is-valid";
            }

            if (TxtBoxRegisterPsw.Text.IsNullOrWhiteSpace())
            {
                TxtBoxRegisterPsw.CssClass = "form-control is-invalid";
                correctCamps = false;
            }
            else
            {
                TxtBoxRegisterPsw.CssClass = "form-control is-valid";
            }

            if (TxtBoxRegisterPswCon.Text.IsNullOrWhiteSpace())
            {
                TxtBoxRegisterPswCon.CssClass = "form-control is-invalid";
                correctCamps = false;
            }
            else
            {
                TxtBoxRegisterPswCon.CssClass = "form-control is-valid";
            }
            
            return correctCamps;
        }

        bool CheckPass() //Comprovar que la contraseña cumple los requisitos y mostrarle al usuario si no es el caso
        {
            var regexItem = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            bool completePsw = false;

            if (regexItem.IsMatch(TxtBoxRegisterPsw.Text.Trim())) //La contraseña cumple con los parámetros
            {
                lbErrorPsw.Visible = false;
            }
            else
            {
                lbErrorPsw.Visible = true;
            }

            if (TxtBoxRegisterPswCon.Text == TxtBoxRegisterPsw.Text) //Las contraseñas son iguales
            {
                lbErrorPswCon.Visible = false;
            }
            else
            {
                lbErrorPswCon.Visible = true;
            }

            //Si las dos condiciones son correctas permite la creación en este apartado
            if (regexItem.IsMatch(TxtBoxRegisterPsw.Text) && TxtBoxRegisterPswCon.Text == TxtBoxRegisterPsw.Text)
            {
                completePsw = true;
            }

            return completePsw;
        }

        bool UsedUsername() //Devuelve si el Username ya esta seleccionado
        {
            bool notPicked = false;
            Usuario user = DalUsuario.CheckUsername(TxtBoxRegisterUser.Text.Trim());
            if (user == null)
            {
                notPicked = true;
                TxtBoxRegisterUser.CssClass = "form-control is-valid";
                lbErrorUser.Visible = false;
            }
            else
            {
                TxtBoxRegisterUser.CssClass = "form-control is-invalid";
                lbErrorUser.Visible = true;
            }
            return notPicked;
        }
        
        bool UsedMail() //Devuelve si el mail esta ya en la base de datos
        {
            bool notPicked = false;
            Usuario mail = DalUsuario.CheckMail(TxtBoxRegisterMail.Text.Trim());
            if (mail == null)
            {
                notPicked = true;
                TxtBoxRegisterMail.CssClass = "form-control is-valid";
                lbErrorMail.Visible = false;
            }
            else
            {
                TxtBoxRegisterMail.CssClass = "form-control is-invalid";
                lbErrorMail.Visible = true;
            }
            return notPicked;
        }
    }
}