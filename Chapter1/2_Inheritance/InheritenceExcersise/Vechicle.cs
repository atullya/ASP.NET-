class Vehicle{
    private int reg;
    private string name;
    private string brand;

    public void setVehicle(int reg,string name, string brand){
        this.reg=reg;
        this.name=name;
        this.brand=brand;
    }
    public void displayVehicle(){
        Console.WriteLine("The reg no is "+reg+" and it's name is "+ name+ " and the brand is "+brand);
    }
}
class Car:Vehicle{
    private int mileage;
    public void setMilage(int mileage){
        this.mileage=mileage;
    }
    public void displayMiage(){
        Console.WriteLine("The mileage of car is "+mileage);
    }
}
