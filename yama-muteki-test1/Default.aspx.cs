﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text = DateTime.Now.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Label1.Text = DateTime.Now.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Label1.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }
    }
}