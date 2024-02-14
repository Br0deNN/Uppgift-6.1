using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in tre tal");
        Console.WriteLine("Skriv in tal 1");
        int tal1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv in tal 2");
        int tal2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv in tal 3");
        int tal3 = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Summan av tallen blir {Addera(tal1, tal2, tal3)}");

    }

    static int Addera(int tal1, int tal2 , int tal3)
    {
        return tal1 + tal2 + tal3;
       
    }
}