using RPGMeet.DAL;
using RPGMeet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string message = "";
            string email = txtEmail.Text;
            string pwd = txtPwd.Text;
            Usuario user = null;

            user = DalUsuario.Login(email, pwd);
            if (user != null)
                message = "El usuario o contraseña son incorrectos";
            else
                message = "Login exitoso";
            Message.Text = message;
            
        }
    }
}