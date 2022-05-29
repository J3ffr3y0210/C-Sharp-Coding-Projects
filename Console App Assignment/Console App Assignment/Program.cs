using System;
using System.Collections.Generic;

class Program
 {
    static void Main(string[] args)
     {
        int[] testScores = { 98, 96, 94, 92, 88, 86, 84, 82, 80 };

        for (int i = 1; i < testScores.Length; i++)
        {
            if(testScores[i] > 85)
            {
                Console.WriteLine(" What is the passing score?");
                string thePassingScore = Console.ReadLine();
                Console.WriteLine("Passing test score:" + testScores[i]);
            }
        }
        Console.ReadLine();

        string[] names = { "Jeff", "Joe", "Jack", "Jill" };

        for(int j = 0; j < names.Length; j++)
        {
            Console.WriteLine(names[j]);
        }
        Console.ReadLine();

        List<int> testListScores = new List<int>() { 97, 95, 80, 86, 84 };
        List<int> passingScore = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScore.Add(score);
                Console.ReadLine();
            }
        }


     }
 }

