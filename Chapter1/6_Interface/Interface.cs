//Interace is like a abstract class but it contains only list of abstract  method. Multiple inheritance is possible using interface
/*
1. it's object cannot be created
2. it only contains list of abstract method (no constructor, method, fixed instance variabe)
3.it is used to achieve dynamic polymorphism and multiple inheritance
4. normal class have to inherit interface and must privide implementation of all the method define in interface


*/
interface Calc1{
    //list of abstract method no body part
    void caclSum(int x, int y);
    void calcMulti(int x, int y);
}
interface Calc2{
    void calcDiv(int x, int y);
}
class InterfaceDemo:Calc1,Calc2{//multiple inheritance condition
public void caclSum(int x, int y){
    Console.WriteLine("Sum is "+ (x+y));

}

public void calcMulti(int x, int y){
    Console.WriteLine("Multi is "+ (x*y));

}
public void calcDiv(int x, int y){

    Console.WriteLine("Div is "+ (x/y));
}
}