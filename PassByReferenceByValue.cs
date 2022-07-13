using System;

class Program {

    public static void simple(int[] ages) {
        // this will reflect in original ages array
        ages[0] = 100;
        Console.WriteLine("Inside Function Before initialization Age of First Person = {0}", ages[0]);
        // this will allocate new memory to the ages array
        ages = new int[] {50, 60};
        Console.WriteLine("Inside Function after initialization Age of First Person = {0}", ages[0]);
    }
    public static void Main(){
        int [] ages = {10, 20, 30, 40};
        Console.WriteLine("Before calling function Age of First Person = {0}", ages[0]);
        simple(ages);
        Console.WriteLine("After calling function Age of First Person = {0}", ages[0]);
    }
}