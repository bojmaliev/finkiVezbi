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

    }

    protected void btnProveri_Click(object sender, EventArgs e)
    {
        if (txtLozinka.Text.Equals("мрежно програмирање"))
        {
            txtPoraka.ReadOnly = false;
            txtPoraka.Focus();
        }
        else {
            Response.Write("<script>alert('Лозинката не е точна')</script>");
        }
    }

    protected void txtPoraka_TextChanged(object sender, EventArgs e)
    {
        btnPrvaStrana.Enabled = true;
    }

    protected void btnPrvaStrana_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default1.aspx");
    }
}
