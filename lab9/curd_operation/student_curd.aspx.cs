using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;


namespace curd_operation
{
    public partial class student_curd : System.Web.UI.Page
    {

        public string strconstr = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public DataSet ds;

        public void CreateConnection()
        {
            SqlConnection con = new SqlConnection(strconstr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public void OpenConnection()
        {
            cmd.Connection.Open();
        }
        public void CloseConnection()
        {
            cmd.Connection.Close();
        }

        public void DisposeConnection()
        {
            cmd.Connection.Dispose();
        }

        public void BindStudentData()
        {
            try
            {
                CreateConnection();
                OpenConnection();
                cmd.CommandText = "stu_CRUD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Event", "Select");
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                sda.Fill(ds);
                grdData.DataSource = ds;
                grdData.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Connection is not available');</script>");
            }
            finally
            {
                CloseConnection();
                DisposeConnection();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindStudentData();
            }
        }

        protected void grdData_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            grdData.PageIndex = e.NewPageIndex;
            this.BindStudentData();
        }


        public void ClearControls()
        {
            txtEnrollment_No.Text = "";
            txtStudent_Name.Text = "";
            txtSemester.Text = "";
            txtSPI.Text = "";
            txtCPI.Text = "";
        }
        protected void grdData_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            grdData.EditIndex = -1;  // Exit edit mode
            this.BindStudentData();       // Rebind data
        }

        protected void grdData_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {

            try
            {
                GridViewRow row = grdData.Rows[e.RowIndex];
                int Stu_id = Convert.ToInt32(grdData.DataKeys[e.RowIndex].Values[0]);
                CreateConnection();
                OpenConnection();
                cmd.CommandText = "stu_CRUD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Event", "Delete");
                cmd.Parameters.AddWithValue("@Stu_id", Stu_id);
                int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (result > 0)
                {
                    Response.Write("<script>alert('Record Deleted Successfully');</script>");
                    grdData.EditIndex = -1;
                    BindStudentData();
                    ClearControls();
                }
                else
                {
                    Response.Write("<script>alert('Connection not available');</script>");
                }
            }
            catch (Exception ex) { Response.Write("<script>alert('Error Caught');</script>"); }
            finally
            {
                CloseConnection();
                DisposeConnection();
            }
        }

        protected void grdData_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = grdData.Rows[e.RowIndex];
                int Stu_id = Convert.ToInt32(grdData.DataKeys[e.RowIndex].Values[0]);
                String en_no = (row.FindControl("t_txtEnrollment_No") as TextBox).Text;
                String stu_name = (row.FindControl("t_txtStudent_Name") as TextBox).Text;
                String sem = (row.FindControl("t_txtSemester") as TextBox).Text;
                String spi = (row.FindControl("t_txtSPI") as TextBox).Text;
                String cpi = (row.FindControl("t_txtCPI") as TextBox).Text;
                CreateConnection();
                OpenConnection();
                cmd.CommandText = "stu_CRUD";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Event", "Update");
                cmd.Parameters.AddWithValue("@Enrollment_No", en_no.Trim());
                cmd.Parameters.AddWithValue("@Student_Name", stu_name.Trim());
                cmd.Parameters.AddWithValue("@Semester", Convert.ToInt32(sem.Trim()));
                cmd.Parameters.AddWithValue("@SPI", Convert.ToDecimal(spi.Trim()));
                cmd.Parameters.AddWithValue("@CPI", Convert.ToDecimal(cpi.Trim()));
                cmd.Parameters.AddWithValue("@Stu_id", Stu_id);

                int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (result > 0)
                {
                    Response.Write("<script>alert('Record Updated Successfully');</script>");
                    grdData.EditIndex = -1;
                    BindStudentData();
                    ClearControls();
                }
                else
                {
                    Response.Write("<script>alert('Connection not available');</script>");
                }
            }
            catch (Exception ex) { Response.Write("<script>alert('Error Caught');</script>"); }
            finally
            {
                CloseConnection();
                DisposeConnection();
            }
        }
        protected void grdData_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            grdData.EditIndex = e.NewEditIndex;
            this.BindStudentData();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CreateConnection();
                OpenConnection();
                cmd.CommandText = "stu_CRUD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Event", "Add");
                cmd.Parameters.AddWithValue("@Enrollment_No", Convert.ToString(txtEnrollment_No.Text.Trim()));
                cmd.Parameters.AddWithValue("@Student_Name", Convert.ToString(txtStudent_Name.Text.Trim()));
                cmd.Parameters.AddWithValue("@Semester", Convert.ToString(txtSemester.Text.Trim()));
                cmd.Parameters.AddWithValue("@SPI", Convert.ToString(txtSPI.Text.Trim()));
                cmd.Parameters.AddWithValue("@CPI", Convert.ToDecimal(txtCPI.Text));
                int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (result > 0)
                {

                    Response.Write("<script>alert('Record Inserted Successfully');</script>");
                    BindStudentData();
                    ClearControls();
                }
                else { Response.Write("<script>alert('Failed');</script>"); }
            }
            catch (Exception ex) { Response.Write("<script>alert('Error Caught');</script>"); }
            finally
            {
                CloseConnection();
                DisposeConnection();
            }

        }
    }
}