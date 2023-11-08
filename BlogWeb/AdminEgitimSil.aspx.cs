using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            DateSetTableAdapters.TBLEGITIMTableAdapter dt = new DateSetTableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimSil(id);
            
            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}