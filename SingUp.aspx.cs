using Antlr.Runtime.Misc;
using BackRPG.Model;
using RPGMeet.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    //TO DO: Evitar que se introduzcan datos vacios,
    //Cargar Localidad al Dropdown
    //Comprobar Contraseñas
    //Mostrar Campos Obligatorios
    //Mostrar si falla
    public partial class SingUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Cargar lista de localidades de la base de datos a DropDownListRegisterLoc
        }

        protected void BtnRegisterCreate_Click(object sender, EventArgs e)
        {
            CheckPass();
        }

        void CreateUser()
        {
            string email = TxtBoxRegisterMail.Text;
            string pass = TxtBoxRegisterPsw.Text;
            string username = TxtBoxRegisterUser.Text;
            int localidad = DropDownListRegisterLoc.TabIndex;
            Usuario newUser = new Usuario(email, pass, username, localidad);
            //Usuario test = DalUsuario.Register(newUser);
            /*
            if (test != null) 
            {
                LbUserCreation.Text = test.ToString();
            }
            else
            {
                LbUserCreation.Text = "Error";
            }
            //LbUserCreation.Text = test.ToString();
            */
        }

        void CheckPass()
        {
            var regexItem = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            
            if (!regexItem.IsMatch(TxtBoxRegisterPsw.Text))
            {
                lbErrorPsw.Visible = true;
            }
            if (TxtBoxRegisterPswCon.Text != TxtBoxRegisterPsw.Text)
            {
                lbErrorPswCon.Visible = true;
            }

            if (regexItem.IsMatch(TxtBoxRegisterPsw.Text))
            {
                lbErrorPsw.Visible = false;
            }
            if (TxtBoxRegisterPswCon.Text == TxtBoxRegisterPsw.Text)
            {
                lbErrorPswCon.Visible = false;
            }
        }
    }
}