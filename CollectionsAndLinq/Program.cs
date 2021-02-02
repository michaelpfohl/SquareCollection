using System;
using System.Collections.Generic;

namespace CollectionsAndLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            var numbers = new List<int>();
            for (var i = 0; i < 20; i++)
            {
                numbers.Add(r.Next(1, 50));
            }
            static void Square(int number)
            {
                number = number * number;
            }
            numbers.ForEach(Square);
            List<int> filteredNumbers = numbers.FindAll(number => number % 2 == 0);
            filteredNumbers.ForEach(number => Console.WriteLine(number));
        }
    }
}
