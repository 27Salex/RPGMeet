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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
                Response.Redirect("/Profile");
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string message = "";
            string email = txtEmail.Text;
            string pwd = txtPwd.Text;
            Usuario user = null;

            user = DalUsuario.Login(email, pwd);
            if (user == null)
            {
                message = "El usuario o contraseña son incorrectos";
                Message.Text = message;
            }
            else
            {
                message = user.ToString();
                Session.Add("Username", user.Username);
                Session.Add("UserID", user.IdUsuario);
                Response.Redirect("/");
            }
        }
    }
}