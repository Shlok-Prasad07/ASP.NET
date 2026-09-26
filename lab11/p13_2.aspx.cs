using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab11
{
    public partial class p13_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=LAPTOP-UMKT1UCI\\SQLEXPRESS;Initial Catalog=asp13;Integrated Security=True;";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            String quer = $"SELECT Email,Pass FROM auth WHERE Email='{txtEmail.Text}' AND Pass='{txtPass.Text}'";
            SqlCommand cmd = new SqlCommand(quer, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Session["Email"] = txtEmail.Text;
                Response.Redirect("session1.aspx");
            }
            else
            {
                Response.Write("<script>alert('Please Enter Correct Email or Passsword');</script>)");
            }
        }

    }
}