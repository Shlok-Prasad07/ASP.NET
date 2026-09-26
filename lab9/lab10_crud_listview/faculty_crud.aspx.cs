using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace lab10_crud_listview
{
    public partial class faculty_crud : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;

        void GetFacultyDetail()
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("faculty_CRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Event", "Select");
            con.Open();
            lstfaculty.DataSource = cmd.ExecuteReader();
            lstfaculty.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetFacultyDetail();
            }

        }

        protected void lstfaculty_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case ("facDelete"):
                    int Faculty_ID = Convert.ToInt32(e.CommandArgument);
                    deleteFaculty(Faculty_ID);
                    break;
                case ("facEdit"):
                    Faculty_ID = Convert.ToInt32(e.CommandArgument);
                    UpdateFacultyDetail(Faculty_ID);
                    break;
            }

        }

        void deleteFaculty(int Faculty_ID)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("faculty_CRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Event", "Delete");
            cmd.Parameters.AddWithValue("@Faculty_ID", Faculty_ID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetFacultyDetail();
        }

        void UpdateFacultyDetail(int Faculty_ID)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("faculty_CRUD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Event", "SelectbyID");
            cmd.Parameters.AddWithValue("@Faculty_ID", Faculty_ID);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                hfRecord.Value = Faculty_ID.ToString();
                txtFirstname.Text = dr["Faculty_Firstname"].ToString();
                txtLastname.Text = dr["Faculty_Lastname"].ToString();
                txtContactNo.Text = dr["Faculty_ContactNo"].ToString();
                txtEmailID.Text = dr["Faculty_EmailID"].ToString();
            }
            dr.Dispose();
            con.Close();
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            GetFacultyDetail();
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(connection))
            //{
            //    using (SqlCommand cmd = new SqlCommand("faculty_CRUD", con))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        con.Open();
            //        cmd.Parameters.AddWithValue("@Event", "Add");
            //        cmd.Parameters.AddWithValue("@Faculty_Firstname", SqlDbType.VarChar).Value = txtFirstname.Text.Trim();
            //        cmd.Parameters.AddWithValue("@Faculty_Lastname", SqlDbType.VarChar).Value = txtLastname.Text.Trim();
            //        cmd.Parameters.AddWithValue("@Faculty_ContactNo", SqlDbType.BigInt).Value = txtContactNo.Text.Trim();
            //        cmd.Parameters.AddWithValue("@Faculty_EmailID", SqlDbType.NVarChar).Value = txtEmailID.Text.Trim();
            //        con.Close();
            //        cleardata();
            //    }
            //}
            //GetFacultyDetail();

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("faculty_CRUD", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Event", "Add");
                    cmd.Parameters.AddWithValue("@Faculty_FirstName", txtFirstname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Faculty_LastName", txtLastname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Faculty_ContactNo", Convert.ToInt64(txtContactNo.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Faculty_EmailID", txtEmailID.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            cleardata();
            GetFacultyDetail();
        }

        void cleardata()
        {
            txtFirstname.Text = String.Empty;
            txtLastname.Text = String.Empty;
            txtContactNo.Text = String.Empty;
            txtEmailID.Text = String.Empty;
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(connection);
            //SqlCommand cmd = new SqlCommand("faculty_CRUD", con);
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@Faculty_ID", Convert.ToInt32(hfRecord.Value));
            //cmd.Parameters.AddWithValue("@Event", "Update");
            //cmd.Parameters.AddWithValue("@Faculty_Firstname", SqlDbType.VarChar).Value = txtFirstname.Text.Trim();
            //cmd.Parameters.AddWithValue("@Faculty_Lastname", SqlDbType.NChar).Value = txtLastname.Text.Trim();
            //cmd.Parameters.AddWithValue("@Faculty_ContactNo", SqlDbType.BigInt).Value = txtContactNo.Text.Trim();
            //cmd.Parameters.AddWithValue("@Faculty_EmailID", SqlDbType.NVarChar).Value = txtEmailID.Text.Trim();

            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();

            //GetFacultyDetail();

            //btnAdd.Visible = true;
            //btnUpdate.Visible = false;

            //hfRecord.Value = string.Empty;
            //cleardata();

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("faculty_CRUD", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Faculty_ID", Convert.ToInt32(hfRecord.Value));
                    cmd.Parameters.AddWithValue("@Event", "Update");
                    cmd.Parameters.AddWithValue("@Faculty_FirstName", txtFirstname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Faculty_LastName", txtLastname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Faculty_ContactNo", Convert.ToInt64(txtContactNo.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Faculty_EmailID", txtEmailID.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();  
                    con.Close();
                }
            }

            GetFacultyDetail();

            btnAdd.Visible = true;
            btnUpdate.Visible = false;

            hfRecord.Value = string.Empty;
            cleardata();

        }
    }
}