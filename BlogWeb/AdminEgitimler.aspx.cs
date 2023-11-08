﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateSetTableAdapters.TBLEGITIMTableAdapter dt = new DateSetTableAdapters.TBLEGITIMTableAdapter();
            Repeater1.DataSource = dt.EgitimListele();
            Repeater1.DataBind();

        }
    }
}