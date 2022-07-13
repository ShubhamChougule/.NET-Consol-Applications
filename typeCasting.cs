using System;

class Program {

    public static void Main() {

        /*  Implicit TypeCasting    */
        int n1 = 1000;
        long n2 = n1;
        Console.WriteLine("Implicit TypeCasting");
        Console.WriteLine("n1 : {0}", n1);
        Console.WriteLine("n2 : {0}", n2);


        /*  Explicit TypeCasting    */
        double n3 = 112.23;
        int n4 = (int) n3;
        Console.WriteLine("Explicit TypeCasting");
        Console.WriteLine("n3 : {0}", n3);
        Console.WriteLine("n4 : {0}", n4);
    }
}