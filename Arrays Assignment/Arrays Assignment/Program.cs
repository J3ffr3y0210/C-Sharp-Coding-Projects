using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int[] numArray = new int[] { 0, 1, 2, 3, 4 };

        Console.WriteLine(" What is the numArray2?");
        string thenumArray2 = Console.ReadLine();
        Console.WriteLine(" The numArray2:" + thenumArray2);
        Console.ReadLine();

        string[] numArray1 = new string[] { "Jeff", "Joe", "Josh", "John", "Jake" };

        Console.WriteLine("What is the numArray1?");
        string thenumArray1 = Console.ReadLine();
        Console.WriteLine("The numArray1 is:" + thenumArray1);
        Console.ReadLine();

        List<string> intList = new List<string>();
        intList.Add("Apple");
        intList.Add("Mango");
        intList.Add("Orange");

        Console.WriteLine(intList[2]);
        Console.ReadLine();
            
    }
}
