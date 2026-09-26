using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab11
{
    public partial class session1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnretrive_Click(object sender, EventArgs e)
        {
            if (Session["Username"] != null  || Session["Age"] !=null)
            {
                lablinfo.Text = Session["username"].ToString();
                lblinfo2.Text = Session["Age"].ToString();
            }
            else
            {
                lablinfo.Text = "Sessoin not Availabel";
            }
            
        }

        protected void btnstore_Click(object sender, EventArgs e)
        {
            Session["username"] = txtname.Text;
            Session["Age"] = txtage.Text;
            Session.Timeout = 1;
        }

        protected void btnabandon_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            lablinfo.Text = "";
            lblinfo2.Text = "";
            lablinfo.Text = "Session abandoned!";

        }

    }
}