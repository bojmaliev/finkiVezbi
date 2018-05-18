using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["kupeni"] == null)
        {
            Response.Write("Nemate nitu 1 element vo kosnickata");
        }
        else {
            List<string[]> kup = (List<string[]>)Session["kupeni"];
            int vkupno = 0;
            foreach (string[] ele in kup) {
                lbKosnicka.Items.Add(ele[0]);
                vkupno += Convert.ToInt32(ele[1]);

            }
            Vkupno.Text = vkupno.ToString();
        }

    }
}