using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Api_With_ADO
{
    public partial class EditData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string ID = Request.QueryString["SID"].ToString();
                DisplayData(ID);
            }
            
        }

        private void DisplayData(string ID)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = ConfigurationManager.AppSettings["DevConnectionString"].ToString();
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening connection  
                con.Open();
                // Executing query 
                // ----------------------- Retrieving Data ------------------ //  
                //SqlCommand cm = new SqlCommand($"select * from student where ((name Like {(!string.IsNullOrEmpty(UsernameId.Text) ? $"'%{UsernameId.Text}%'" : "''")}) OR (email Like {(!string.IsNullOrEmpty(EmailId.Text) ? $"'%{EmailId.Text}%'" : "''")}) OR (contact Like {(!string.IsNullOrEmpty(ContactId.Text) ? $"'%{ContactId.Text}%'" : "''")}));", con);
                SqlCommand cmd = new SqlCommand("spGetByIdStudents", con);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(ID));
                // Executing the SQL query  
                cmd.CommandType = CommandType.StoredProcedure;
                // Executing the SQL query  
                DataTable dt=new DataTable();
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                sdr.Fill(dt);
                UsernameId.Text = dt.Rows[0]["name"].ToString();
                EmailId.Text = dt.Rows[0]["email"].ToString();
                ContactId.Text = dt.Rows[0]["contact"].ToString();
              
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong." + ex);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = ConfigurationManager.AppSettings["DevConnectionString"].ToString();
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening connection  
                con.Open();
                // Executing query 
                // ----------------------- Retrieving Data ------------------ //  
                //SqlCommand cm = new SqlCommand($"select * from student where ((name Like {(!string.IsNullOrEmpty(UsernameId.Text) ? $"'%{UsernameId.Text}%'" : "''")}) OR (email Like {(!string.IsNullOrEmpty(EmailId.Text) ? $"'%{EmailId.Text}%'" : "''")}) OR (contact Like {(!string.IsNullOrEmpty(ContactId.Text) ? $"'%{ContactId.Text}%'" : "''")}));", con);
                SqlCommand cmd = new SqlCommand("spEditStudents", con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Request.QueryString["SID"].ToString()));
                cmd.Parameters.AddWithValue("@name", UsernameId.Text);
                cmd.Parameters.AddWithValue("@email", EmailId.Text);
                cmd.Parameters.AddWithValue("@contact", ContactId.Text);
                // Executing the SQL query  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                Response.Redirect("contact.aspx");
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong." + ex);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        protected void btnCancle_Click(object sender, EventArgs e)
        {

        }
    }
}