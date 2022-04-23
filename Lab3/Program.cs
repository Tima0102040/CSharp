using System;
using System.IO;
using System.Security.Cryptography;
using Lab3;

class Program
{
    public static void Main(string[] args)
    {
        string path = "/Users/timofejvoznesenskij/RiderProjects/CSharp/Lab3/univer.txt";
    WritingTxt(path);
    ReadingTxT( path);
}

    static void ReadingTxT(string path)
    {
        StreamReader reader = new StreamReader(path);

        while (!reader.EndOfStream)
        {
            Console.WriteLine(reader.ReadLine());
        }

        reader.Close();
    }

    
    static void WritingTxt(string path)
    {
        StreamWriter writer = new StreamWriter(path);
        University knu = new University("Taras Shevchenko National Univercsity of Kyiv", "Volodymirska 60", 4, 500, 0);
        University lpi = new University("Lviv Polytechnic National University", "Bandery 12", 5, 430, 0);
        University naukma = new University("NaUKMA", "Universitetskya 13", 1, 200, 0);
        
        knu.Scopus();
        knu.Top200();
        knu.BalZno();
        
        lpi.Scopus();
        lpi.Top200();
        lpi.BalZno();
    
        naukma.Scopus();
        naukma.Top200();
        naukma.BalZno();
        
        writer.WriteLine("Name: {0}", knu.Name);
        writer.WriteLine("Address: {0}", knu.Address);
        writer.WriteLine("Number of faculty: {0}", knu.NumbFaclt);
        writer.WriteLine("Number of student: {0}", knu.StudOnFaclt);
        writer.WriteLine("Rating: {0}", knu.CountRating());
        writer.WriteLine("Financing: $ {0}", knu.Financing("Kyiv"));
        
        writer.WriteLine();
        writer.WriteLine("Name: {0}", lpi.Name);
        writer.WriteLine("Address: {0}", lpi.Address);
        writer.WriteLine("Number of faculty: {0}", lpi.NumbFaclt);
        writer.WriteLine("Number of student: {0}", lpi.StudOnFaclt);
        writer.WriteLine("Rating: {0}", lpi.CountRating());
        writer.WriteLine("Financing: $ {0}", lpi.Financing("Lviv"));
        writer.Close();

    }
    
}

        