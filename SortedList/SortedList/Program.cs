using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
			SortedList<string, int> exam = new SortedList<string, int>();

			exam.Add("Tom", 59);
			exam.Add("Robert", 95);
			exam.Add("Sophie", 72);
			exam.Add("Maria", 68);
			exam.Add("Nick", 84);

			//your code goes here
			foreach (string dude in exam.Keys)
            {
                if (exam[dude] > 70)
                {
                    Console.WriteLine($"{dude}: Passed");
                }
                else
                {
                    Console.WriteLine($"{dude}: Failed");
                }    
            }
          
        }
	}
    }

