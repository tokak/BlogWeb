using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminHobiSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            DateSetTableAdapters.TBLHOBILERTableAdapter dt = new DateSetTableAdapters.TBLHOBILERTableAdapter();
            dt.HobiSil(id);
            Response.Redirect("HobiListesi.aspx");
        }
    }
}