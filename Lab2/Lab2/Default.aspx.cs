using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] meseci = new string[12] { "Јануари", "Февруари", "Март", "Април", "Мај", "Јуни", "Јули", "Август", "Септември", "Октомври", "Ноември", "Декември" };
        ddlMesec.DataSource = meseci;
        ddlMesec.DataBind();

        for (int i = 1; i <= 31; i++) ddlDen.Items.Add(i.ToString());

        DateTime dt = DateTime.Today;
        for (int i = dt.Year; i <= dt.Year + 5; i++) {
            ddlGodina.Items.Add(i.ToString());
        }
        for (int i = 0; i < 24; i++) {
            ddlVreme.Items.Add(string.Format("{0:D2}", i));
        }
    }

    protected void btnPodnesi_Click(object sender, EventArgs e)
    {
        pnlPanela1.Visible = true;
        lblPatnik.Text = txtIme.Text + " " + txtPrezime.Text;
        lblSredstvo.Text = lstSredstvo.SelectedValue;
        lblOd.Text = ddlOd.SelectedValue;
        lblDo.Text = ddlDo.SelectedValue;
        lblVreme.Text = ddlDen.SelectedValue + "." + ddlMesec.SelectedValue + "." + ddlGodina.SelectedValue + " во " + ddlVreme.Text + " часот";
        lblZona.Text = rblZona.SelectedValue;
        lblKlasa.Text = rblKlasa.SelectedValue;
        lblPosluga.Text = "";
        for (int i = 0; i < cblPosluga.Items.Count; i++) {
            if(cblPosluga.Items[i].Selected)
                lblPosluga.Text += cblPosluga.Items[i].Text+" ";
        }
        if (lstSredstvo.SelectedValue == "Авион")
        {
            Image1.ImageUrl = "images/plane.jpg";
        }
        else {
            Image1.ImageUrl = "images/train.jpg";
        }

    }
}