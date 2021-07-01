using System;

namespace Generic_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int intNum = Convert.ToInt32(Console.ReadLine());
            double doubNum = Convert.ToDouble(Console.ReadLine());


            Printer.Print(text);
            Printer.Print(intNum);
            Printer.Print(doubNum);
        }
    }
    class Printer
    {
        //your code goes here
        //wenn du mehrere Typen in einer Methode haben willst musst du generics benutzen
        //<T> most commonly used
        //um eben alle Sachen auszugeben text, intNum,doubNum, musst du nicht alles einzeln
        //nennen, sondern als "data" aufrufen
        public static void Print<T>(T data) 
        {
            Console.WriteLine("Showing " +data);
        }
    }
}
    

