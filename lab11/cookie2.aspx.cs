using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab11
{
    public partial class cookie2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnNonPersistent_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserName");
            cookie.Value = txtName.Text;
            // No expiry set → non-persistent
            Response.Cookies.Add(cookie);

            lblMessage.Text = "Non-Persistent Cookie created!";
        }

        protected void btnPersistent_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserName");
            cookie.Value = txtName.Text;
            cookie.Expires = DateTime.Now.AddDays(1); // Set expiry → persistent
            Response.Cookies.Add(cookie);

            lblMessage.Text = "Persistent Cookie created (1 day)!";
        }

    }
}