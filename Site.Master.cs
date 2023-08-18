using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                LoggedProfile.Visible = true;
                UnLoggedProfile.Visible = false;
            }
            else
            {
                LoggedProfile.Visible = false;
                UnLoggedProfile.Visible = true;
            }
        }
        public void CerrarSesion(object sender, EventArgs e)
        {
            Session.Clear();
        }
    }
}