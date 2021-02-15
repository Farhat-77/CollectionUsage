using System;
using System.Collections.Generic;

namespace CollectionUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            numbers.Add(6); 
            numbers.AddRange(new int[] { 6, 7, 8, 9 });
            numbers.Insert(0, 100); 
            numbers.RemoveAt(1); 
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            List<Weapon> people = new List<Weapon>(3);
            people.Add(new Weapon() { Name = "Dagger" });
            people.Add(new Weapon() { Name = "Chain" });
            foreach (Weapon p in people)
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}
