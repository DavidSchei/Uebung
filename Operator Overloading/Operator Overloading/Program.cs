using System;

namespace Operator_Overloading
{
    class Program
    {
     
        static void Main(string[] args)
            {
                Score tm1 = new Score(2, 3);
                Score tm2 = new Score(4, 2);

                Score finalScores = tm1 + tm2;


                Console.WriteLine("Round 1: " + finalScores.round1Score);
                Console.WriteLine("Round 2: " + finalScores.round2Score);
            }
        }
        class Score
        {
            public int round1Score { get; set; }
            public int round2Score { get; set; }
            public Score(int r1, int r2)
            {
                round1Score = r1;
                round2Score = r2;
            }

            //your code goes here
            //OVERLOADING um eine Variable, mit 2 werten zu füllen, 2 Teammitglieder,
            //jeder macht seine eigenen punkte (a und b), das soll man nun für runde 1 und
            //runde 2 machen, deswegen r1 und r2. Von beiden wird der Score genommen und in
            //die Variable gegeben
            //round1Score ist mit der MainMethode verbunden, weil dort erst die werte eingegeben werden
  
            public static Score operator+(Score a, Score b)
            {
                int r1 = a.round1Score + b.round1Score;
                int r2 = a.round2Score + b.round2Score;
                Score res = new Score(r1, r2);
            return res;
            }
        }
    }

