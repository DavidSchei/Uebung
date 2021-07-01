using System;
using System.Collections.Generic;

namespace Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
			Stack<int> evenNums = new Stack<int>();

			evenNums.Push(4);
			evenNums.Push(8);
			evenNums.Push(6);

			int num = Convert.ToInt32(Console.ReadLine());

			evenNums.Push(num);

			Console.WriteLine("Checking the last number: " + num);

			// your code goes here
			//checken ob zahl gerade
			if (num % 2 != 0)
			{
				//wenn nicht dann wird die oberste zahl gepoppt, in dem fall num
				Console.WriteLine(evenNums.Pop() + ": Removed");
			}
			//foreach kette um alles schön nebeneinader auszugeben wie die aufgabe es wollte
			foreach (int i in evenNums)
            {
				Console.Write(i + " ");
            }
		}
	}
}


