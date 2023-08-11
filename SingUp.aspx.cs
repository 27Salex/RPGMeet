using BackRPG.Model;
using RPGMeet.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    public partial class SingUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckPass();
        }

        protected void BtnRegisterCreate_Click(object sender, EventArgs e)
        {
            
        }

        void CreateUser()
        {
            string email = TxtBoxRegisterMail.Text;
            string pass = TxtBoxRegisterPsw.Text;
            string username = TxtBoxRegisterUser.Text;
            int localidad = 1;
            Usuario newUser = new Usuario(email, pass, username, localidad);
        }

        void CheckPass()
        {
            if(TxtBoxRegisterPsw.Text != TxtBoxRegisterPswCon.Text)
            {

            }
        }
    }
}