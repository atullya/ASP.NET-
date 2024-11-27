using DatabaseExample;
using System.Data;
using System.Data.SqlClient;



class Program
{
    static void main(string[] args)
    {
        CrudOperation c1=new CrudOperation();
        c1.createTable();

    }
}