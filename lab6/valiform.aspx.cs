using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab6
{
    public partial class valiform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btsubmit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = txbname.Text;
            lbsubmit.Text = name;

        }
    }
}