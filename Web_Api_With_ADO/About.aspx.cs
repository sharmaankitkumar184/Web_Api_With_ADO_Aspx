using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Api_With_ADO
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonId_Click(object sender, EventArgs e)
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
                Label1.Text = "Your Have searched the Record.......";
                // ----------------------- Retrieving Data ------------------ //  
                SqlCommand cm = new SqlCommand($"select * from student where name Like '%{UsernameId.Text}%';", con);
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Student std=new Student();
                    std.Id =Convert.ToInt32(sdr["StdID"].ToString());
                    std.Name= sdr["name"].ToString();
                    std.Email= sdr["email"].ToString();
                    std.Contact = sdr["contact"].ToString();
                    students.Add(std);
                }
                gdStudents.DataSource= students;
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

        protected void Button2_Click(object sender, EventArgs e)
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
                Label1.Text = "Your Have searched the Record.......";
                // ----------------------- Retrieving Data ------------------ //  
                SqlCommand cm = new SqlCommand($"select * from student where email Like '%{EmailId.Text}%';", con);
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

        protected void Button3_Click(object sender, EventArgs e)
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
                Label1.Text = "Your Have searched the Record.......";
                // ----------------------- Retrieving Data ------------------ //  
                SqlCommand cm = new SqlCommand($"select * from student where contact Like '%{ContactId.Text}%';", con);
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
    }
    public class Student{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        }
}