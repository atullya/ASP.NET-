namespace _4_ExceptionHandling;

class Program
{
    static void Main(string[] args)
    { 
        MyException m1=new MyException();
        m1.SetData();

        Console.WriteLine("---Custome Exception Error----");
        CustomeExceptionDemo c1=new CustomeExceptionDemo();
        
        c1.sendAge(11);
       
    }
}
