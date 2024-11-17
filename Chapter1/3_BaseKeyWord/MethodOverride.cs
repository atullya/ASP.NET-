using System;

//method override is a condition in which super class and sub class have same method with same signature(same name, same return type, same parameter)
//two keyword are used in method overriding
//1. Virtual keyword: used to denote overriden method of superclass
//2. override ekyword: used to denote overriden method of sub class
// when overriden method is called from sub class object then subclass version
//of overriden method is calssed so to call super class version of overriden
//method base keyword should be use

//method overriding is used to acheive dynamic polymorphism

class Solve{
public virtual void calc1(){ //parent ma virtual keyword for method overriding
    Console.WriteLine("def method of super class")
;}
public virtual void  calc2(int x, int y){
    Console.WriteLine("Sum is "+ (x+y));

}
}
class Answer:Solve{
    public override void calc1(){ //for child class use override
    base.calc1(); //calls superclass calc1()
    Console.WriteLine("def method of sub class");}
public override void calc2(int x, int y){
    base.calc2(x,y); //calls superclass calc2();
    Console.WriteLine("Difference is "+ (x-y));

}
}