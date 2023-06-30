using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Api_With_ADO
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonId_Click_By_Q(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = ConfigurationManager.AppSettings["DevConnectionString"].ToString();
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening connection  
                con.Open();
                List<Student> students = new List<Student>(); 
                // Executing query 
                // ----------------------- Retrieving Data ------------------ //  
                SqlCommand cm = new SqlCommand($"select * from student where ((name Like {(!string.IsNullOrEmpty(UsernameId.Value) ? $"'%{UsernameId.Value}%'" : "''")}) OR (email Like {(!string.IsNullOrEmpty(EmailId.Value) ? $"'%{EmailId.Value}%'" : "''")}) OR (contact Like {(!string.IsNullOrEmpty(ContactId.Value) ? $"'%{ContactId.Value}%'" : "''")}));", con);
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Student std = new Student();
                    std.Id = Convert.ToInt32(sdr["StdID"].ToString());
                    std.Name = sdr["name"].ToString();
                    std.Email = sdr["email"].ToString();
                    std.Contact = sdr["contact"].ToString();
                    students.Add(std);
                }
                gdStudents.DataSource = students;
                gdStudents.DataBind();
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
            //string message = string.Format("You said your name is {0} and your email is {1} and your contact is {2}", UsernameId.Text ,EmailId.Text,ContactId.Text);
            //ltMessage.Text = message;
        }

        protected void ButtonId_Click_By_P(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = ConfigurationManager.AppSettings["DevConnectionString"].ToString();
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening connection  
                con.Open();
                List<Student> students = new List<Student>();
                // Executing query 
                // ----------------------- Retrieving Data ------------------ //  
                //SqlCommand cm = new SqlCommand($"select * from student where ((name Like {(!string.IsNullOrEmpty(UsernameId.Text) ? $"'%{UsernameId.Text}%'" : "''")}) OR (email Like {(!string.IsNullOrEmpty(EmailId.Text) ? $"'%{EmailId.Text}%'" : "''")}) OR (contact Like {(!string.IsNullOrEmpty(ContactId.Text) ? $"'%{ContactId.Text}%'" : "''")}));", con);
                SqlCommand cmd = new SqlCommand("spSearchStudentsGoodDynamicSQL", con);
                if (UsernameId.Value.Trim() != "")
                {
                    cmd.Parameters.AddWithValue("@nameVal", UsernameId.Value);
                }
                if (EmailId.Value.Trim() != "")
                {
                    cmd.Parameters.AddWithValue("@emailVal", EmailId.Value);
                }
                if (ContactId.Value.Trim() != "")
                {
                    cmd.Parameters.AddWithValue("@contactVal", ContactId.Value);
                }
                //cmd.Parameters.AddWithValue("@nameVal", UsernameId.Text);
                //cmd.Parameters.AddWithValue("@emailVal", EmailId.Text);
                //cmd.Parameters.AddWithValue("@contactVal", ContactId.Text);
                // Executing the SQL query  
                cmd.CommandType = CommandType.StoredProcedure;
                // Executing the SQL query  
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Student std = new Student();
                    std.Id = Convert.ToInt32(sdr["StdID"].ToString());
                    std.Name = sdr["name"].ToString();
                    std.Email = sdr["email"].ToString();
                    std.Contact = sdr["contact"].ToString();
                    students.Add(std);
                }
                gdStudents.DataSource = students;
                gdStudents.DataBind();
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
    }
}