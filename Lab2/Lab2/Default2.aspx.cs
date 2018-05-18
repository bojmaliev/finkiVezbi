using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        mvNaracka.ActiveViewIndex = 0;
    }



    protected void goTo2_Click(object sender, EventArgs e)
    {
        mvNaracka.ActiveViewIndex = 1;
    }

    protected void goTo2prev_Click(object sender, EventArgs e)
    {
        mvNaracka.ActiveViewIndex = 1;
    }

    protected void goTo1_Click(object sender, EventArgs e)
    {
        mvNaracka.ActiveViewIndex = 0;
    }

    protected void goTo3_Click(object sender, EventArgs e)
    {
        mvNaracka.ActiveViewIndex = 2;
    }

    protected void goTo4_Click(object sender, EventArgs e)
    {
        lblUser.Text = txtEmail.Text;
        mvNaracka.ActiveViewIndex = 3;
    }

    protected void goTo3prev_Click(object sender, EventArgs e)
    {
        mvNaracka.ActiveViewIndex = 0;
    }

    protected void calDatum_SelectionChanged(object sender, EventArgs e)
    {
        mvNaracka.ActiveViewIndex = 1;
    }

    protected void calDatum_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
    {
        mvNaracka.ActiveViewIndex = 1;
    }
}