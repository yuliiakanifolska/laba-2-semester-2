using System;
using Newtonsoft.Json;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the length of array:");
            int n = int.Parse(Console.ReadLine());

            DynamicArray Arr = new DynamicArray(n);
            Console.WriteLine("\nArray is filled by random numbers");
            Arr.Random();
            Arr.SaveJSON();
            Console.WriteLine("\nArray elements are shuffled in random order");
            Arr.Shuffle();
            Arr.AddJSON();

            Console.WriteLine("\nDifferent numbers");
            Console.WriteLine(Arr.FindUnique());
            
            

            Console.ReadKey();
        }



    }

}