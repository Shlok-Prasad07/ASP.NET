using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab11
{
    public partial class sessiondev : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            Session["Name"] = txtName.Text;
            Session["Email"] = txtEmail.Text;
            lblMessage.Text = " Data stored in session!";
        }


        protected void btnRetrieve_Click(object sender, EventArgs e)
        {
            if (Session["Name"] != null && Session["Email"] != null)
            {
                lblMessage.Text = " Name: " + Session["Name"].ToString() + "<br/> Email: " + Session["Email"].ToString();
            }
            else
            {
                lblMessage.Text = " Session data not found!";
            }
        }

        protected void btnAbandon_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            lblMessage.Text = "Session abandoned!";
        }

    }
}