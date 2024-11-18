using System;
using System.Dynamic;
//exception is any abnormal condition that disturb normal flow of program
//when exception occur then program will directly stop so to handle such 
//exception, exception h andlin gis used
//keyword used in exception handling:
//1. try: used to surround a code from which exception can be generated
//2. catch: used to handle error generated from try block
//3. throw: used to thorw own exception (custome exception) from any line of code
//4. finally: always exceuted block whther exception occur or not
class MyException
{
    // Taking input from the user and dividing it by 0 to demonstrate try-catch
    public void SetData()
    {
        try
        {
            Console.WriteLine("Enter first number:");
            int x1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int y1 = Int32.Parse(Console.ReadLine());

            // Attempting division
            int res = x1 / y1; // Throws DivideByZeroException if y1 == 0
            Console.WriteLine("Division result is: " + res);
            
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed. " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("This block always executes.");
        }

        Console.WriteLine("Out of try-catch block.");
    }
}
   
   