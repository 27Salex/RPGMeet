﻿using RPGMeet.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] != null)
                {
                    btnCrearCuenta1.Visible = false;
                    btnCrearCuenta2.Visible = false;
                    btnCrearCuenta3.Visible = false;
                }
                else
                {
                    string urlSingUp = "./SingUp.aspx";
                    btnCrearCuenta1.PostBackUrl = urlSingUp;
                    btnCrearCuenta2.PostBackUrl = urlSingUp;
                    btnCrearCuenta3.PostBackUrl = urlSingUp;
                }
            }
        }
    }
}