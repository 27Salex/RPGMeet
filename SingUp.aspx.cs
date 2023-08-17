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
    //Cargar Localidad al Dropdown
    //Mostrar si falla
    public partial class SingUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Cargar lista de localidades de la base de datos a DropDownListRegisterLoc
        }

        
        protected void BtnRegisterCreate_Click(object sender, EventArgs e)
        {
            bool camps = CheckCamps();
            bool pass = CheckPass();
            bool user = UsedUsername();

            if (camps && user && pass) //Comprovar todas las condiciones antes de crear el Usuario
            {
                CreateUser();
            }
        }

        void CreateUser()
        {
            string email = TxtBoxRegisterMail.Text;
            string pass = TxtBoxRegisterPsw.Text;
            string username = TxtBoxRegisterUser.Text;
            int localidad = DropDownListRegisterLoc.TabIndex;
            Usuario newUser = new Usuario(email, pass, username, localidad);
            //Usuario createdUser = DalUsuario.Register(newUser);
        }

        bool CheckCamps() //Mostrar si los campos estan vacios
        {
            bool correctCamps = true;

            if (TxtBoxRegisterUser.Text.IsNullOrWhiteSpace())
            {
                TxtBoxRegisterUser.BackColor = Color.FromArgb(255, 155, 122);
                correctCamps = false;
            }
            else
            {
                TxtBoxRegisterUser.BackColor = Color.White;
            }

            if (TxtBoxRegisterUser.Text.IsNullOrWhiteSpace())
            {
                TxtBoxRegisterMail.BackColor = Color.FromArgb(255, 155, 122);
                correctCamps = false;
            }
            else
            {
                TxtBoxRegisterMail.BackColor = Color.White;
            }

            if (TxtBoxRegisterPsw.Text.IsNullOrWhiteSpace())
            {
                TxtBoxRegisterPsw.BackColor = Color.FromArgb(255, 155, 122);
                correctCamps = false;
            }
            else
            {
                TxtBoxRegisterPsw.BackColor = Color.White;
            }

            if (TxtBoxRegisterPswCon.Text.IsNullOrWhiteSpace())
            {
                TxtBoxRegisterPswCon.BackColor = Color.FromArgb(255, 155, 122);
                correctCamps = false;
            }
            else
            {
                TxtBoxRegisterPswCon.BackColor = Color.White;
            }
            
            return correctCamps;
        }

        bool CheckPass() //Comprovar que la contraseña cumple los requisitos y mostrarle al usuario si no es el caso
        {
            var regexItem = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            bool completePsw = false;

            if (regexItem.IsMatch(TxtBoxRegisterPsw.Text)) //La contraseña cumple con los parámetros
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
            Usuario test = DalUsuario.CheckUsername(TxtBoxRegisterUser.Text);
            if (test == null)
            {
                notPicked = true;
                lbErrorUser.Visible = false;
            }
            else
            {
                TxtBoxRegisterUser.BackColor = Color.FromArgb(255, 155, 122);
                lbErrorUser.Visible = true;
            }
            return notPicked;
        }
    }
}