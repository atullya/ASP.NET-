using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login_user(object sender,EventArgs e)
        {
            try
            {
                // Extracting data from form
                string username = usname.Text;
                string password = passw.Text;

                // Database connection string
                string cs = "Data Source=DESKTOP-E0F8F6U\\SQLEXPRESS;Initial Catalog=db_nccsb;Integrated Security=true";

                // Query to check user credentials
                string fetchData = "SELECT COUNT(*) FROM tbl_reg WHERE username = @username AND password = @password";

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(fetchData, conn))
                    {
                      
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // ExecuteScalar returns the count of matching records
                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            // Successful login
                            l7.Text = "Login successful!";
                            l7.ForeColor = System.Drawing.Color.Green;
                            string script = "alert('Login Successful!');";
                            ClientScript.RegisterStartupScript(this.GetType(), "LoginSuccess", script, true);
                        }
                        else
                        {
                            // Invalid credentials
                            l7.Text = "Invalid username or password.";
                            l7.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Display SQL error (for debugging purposes)
                l7.Text = "Database Error: " + ex.Message;
                l7.ForeColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                // Catch other errors
                l7.Text = "Error: " + ex.Message;
                l7.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}