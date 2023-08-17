
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

            if (camps && pass) //Comprovar todas las condiciones antes de crear el Usuario
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
            bool correctCamps;
            if (TxtBoxRegisterMail.Text.IsNullOrWhiteSpace() || TxtBoxRegisterUser.Text.IsNullOrWhiteSpace() ||
                TxtBoxRegisterPsw.Text.IsNullOrWhiteSpace() || TxtBoxRegisterPswCon.Text.IsNullOrWhiteSpace())
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
                TxtBoxRegisterUser.BackColor = Color.FromArgb(255, 155, 122);
                TxtBoxRegisterMail.BackColor = Color.FromArgb(255, 155, 122);
                TxtBoxRegisterPsw.BackColor = Color.FromArgb(255, 155, 122);
                TxtBoxRegisterPswCon.BackColor = Color.FromArgb(255, 155, 122);
                LbCompulsoryCamps.Visible = true;
            }
            else
            {
                TxtBoxRegisterUser.BackColor = Color.White;
                TxtBoxRegisterMail.BackColor = Color.White;
                TxtBoxRegisterPsw.BackColor = Color.White;
                TxtBoxRegisterPswCon.BackColor = Color.White;
                LbCompulsoryCamps.Visible = false;
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
    }
}