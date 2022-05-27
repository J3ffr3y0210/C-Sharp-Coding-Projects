using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int[] numArray = new int[] { 0, 1, 2, 3, 4 };

        Console.WriteLine(numArray[2]);
        Console.ReadLine();

        string[] numArray1 = new string[] { "Jeff", "Joe", "Josh", "John", "Jake" };

        numArray1[4] = "Paul";

        Console.WriteLine(numArray1[4]);
        Console.ReadLine();

        List<string> intList = new List<string>();
        intList.Add("Apple");
        intList.Add("Mango");
        intList.Add("Orange");

        Console.WriteLine(intList[2]);
        Console.ReadLine();
            
    }
}
