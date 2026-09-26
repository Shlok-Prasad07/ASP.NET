using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab11
{
    public partial class Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Email = Request.QueryString["Email"];
                string Password = Request.QueryString["Password"];

                labelemail.Text = Email;
                labelpassword.Text = Password;
            }
        }
    }
}