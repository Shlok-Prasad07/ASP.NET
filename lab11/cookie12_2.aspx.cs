using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab11
{
    public partial class cookie12_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserLogin"] != null)
                {
                    txtUsername.Text = Request.Cookies["UserLogin"]["Username"];
                    txtPassword.Text = Request.Cookies["UserLogin"]["Password"];
                    chkRememberMe.Checked = true;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Shlok" && txtPassword.Text == "123")
            {
                if (chkRememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("UserLogin");
                    cookie["Username"] = txtUsername.Text;
                    cookie["Password"] = txtPassword.Text;
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                else
                {
                    // Delete cookie if exists
                    if (Request.Cookies["UserLogin"] != null)
                    {
                        HttpCookie cookie = new HttpCookie("UserLogin");
                        cookie.Expires = DateTime.Now.AddHours(-1);
                        Response.Cookies.Add(cookie);
                    }
                }

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Login Successful!";
                // Redirect to home/dashboard page
                // Response.Redirect("Home.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid Username or Password!";
            }

        }
    }
}