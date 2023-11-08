using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class HobiListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateSetTableAdapters.TBLHOBILERTableAdapter dt = new DateSetTableAdapters.TBLHOBILERTableAdapter();
            Repeater1.DataSource = dt.HobilerListesi();
            Repeater1.DataBind();
        }
    }
}