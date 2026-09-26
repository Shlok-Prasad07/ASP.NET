using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab11
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btnretrive_Click(object sender, EventArgs e)
        {
            txtname.Text = ViewState["Sname"].ToString();
            txten.Text = ViewState["Sen"].ToString();
        }

        protected void Btnsubmit_Click(object sender, EventArgs e)
        {
            ViewState["Sname"] = txtname.Text;
            ViewState["Sen"] = txten.Text;

            txtname.Text = "";
            txten.Text = "";
        }

    }
}