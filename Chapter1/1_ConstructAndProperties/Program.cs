using System;

namespace DotNet
{
 
   

    // Program class to execute the code
    class Program
    {
        static void Main(string[] args)
        {
           Box b1=new Box();
           //setting and getting value of lenght,breadht and height for b1
           b1.Length=50;// call set of length
           int len1=b1.Length;

           b1.Breadth=50;
           int bre1=b1.Breadth;

           b1.Height=50;
           int hei1=b1.Height;
           int vol=len1*bre1*hei1;
           

            Console.WriteLine("Volume is  "+ vol);


            Rectangle R1=new Rectangle();
            R1.Length=2.3;
            double l1=R1.Length;

              R1.Breadth=5.1;
           double be1=R1.Breadth;

           Console.WriteLine("The perimeter of rectangle is "+ 2*(l1 + be1));
            Console.ReadKey(); //hold screen
        }
    }
}

