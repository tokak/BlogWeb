using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["[ID]"]);
            TxtId.Text = Convert.ToString(id);
            if (Page.IsPostBack == false)
            {
                DateSetTableAdapters.TBLDENEYIMTableAdapter dt = new DateSetTableAdapters.TBLDENEYIMTableAdapter();
                TxtBaslik.Text = dt.DeneyimGetir(Convert.ToInt32(id))[0].BASLIK;
                TxtAltBaslik.Text = dt.DeneyimGetir(Convert.ToInt32(id))[0].ALTBASLIK;
                TxtAciklama.Text = dt.DeneyimGetir(Convert.ToInt32(id))[0].ACIKLAMA;
                TxtTarih.Text = dt.DeneyimGetir(Convert.ToInt32(id))[0].TARIH;

            }

        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DateSetTableAdapters.TBLDENEYIMTableAdapter dt = new DateSetTableAdapters.TBLDENEYIMTableAdapter();
            dt.DeneyimGuncelle(TxtBaslik.Text,TxtAltBaslik.Text,TxtAciklama.Text,TxtTarih.Text,Convert.ToInt32(TxtId.Text));
        }
    }
}