using System;

class Program {

    public static void simple(int age) {
        age = 10;
        Console.WriteLine("Inside Function age = {0}", age);
    }
    public static void Main(){

        int age = 18;
        Console.WriteLine("Before calling function age = {0}", age);
        simple(age);
        Console.WriteLine("After calling function age = {0}", age);
    }
}