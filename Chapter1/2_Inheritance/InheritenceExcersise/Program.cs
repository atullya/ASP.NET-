namespace InheritenceExcersise;
//create a class Vehicle having instance variable reg(int), name (string),brand(string) and methods to set and return value of instance
//variable. Create another class Car that inherits Vehicle having instnance vaiable mileage and methods to set and return the value of instance variable. 
// Now create any two object of car and display detail of Car that have greater milege
class Program
{
    static void Main(string[] args)
    {
        Car c1=new Car();
        c1.setVehicle(121,"Car","Porsce");
        c1.displayVehicle();

        //creating car class
        c1.setMilage(34);
        c1.displayMiage();

        Car c2=new Car();
        c2.setVehicle(12321,"Car","Lamborgini");
        c2.displayVehicle();

        c2.setMilage(32);
        c2.displayMiage();

      if(  c1.setMilage(34) >    c2.setMilage(32)){
        
      }

    }
}
