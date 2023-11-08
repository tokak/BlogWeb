using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminHobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            TextBox2.Text = id.ToString();
            //TextBox2.Enabled = false;

            if (Page.IsPostBack==false)
            {
                DateSetTableAdapters.TBLHOBILERTableAdapter dt = new DateSetTableAdapters.TBLHOBILERTableAdapter();
                dt.HobiGetir(Convert.ToInt32(TextBox2.Text));
                TextBox2.Text = dt.HobiGetir(Convert.ToInt32(TextBox2.Text))[0].HOBI;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateSetTableAdapters.TBLHOBILERTableAdapter dt = new DateSetTableAdapters.TBLHOBILERTableAdapter();
            dt.HobiGuncelle(TextBox1.Text,Convert.ToInt32(TextBox2.Text));
            Response.Redirect("HobiListesi.aspx");
        }
    }
}