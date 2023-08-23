
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
    //TO DO:
    //Cargar Localidad al Dropdown
    //Comprobar Contraseñas
    //Comprovar si el User existe
    //Mostrar si falla
    public partial class Profile : System.Web.UI.Page
    {
        private Usuario usuarioActivo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null && Session["UserID"] != null)
            {
                usuarioActivo = DalUsuario.SelectById(int.Parse(Session["UserID"].ToString()));
                LbUsername.Text = usuarioActivo.Username;
                LbEmail.Text = usuarioActivo.Email;
                LbLocalidad.Text = usuarioActivo.FKLocalidad.ToString();
            }
            else
                Response.Redirect("/Login");
            
            
            //Cargar lista de localidades de la base de datos a DropDownListUpdateLoc
        }

        
        protected void BtnUpdateCreate_Click(object sender, EventArgs e)
        {
            bool camps = CheckCamps();
            bool pass = CheckPass();

            if (camps && pass) //Comprovar todas las condiciones antes de crear el Usuario
            {
                UpdateUser();
            }
        }

        void UpdateUser()
        {
            string pass = TxtBoxUpdatePsw.Text;
            string username = TxtBoxUpdateUser.Text;
            int localidad = DropDownListUpdateLoc.TabIndex;
            Usuario newUser = new Usuario(null, pass, username, localidad);
            newUser.IdUsuario = int.Parse(Session["UserID"].ToString());
            Usuario createdUser = DalUsuario.Update(newUser);
        }

        bool CheckCamps() //Mostrar si los campos estan vacios
        {
            bool correctCamps;
            if (TxtBoxUpdateUser.Text.IsNullOrWhiteSpace() ||
                TxtBoxUpdatePsw.Text.IsNullOrWhiteSpace() || TxtBoxUpdatePswCon.Text.IsNullOrWhiteSpace())
            {
                correctCamps = false;
                LbCompulsoryCamps.Visible = true;
            }
            else
            {
                correctCamps = true;
                LbCompulsoryCamps.Visible = false;
            }

            if (correctCamps) //Marcar en rojo los campos obligatorios
            {
                TxtBoxUpdateUser.BackColor = Color.FromArgb(255, 155, 122);
                TxtBoxUpdatePsw.BackColor = Color.FromArgb(255, 155, 122);
                TxtBoxUpdatePswCon.BackColor = Color.FromArgb(255, 155, 122);
                LbCompulsoryCamps.Visible = true;
            }
            else
            {
                TxtBoxUpdateUser.BackColor = Color.White;
                TxtBoxUpdatePsw.BackColor = Color.White;
                TxtBoxUpdatePswCon.BackColor = Color.White;
                LbCompulsoryCamps.Visible = false;
            }

            

            return correctCamps;
        }

        bool CheckPass() //Comprovar que la contraseña cumple los requisitos y mostrarle al usuario si no es el caso
        {
            var regexItem = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            bool completePsw = false;

            if (regexItem.IsMatch(TxtBoxUpdatePsw.Text)) //La contraseña cumple con los parámetros
            {
                lbErrorPsw.Visible = false;
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
            
        }
        public void DesactivarEdicion(object sender, EventArgs e)
        {
            ShowUser.Visible = true;
            EditUser.Visible = false;
        }
    }
}