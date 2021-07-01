using System;
using System.Linq;

namespace Array_Proerties_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int count = 0;
            while(count<5)
            {
                //Methode um Werte für ein Array zu bestimmen
                arr[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            //größter Wert plus kleinster wert, vorischt System.Linq ist gebraucht
            Console.WriteLine(arr.Max()+arr.Min());
        }
    }
}
