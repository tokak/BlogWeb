using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminYetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            DateSetTableAdapters.TBLYETENEKLERTableAdapter dt = new DateSetTableAdapters.TBLYETENEKLERTableAdapter();
            dt.YetenekSil(id);
            Response.Redirect("AdminYetenek.aspx");
        }
    }
}