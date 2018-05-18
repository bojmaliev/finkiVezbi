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
            
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        ListItem nov = new ListItem(TextBox1.Text, TextBox3.Text);
        RadioButtonList1.Items.Add(nov);
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label3.Text = RadioButtonList1.SelectedItem.Text+" вреди "+RadioButtonList1.SelectedValue+" денари";
    }
}