using System;
//create a class rectangle having instance variable lenght and breadth both in double type now properties
//for it  and calculate and area in main method
namespace DotNet{
   class Rectangle{
    private double length;
        private double breadth;
        public double Length{
    set{length=value;}
    get {return length;}
}
public double Breadth{
    set{breadth=value;}
    get {return breadth;}
}

   } 
}