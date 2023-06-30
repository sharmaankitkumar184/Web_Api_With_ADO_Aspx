﻿using System;
using System.Data.SqlClient;

namespace Web_Api_With_ADO
{
    public partial class WebFormAdoNet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonId_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("server=(localdb)\\MSSQLLocalDB;database=Student_Database;Trusted_Connection=True;");
                // Writing insert query  
                string query = $"insert into student(name,email,contact) Values ('{UsernameId.Text}','{EmailId.Text}','{ContactId.Text}')";
                SqlCommand sc = new SqlCommand(query, con);
                // Opening connection  
                con.Open();
                // Executing query  
                int status = sc.ExecuteNonQuery();
                Label1.Text = "Your record has been saved with the following details!";
                // ----------------------- Retrieving Data ------------------ //  
                SqlCommand cm = new SqlCommand("select top 1 * from student ORDER BY StdID DESC", con);
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                sdr.Read();
                Label2.Text = "User Name"; Label5.Text = sdr["name"].ToString();
                Label3.Text = "Email ID"; Label6.Text = sdr["email"].ToString();
                Label4.Text = "Contact"; Label7.Text = sdr["contact"].ToString();
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
}