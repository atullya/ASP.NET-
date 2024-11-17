using System;
//such class whose object cannot be created and declared using
//abstract keyword. It is used to hide complex detail of class
//it's object cannot be created
// it can have instane variable, method and constructor
//it can have abstract method: such method which is ddclared only 
//but not initialized (no body part)
//normal cassl should inherit abstract class and such normal class
//have to provide body part of all the abstract method

abstract class Question{
//it can have instance variable
private int x1;
private int y1;
//it can have constructor
public Question(int x1, int y1){
this.x1=x1;
this.y1=y1;
}
//normal method
public void displaySum(){
    Console.WriteLine("Sum is " + (x1+y1));
    //it can have abstract method
}
    public abstract void displayDiff(int x1, int y1);
    public abstract void displayMulti(int x1, int y1);
}

//abstract class should be used by the normal class
class Ans1:Question{
    private int x1;
    private int y1;
    public Ans1(int x1, int y1):base(x1,y1){
        this.x1=x1;
        this.y1=y1;
    }
    //normal method
    public void displayDiv(){
        Console.WriteLine("Div is"+(x1/y1));    }
        //providing the body  of abstract method
         public override void displayDiff(int x1, int y1){
            Console.WriteLine("Diff is "+(x1-y1));
         }
    public override  void displayMulti(int x1, int y1){

            Console.WriteLine("Multi is "+(x1*y1));
    }
}
