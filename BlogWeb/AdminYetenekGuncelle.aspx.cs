using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminYetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateSetTableAdapters.TBLYETENEKLERTableAdapter dt = new DateSetTableAdapters.TBLYETENEKLERTableAdapter();
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            TextBox1.Text = id.ToString();
            TextBox1.Enabled = false;

            TextBox2.Text = dt.YetenekGetir(Convert.ToInt32(id))[0].YETENEK;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateSetTableAdapters.TBLYETENEKLERTableAdapter dt = new DateSetTableAdapters.TBLYETENEKLERTableAdapter();
            dt.YetenekGuncelle(TextBox2.Text,Convert.ToInt32(TextBox1.Text));
            Response.Redirect("AdminYetenek.aspx");
        }
    }
}