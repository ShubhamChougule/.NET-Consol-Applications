using System;

class oddEven {
    public static void Main(string [] args) {
        Console.WriteLine("Enter an Number : ");
        int n = Convert.ToInt32(Console.ReadLine());
        string res = "";

        if(n % 2 == 0) res = "EVEN";
        else res = "ODD";

        Console.WriteLine("Number {0} is {1}", n , res);
        Console.ReadKey();
    }
}