using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
class crudOperation{
    public void createTable(){
        try{

        //1. Create connectoin string
        string cs="Data Source=mongodb://localhost:27017/+Initial Catalog=,Integrated Security=true";
                  //server name    database name      windows authentication
        SqlConnection conn=new SqlConnection(cs);
        if(conn.State==ConnectionState.Open){
            Console.WriteLine("Connected with Server");
        }
        conn.Open(); //conectoin open
        }catch(SqlException s){
            Console.WriteLine(s);
        }
    }
}