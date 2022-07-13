using System;

class Program
{

    static int doOperation(out int i, out int b)
    {
        int num = 5;
        i = num + num;
        b = num * num;

        return num;
    }

    public static void Main(string[] args)
    {
        // declaring variables without assigning values to it
        int sum;
        int multiply;

        int num = doOperation(out sum, out multiply);

        Console.WriteLine("Operation is done with number : {0}", num);
        Console.WriteLine("Sum is : {0}", sum);
        Console.WriteLine("Multiplication is : {0}", multiply);
    }
}