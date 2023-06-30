using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Api_With_ADO
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Contact");
        }

        protected void ButtonId_Click_With_Query(object sender, EventArgs e)
        {
            Session["PValue"] = "";
            if (RadioButton1.Checked)
            {
                Session["PValue"] = RadioButton1.Text;
            }
            else Session["PValue"] = RadioButton2.Text;
            var sessionValue = Session["PValue"];
            string query = "";
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
                if (sessionValue.ToString()=="Like")
                {
                    query = $"select * from student where name Like '%{SearchValue.Text}%' or email Like '%{SearchValue.Text}%'or contact Like '%{SearchValue.Text}%';";
                }
                else
                {
                    query = $"select * from student where name ='{SearchValue.Text}' or email ='{SearchValue.Text}'or contact ='{SearchValue.Text}';";
                }
                SqlCommand cm = new SqlCommand(query, con);
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
        }

        protected void ButtonId_Click_With_Procedure(object sender, EventArgs e)
        {
            Session["PValue"] = "";
            if (RadioButton1.Checked)
            {
                Session["PValue"] = RadioButton1.Text;
            }
            else Session["PValue"] = RadioButton2.Text;
            var sessionValue = Session["PValue"];
            string query = "";
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
                if (sessionValue.ToString() == "Like")
                {
                    //query = "SearchStudentByL";
                    query = "Student_GetStudents2";
                }
                else
                {
                    query = "SearchStudentByE";
                }
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@searchVal", SearchValue.Text);
                // Executing the SQL query  
                cmd.CommandType = CommandType.StoredProcedure;
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

        //protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //Save the selected value as a session variable
        //    var data= RadioButtonList1.SelectedValue.ToString();
        //    Session["PValue"] = RadioButtonList1.SelectedValue.ToString();
        //}

    }
}