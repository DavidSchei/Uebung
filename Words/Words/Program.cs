using System;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            //your code goes here

            // FOREACH IST GEMACHT UM SAMMLUNGEN ZU DURCHLAUFEN, MACHT ES EINFACHER

            // ZWEI FOREACH SCHLEIFEN WEIL : DIE ERSTE IST DA UM ALLE WÖRTER AUSZUGEBEN
            // DIE DIESEN GEWISSEN BUCHSTABEN IN SICH TRAGEN, IST DAS DER FALL WIRD COUNT
            // UM 1 ERHÖHT
            // DIE 2.SCHLEIFE ARBEITET ALS ERGÄNZUNG FÜR DIE ERSTE, WENN KEIN WORT MIT DEM 
            // BUCHSTABEN GEFUNDEN WURDE, ERHÖHT SICH DER COUNT NICHT UND SOMIT HABEN WIR
            // : "NO MATCH", SOLLTE EIN BUCHSTABE GEFUNDEN WORDEN SEIN, WÄRE COUNT!=0, UND
            // SOMIT KEIN "NO MATCH"
          
            foreach(var word in words)
            {
                if (word.Contains(letter))
                {
                    Console.WriteLine(word);
                    count++;
                }
                
            }
            foreach(var word in words)
            {
                if(count == 0)
                {
                    Console.WriteLine("No match");
                    break;
                }
            }

            
        }
    }
}
