using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            lblKategorija.Text = Request.QueryString["ime"];
            int a = Convert.ToInt32(Request.QueryString["id"]);
            string[] avtomobili = { "Bmw", "Audi" };
            string[] avtomobiliC = { "1700", "2000" };

            string[] tehnologija = { "iphone 8", "samsung" };
            string[] tehnologijaC = { "100", "120" };

            string[] nedviznosti = { "kukja", "stan" };
            string[] nedviznostiC = { "500", "600"};
            if (a == 1)
            {
                lbProizvodi.DataSource = avtomobili;
                lbCeni.DataSource = avtomobiliC;

            }
            else if (a == 2)
            {
                lbProizvodi.DataSource = tehnologija;
                lbCeni.DataSource = tehnologijaC;
            }
            else if (a == 3) {
                lbProizvodi.DataSource = nedviznosti;
                lbCeni.DataSource = nedviznostiC;
            }
            lbProizvodi.DataBind();
            lbCeni.DataBind();
        }


    }


    protected void lbProizvodi_SelectedIndexChanged(object sender, EventArgs e)
    {
        lbCeni.SelectedIndex = lbProizvodi.SelectedIndex;
    }

    protected void btnDodadiKosnicka_Click(object sender, EventArgs e)
    {
        lbProizvodiKosnicka.Items.Add(lbProizvodi.SelectedItem.ToString());
        lbCeniKosnicka.Items.Add(lbCeni.SelectedItem.ToString());
    }

    protected void lbProizvodiKosnicka_SelectedIndexChanged(object sender, EventArgs e)
    {
        lbCeniKosnicka.SelectedIndex = lbProizvodiKosnicka.SelectedIndex;
    }

    protected void btnKupi_Click(object sender, EventArgs e)
    {
        List<string[]> kupeni = new List<string[]>();

        for (int i = 0; i < lbProizvodiKosnicka.Items.Count; i++) {
            string[] item = {lbProizvodi.Items[i].ToString(), lbCeniKosnicka.Items[i].ToString()};

            kupeni.Add(item);
        }

        Session["kupeni"] = kupeni;
        Response.Redirect("~/Plakanje.aspx");

    }
}