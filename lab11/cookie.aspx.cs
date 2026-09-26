using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab11
{
    public partial class cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitData_Click(object sender, EventArgs e)
        {
            Response.Cookies["User"]["Name"] = txtName.Text;
            Response.Cookies["User"]["Age"] = txtAge.Text;
            lblData.Text = "Cookie Created Successfully!!";
            Response.Cookies["User"].Expires = DateTime.Now.AddSeconds(10);
            txtName.Text = "";
            txtAge.Text = "";
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["User"] != null)
            {
                lblData.ForeColor = System.Drawing.Color.Blue;
                lblData.Text = "Name is : " + Request.Cookies["User"]["Name"].ToString() + "<br/>" +
                "Age is : " + Request.Cookies["User"]["Age"].ToString() + "<br/>" + "Cookie Retrived";
            }
            else
            {
                lblData.ForeColor = System.Drawing.Color.Red;
                lblData.Text = "Cookie Not Available!!";
            }
        }

    }
}