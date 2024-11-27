using System;
using Microsoft.Data.SqlClient; // Ensure correct SQL client package
using System.Data;

namespace DatabaseExample
{
    class CrudOperation
    {
        public void createTable()
        {
            try
            {
                // 1. Connection string
                string cs = "Server=DESKTOP-E0F8F6U\\SQLEXPRESS; Database=db_nccsb;Trusted_Connection=True;Encrypt=False;";

                // 2. Creating connection
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    Console.WriteLine("Connected to server");

                    // 3. Checking connection state after opening
                    if (conn.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Connection is open and working.");
                    }
                    else
                    {
                        Console.WriteLine("Connection could not be established.");
                        return; // Exit early if connection fails
                    }

                    // 4. Create table query
                    string tblQuery = @"CREATE TABLE tbl_reg (
                                        id INT PRIMARY KEY,
                                        username VARCHAR(50),
                                        password VARCHAR(50),
                                        repassword VARCHAR(50),
                                        gender VARCHAR(50),
                                        faculty VARCHAR(50)
                                    );";

                    using (SqlCommand sc = new SqlCommand(tblQuery, conn))
                    {
                        sc.ExecuteNonQuery();
                        Console.WriteLine("Table 'tbl_reg' created successfully.");
                    }

                    // 5. Insert sample data
                    string insertQuery = @"INSERT INTO tbl_reg (id, username, password, repassword, gender, faculty)
                                           VALUES 
                                           (1, 'JohnDoe', 'password123', 'password123', 'Male', 'Computer Science'),
                                           (2, 'JaneSmith', '1234pass', '1234pass', 'Female', 'Mathematics');";

                    using (SqlCommand sc = new SqlCommand(insertQuery, conn))
                    {
                        int rowsAffected = sc.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} rows inserted into 'tbl_reg'.");
                    }

                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                // Catch and display specific SQL exception
                Console.WriteLine("SQL Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Catch general exceptions
                Console.WriteLine("General Exception: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            CrudOperation db = new CrudOperation();
            db.createTable();
        }
    }
}
