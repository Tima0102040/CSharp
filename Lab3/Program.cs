using System;
using System.Security.Cryptography;
using Lab3;

class Program
    {
        static void Main(string[] args)
        {
            University knu = new University("KNU", "Universitetskya 13", 20, 140, 0);
            University kpi = new University("KPI", "Universitetskya 13", 20, 140, 0);
            University naukma = new University("NaUKMA", "Universitetskya 13", 20, 140, 0);

            knu.Scopus();
            knu.Top200();
            knu.BalZno();

            kpi.Scopus();
            kpi.Top200();
            kpi.BalZno();
            
            
            naukma.Scopus();
            naukma.Top200();
            naukma.BalZno();
            
            Console.WriteLine();
            Console.WriteLine("Rating of KNU university is {0}",kpi.CountRating());
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Rating of KNU university is {0}",knu.CountRating());
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Rating of KNU university is {0}",naukma.CountRating());

        }
    }