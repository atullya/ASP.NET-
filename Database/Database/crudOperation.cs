using System;
using Microsoft.Data.SqlClient; // Ensure correct SQL client package
using System.Data;

class CrudOperation
{
    private string connectionString = "Server=DESKTOP-E0F8F6U\\SQLEXPRESS; Database=db_nccsb;Trusted_Connection=True;Encrypt=False;";

    // Method to create the table
    public void CreateTable()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                Console.WriteLine("Connected to server");

                // Check connection state
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection could not be established.");
                    return;
                }
                //writing insert query using prepared statement(parameter)
                //string insQuery1 = "Insert into tabl_reg values(@id, @username, @password, @repassword, @gender, @faculty)";
                //inserting value in parmeter
                string tblQuery = @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbl_reg')
                                    CREATE TABLE tbl_reg (
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
                    Console.WriteLine("Table 'tbl_reg' created or already exists.");
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"SQL Exception: {ex.Message}\n{ex.StackTrace}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General Exception: {ex.Message}\n{ex.StackTrace}");
        }
    }


    // Method to insert data into the table
    public void InsertData()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                Console.WriteLine("Connected to server");

                // Check connection state
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection could not be established.");
                    return;
                }

                // Collecting user input
                Console.WriteLine("Enter Your Id:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter Your Username:");
                string uname = Console.ReadLine();
                Console.WriteLine("Enter Your Password:");
                string pass = Console.ReadLine();
                Console.WriteLine("Enter Your RePassword:");
                string repass = Console.ReadLine();
                Console.WriteLine("Enter Your Gender:");
                string gen = Console.ReadLine();
                Console.WriteLine("Enter Your Faculty:");
                string fac = Console.ReadLine();

                // Writing insert query using prepared statements (parameterized)
                string insQuery = "INSERT INTO tbl_reg (id, username, password, repassword, gender, faculty) VALUES (@id, @username, @password, @repassword, @gender, @faculty)";

                using (SqlCommand sc = new SqlCommand(insQuery, conn))
                {
                    // Adding parameters to prevent SQL injection
                    sc.Parameters.AddWithValue("@id", id);
                    sc.Parameters.AddWithValue("@username", uname);
                    sc.Parameters.AddWithValue("@password", pass);
                    sc.Parameters.AddWithValue("@repassword", repass);
                    sc.Parameters.AddWithValue("@gender", gen);
                    sc.Parameters.AddWithValue("@faculty", fac);

                    // Executing query
                    int rowsAffected = sc.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"{rowsAffected} record(s) inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No new records were inserted. Record may already exist.");
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"SQL Exception: {ex.Message}\n{ex.StackTrace}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General Exception: {ex.Message}\n{ex.StackTrace}");
        }
    }


    //update name to mandish, faculty to bim of person whose id is 1
    public void updateData()
    {
        try
        {
            string connectionString = "Server=DESKTOP-E0F8F6U\\SQLEXPRESS; Database=db_nccsb;Trusted_Connection=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string unQuery = "update tbl_reg set username='atul',faculty='bca' where id=1";
            SqlCommand sc = new SqlCommand(unQuery, conn);
            int res = sc.ExecuteNonQuery();
            if (res > 0)
            {
                Console.WriteLine(res + "data updated Suceessfull");
            }

        }
        catch(SqlException s)
        {
            Console.WriteLine(s);
        }
    }
    //update username,faculty,of person based on id all the required data should be takne from user
    public void dynamicUpdate()
    {
        try
        {
            string connectionString = "Server=DESKTOP-E0F8F6U\\SQLEXPRESS; Database=db_nccsb; Trusted_Connection=True; Encrypt=False;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Collecting user input
                Console.WriteLine("Enter Id to update:");
                string id = Console.ReadLine();

                Console.WriteLine("Enter Your Username:");
                string uname = Console.ReadLine();

                Console.WriteLine("Enter Your Password:");
                string pass = Console.ReadLine();

                Console.WriteLine("Enter Your RePassword:");
                string repass = Console.ReadLine();

                // Ensure passwords match
                if (pass != repass)
                {
                    Console.WriteLine("Passwords do not match. Update failed.");
                    return;
                }

                Console.WriteLine("Enter Your Gender:");
                string gen = Console.ReadLine();

                Console.WriteLine("Enter Your Faculty:");
                string fac = Console.ReadLine();

                string updQuery = "UPDATE tbl_reg SET username = @username, password = @password, repassword = @repassword, gender = @gender, faculty = @faculty WHERE id = @id";
                using (SqlCommand sc = new SqlCommand(updQuery, conn))
                {
                    // Adding parameters
                    sc.Parameters.AddWithValue("@id", id);
                    sc.Parameters.AddWithValue("@username", uname);
                    sc.Parameters.AddWithValue("@password", pass);
                    sc.Parameters.AddWithValue("@repassword", repass);
                    sc.Parameters.AddWithValue("@gender", gen);
                    sc.Parameters.AddWithValue("@faculty", fac);

                    int res = sc.ExecuteNonQuery();

                    if (res > 0)
                    {
                        Console.WriteLine(res + " record(s) updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No record found with the provided Id.");
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
    //fetching data from database
    public void displayData()
    {
        try
        {
            string connectionString = "Server=DESKTOP-E0F8F6U\\SQLEXPRESS; Database=db_nccsb;Trusted_Connection=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string disQuery = "Select * from tbl_reg";
            SqlCommand sc=new SqlCommand(disQuery, conn);
            //to fetch data executeReader() method is used, it returns object of 
            //sqlDatarader that contains all the data of database table
           SqlDataReader row= sc.ExecuteReader();
            //it contains all the row of table. To fetch one row at a time read() method is used!
            while (row.Read())
            {
                Console.WriteLine("Id is " + row["id"]);
                Console.WriteLine("Username is " + row["username"]);
                Console.WriteLine("Password is " + row["password"]);
                Console.WriteLine("Re Password is " + row["repassword"]);
                Console.WriteLine("Gender is " + row["gender"]);
                Console.WriteLine("Faculty is " + row["faculty"]);
            }

        }
        catch(SqlException ex)
        {
            Console.WriteLine("Error" + ex);
        }
    }

    //Deleteing data of person whose id is given by user
    public void delData()
    {
        try
        {
            string connectionString = "Server=DESKTOP-E0F8F6U\\SQLEXPRESS; Database=db_nccsb;Trusted_Connection=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            Console.WriteLine("Enter id of person of which you want to del record:");
            string delId = Console.ReadLine();

            string delQuery = "delete from tbl_reg where id=@id";
            SqlCommand sc = new SqlCommand(delQuery, conn);
            sc.Parameters.AddWithValue("id", delId);
            int res = sc.ExecuteNonQuery();
            if (res > 0)
            {
                Console.WriteLine(res + "Data Deleted Suceessfull");
            }

        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error" + ex);
        }
    }

    // Main method to run the class
    public static void Main(string[] args)
    {
        CrudOperation crud = new CrudOperation();

        // Uncomment the next line to create the table
        // Console.WriteLine("Creating table...");
        // crud.CreateTable();

        // Uncomment the next line to insert data
        //Console.WriteLine("\nInserting data...");
        //crud.InsertData();

        //update Data
        //crud.updateData();
        //crud.dynamicUpdate();


        //fetch data from the database

        //crud.displayData();


        //delete data from database
        crud.delData();

        Console.WriteLine("\nOperations completed.");
    }
}
