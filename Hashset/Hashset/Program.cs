﻿using System;
using System.Collections.Generic;

namespace Hashset
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> candidates = new HashSet<string>();

            candidates.Add("John");
            candidates.Add("Amelie");
            candidates.Add("Tom");
            candidates.Add("Richard");
            candidates.Add("Barbara");
            candidates.Add("Susan");
            candidates.Add("Charles");
            candidates.Add("Daniel");
            candidates.Add("Tamara");
            candidates.Add("Donald");

            HashSet<string> hiring = new HashSet<string>();

            while (hiring.Count < 3)
            {
                string hire = Console.ReadLine();
                //add the names to hiring hash set
                hiring.Add(hire);


            }
            //your code goes here
            if (hiring.IsSubsetOf(candidates))
            {
                Console.WriteLine("Staring hiring process");

            }
            else
            {
                Console.WriteLine("Something is wrong");
            }
        }
    }
}
