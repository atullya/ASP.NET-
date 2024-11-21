using System;
//Create a class Number with 3 private instance variable x,y,z create a property
//or constructor to initiaize a value. Also create a getMax() method that 
//returns the maximum number among three and getPrime() method to return the //prime number from x to y

class Number {
    private int x;
    private int y;
    private int z;

    public Number(int x, int y, int z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public int X {
        get { return x; }
        set { x = value; }
    }

    public int Y {
        get { return y; }
        set { y = value; }
    }

    public int Z {
        get { return z; }
        set { z = value; }
    }

    public int getMax() {
        if (x >= y && x >= z) {
            return x; 
        } else if (y >= x && y >= z) {
            return y; 
        } else {
            return z; 
        }
    }

    public void getPrimes() {
        while (x <= y) {
            if (isPrime(x)) {
                Console.WriteLine(x + " is a prime number.");
            }
            x++;
        }
    }

    private bool isPrime(int num) {
        if (num <= 1) return false;
        for (int i = 2; i <= num / 2; i++) {
            if (num % i == 0) {
                return false;
            }
        }
        return true;
    }
}

class Program {
    static void Main() {
        // Number num = new Number(10, 30, 15);
        
        // Console.WriteLine("The maximum number is: " + num.getMax());
        
        // Console.WriteLine("Prime numbers between " + num.X + " and " + num.Y + ":");
        // num.getPrimes();
       BoxWeight b1=new BoxWeight(2,3,4,5);
        Console.WriteLine("The Weight of the box is"  + b1.getWeight());
          Console.WriteLine("Volume of the box: " + b1.getVol());
        Console.WriteLine("Weight of the box: " + b1.getWeight());
     
    }
}
