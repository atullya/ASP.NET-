using System;
//custom exception means generatin own error. to create own error:
//1. Create error class by iheriting super class exception
//2. Create constructor that will call super class consturctor with error message by using base keyword
//3.  user throw clause to throw own error

//when age is less that 16 throw new error
class AgeError:Exception{
    public AgeError(string msg):base(msg){

    }
}
class CustomeExceptionDemo{
public void sendAge(int age){
    if(age<16){
        throw new AgeError("Age must be less than 16");
    }else{
        Console.WriteLine("Welcome");
    }
}
}