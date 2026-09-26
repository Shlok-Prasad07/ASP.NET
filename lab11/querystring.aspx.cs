using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab11
{
    public partial class querystring : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btnsubmit_Click(object sender, EventArgs e)
        {
            String Email = HttpUtility.UrlEncode(txtemail.Text);
            String Password = HttpUtility.UrlEncode(txtpass.Text);
            Response.Redirect("Data.aspx?Email= " + Email + "&Password=" + Password);
        }

    }
}