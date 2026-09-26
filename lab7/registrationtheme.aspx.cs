using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7
{
    public partial class registrationtheme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btsubmit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = txname.Text;
            lbsubmit.Text = name;
        }
    }
}