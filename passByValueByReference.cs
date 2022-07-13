using System;

class Program {

    public static void simple(ref int age) {
        age = 10;
        Console.WriteLine("Inside Function Value of age = {0}", age);
    }
    public static void Main(){

        int age = 18;
        Console.WriteLine("Before calling function Value of age = {0}", age);
        simple(ref age);
        Console.WriteLine("After calling function Value of age = {0}", age);
    }
}