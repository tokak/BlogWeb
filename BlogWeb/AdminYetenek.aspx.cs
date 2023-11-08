using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminYetenek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateSetTableAdapters.TBLYETENEKLERTableAdapter dt = new DateSetTableAdapters.TBLYETENEKLERTableAdapter();
            Repeater1.DataSource = dt.YetenekListesi();
            Repeater1.DataBind();
        }
    }
}