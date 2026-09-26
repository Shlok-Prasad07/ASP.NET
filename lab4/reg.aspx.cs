using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab4
{
    public partial class reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btsubmit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = txname.Text;
            lbsubmit.Text = name;
            //string email = txemid.Text;
            //lbsubmit.Text += email;

        }
    }
}