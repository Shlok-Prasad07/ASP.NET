using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7
{
    public partial class languagetheme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btsubmit_Click(object sender, EventArgs e)
        {
            string language = rbllan.SelectedValue;
            string city = ddlty.SelectedValue;
            lbselres.Text = "You selected: " + language + " - " + city;
        }

        protected void rbllan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lan = "";
            ddlty.Items.Clear();

            foreach (ListItem data in rbllan.Items)
            {
                if (data.Selected)
                {
                    lan = data.Text;
                }
            }

            if (lan == "Python")
            {
                ddlty.Items.Add("Interpreated");
                ddlty.Items.Add("High-level");
                ddlty.Items.Add("object-oriented");
            }

            else if (lan == "C")
            {
                ddlty.Items.Add("Procedural");
                ddlty.Items.Add("Compiled");
            }
        }
    }
}