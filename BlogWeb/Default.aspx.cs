using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateSetTableAdapters.TBLHAKKIMDATableAdapter dt = new DateSetTableAdapters.TBLHAKKIMDATableAdapter();
            DateSetTableAdapters.TBLDENEYIMTableAdapter dt2 = new DateSetTableAdapters.TBLDENEYIMTableAdapter();
            DateSetTableAdapters.TBLEGITIMTableAdapter dt3 = new DateSetTableAdapters.TBLEGITIMTableAdapter();
            DateSetTableAdapters.TBLHOBILERTableAdapter dt4 = new DateSetTableAdapters.TBLHOBILERTableAdapter();
            DateSetTableAdapters.TBLYETENEKLERTableAdapter dt5 = new DateSetTableAdapters.TBLYETENEKLERTableAdapter();
            Repeater1.DataSource = dt.HakkımdaListele();
            Repeater2.DataSource = dt2.DeneyimListele();
            Repeater3.DataSource = dt3.EgitimListele();
            Repeater4.DataSource = dt4.HobilerListesi();
            Repeater5.DataSource = dt5.YetenekListesi();
            Repeater1.DataBind();
            Repeater2.DataBind();
            Repeater3.DataBind();
            Repeater4.DataBind();
            Repeater5.DataBind();

        }
    }
}