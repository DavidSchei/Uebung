using System;
using System.Collections.Generic;
using System.Linq;

namespace Coffee_Time
{
    class Program
    {
        static void Main(string[] args)
        {
              int discount = Convert.ToInt32(Console.ReadLine());
            
              Dictionary<string, int> coffee = new Dictionary<string, int>();
              coffee.Add("Americano", 50);
              coffee.Add("Latte", 70);
              coffee.Add("Flat White", 60);
              coffee.Add("Espresso", 30);
              coffee.Add("Cappucino", 90);
              coffee.Add("Mocha", 100);


              
              foreach (KeyValuePair<string, int>d in coffee)
              {
                  int zahl = d.Value * discount / 100;
                  Console.WriteLine($"{d.Key}: {d.Value - zahl} ");

              }
        
           
        }
       
    }
}
