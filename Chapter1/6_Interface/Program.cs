namespace Interface;

class Program
{
    static void Main(string[] args)
    {
       InterfaceDemo ids=new InterfaceDemo();
       ids.caclSum(20,30);
       ids.calcMulti(2,2);
       ids.calcDiv(25,5);
       //dynamic method dispatch: when subclass's object is assigned to reference variable of super class then such reference will call the subclass version of overrriden method


//interface ko object banunu paudaina
// i.e Calc1 c=new Calc1()  // yo garna paudaina
Calc1 c; //ref variable-> esto garna pauxa, yo bhaneko interface ko vaiable esley C->[ids] memory location lai point gareko hamro ids ma (calcSum, CalMulti,CalcDiv) xa tara 'c' ma chai calcSumK) ra calcMulti() matra  hunxa calcDiv() garna paudaina because it is in calc2
c=ids;
c.caclSum(33,33);
c.calcMulti(33,33);

    }
}
