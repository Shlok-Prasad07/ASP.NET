using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5
{
    public partial class extra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (ListItem list in lstSports.Items)
            {
                if (list.Selected)
                {
                    lblinfo.Text += list.Value + "<br>";
                }
            }
        }
    }
}