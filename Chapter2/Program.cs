using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient; //to connect with sql server and for sql languagae
//to connect with external datasource like sql server, xml file, SqlClient
//Steps to Connect with Database
/*
1. Create Connection string that have all the parameter required to connect with database
2. Create object of SqlConnection class that accept connection string as paremeter. this class is used to connect with server and the datbase
3. Write appropriate query
4. Create object of SqlCommand class that accept query and connection object as parameter this      class    is used to execute sql query 
5. Exceucte query by using method of SqlCommand class
6. Close the connection

*/
class Program
{
    static void Main()
    {

        // string connectionString = "Server=localhost;Database=master;User Id=SA;Password=DotNet!456";
        // using (SqlConnection conn = new SqlConnection(connectionString))
        {
           crudOperation c1=new crudOperation();
           c1.createTable();
            Console.WriteLine("Connected to SQL Server successfully!");
        }
    }
}
