namespace Untitled_Folder;

class Program
{
    static void Main(string[] args)
    {
    //  Solution s1=new Solution();
    //  Solution s2=new Solution(15,5,20,30);
    //  s2.calcSum();//parent method
    //  s2.calcDiff();

    //  Console.WriteLine("Method Overriding");
    //  Answer a1=new Answer();
    //  a1.calc1();
    //  a1.calc2(20,30);



     Console.WriteLine("Abstract Class Example");
     Ans1 a1=new Ans1(40,50);
     a1.displaySum(); //normal method of abstract class
     a1.displayDiv(); //own method
     a1.displayDiff(50,40); //abstract method 1
     a1.displayMulti(10,5); //abstract method 2
    }
    
}
