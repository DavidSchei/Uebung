using System;

namespace Passing_By_Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            int salaryBudget = Convert.ToInt32(Console.ReadLine());
            int percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before the increase: " + salaryBudget);

            //complete the method call
            //mit ref haben wir eine reference, die werte werden übernommen
            Increase(ref salaryBudget, ref percent);

            Console.WriteLine("After the increase: " + salaryBudget);
        }
        //complete the method
        static void Increase(ref int s, ref int p)
        {
            //prozent wird auf die vorhande salary raufgerechnet deswegen +=
            s += s * p/100;
           
        }
    }
    }
Aufgabenstellung : 
Rechne auf den Lohn, die zusätzlichen Prozente von dem vorhandenen Lohn
