using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["[ID]"]);
            TextBox6.Text = Convert.ToString(id);
            if (Page.IsPostBack == false)
            {
                DateSetTableAdapters.TBLEGITIMTableAdapter dt = new DateSetTableAdapters.TBLEGITIMTableAdapter();
                TextBox1.Text = dt.EgitimGetir(Convert.ToInt32(id))[0].BASLIK;
                TextBox2.Text = dt.EgitimGetir(Convert.ToInt32(id))[0].ALTBASLIK;
                TextBox3.Text = dt.EgitimGetir(Convert.ToInt32(id))[0].ACIKLAMA;
                TextBox5.Text = dt.EgitimGetir(Convert.ToInt32(id))[0].GNOT;
                TextBox4.Text = dt.EgitimGetir(Convert.ToInt32(id))[0].TARIH;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateSetTableAdapters.TBLEGITIMTableAdapter dt = new DateSetTableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimGuncelle(TextBox1.Text,TextBox2.Text,TextBox3.Text,TextBox5.Text,TextBox4.Text,Convert.ToInt32(TextBox6.Text));
            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}