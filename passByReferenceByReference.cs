using System;

class Program {

    public static void swapString(ref string str1, ref string str2) {
        string temp = str1;
        str1 = str2;
        str2 = temp;
    }
    public static void Main(){
        string s1 = "Elon Musk";
        string s2 = "Ratan Tata";

        Console.WriteLine("Before calling function str1 = {0} || str2 = {0}", s1, s2);
        swapString(ref s1, ref s2);
        Console.WriteLine("After calling function str1 = {0} || str2 = {0}", s1, s2);
    }
}