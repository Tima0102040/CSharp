using System;
using System.IO;
using System.Security.Cryptography;
using Lab3;

class Program
{
    
    public static void Main(string[] args)
    {
        string path = "/Users/timofejvoznesenskij/RiderProjects/CSharp/Lab3/univer.txt";

        char command;
    char key;
    do
    {
        Console.WriteLine("Menu of command");
        Console.WriteLine("1. University");
        Console.WriteLine("2. Faculty");
        Console.WriteLine("3. Startup");
        Console.WriteLine("4. Reading");
        Console.WriteLine();
        Console.WriteLine("select of command, press number of key");
        command =(char) Console.Read();
        Console.ReadLine();
        switch (command)
        {
            case '1': KNUInfo(); break;
            case '2': TechInfo(); break;
            case '3': Startup(); break;
            case '4': ReadingTxT(path); break;
            default: Console.WriteLine("wrong command"); break;
        }
        Console.WriteLine("Continue y/n");
        key = (char)Console.Read();
        Console.ReadLine();
    } while (key!='n');
    
    }
    static void KNUInfo()
    {
        string path = "/Users/timofejvoznesenskij/RiderProjects/CSharp/Lab3/univer.txt";
        StreamWriter writer = new StreamWriter(path,true);
        University knu = new University("Taras Shevchenko National Univercsity of Kyiv", "Volodymirska 60", 4, 500, 0);
        knu.Scopus();
        knu.Top200();
        knu.BalZno();
        writer.WriteLine();
        writer.WriteLine("Name: {0}", knu.Name);
        writer.WriteLine("Address: {0}", knu.Address);
        writer.WriteLine("Number of faculty: {0}", knu.NumbFaclt);
        writer.WriteLine("Number of student: {0}", knu.StudOnFaclt);
        writer.WriteLine("Rating: {0}", knu.CountRating());
        writer.WriteLine("Financing: $ {0}", knu.Financing("Lviv", knu.Address));
        writer.Close();
        
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

    static void TechInfo()
    {
        string path = "/Users/timofejvoznesenskij/RiderProjects/CSharp/Lab3/univer.txt";
        StreamWriter writer = new StreamWriter(path,true);
        Faculty tech = new Faculty("Information Technology", 5, 10, 20000);
        writer.WriteLine();
        writer.WriteLine("Name: {0}", tech.NameFaclty);
        writer.WriteLine("Number Cafedr: {0}", tech.NumbCafed);
        writer.WriteLine("Number Specialisation: {0}", tech.NumbSpec);
        writer.WriteLine("Number of student: {0}", tech.NumbStudSpec);
        writer.WriteLine("Changing of number Cafedr and Specialisation after changing of number student: {0}",
        tech.ChangingCafed(5,10,2000, true));
        writer.Close();
        
    }

    static void Startup()
    {
        string path = "/Users/timofejvoznesenskij/RiderProjects/CSharp/Lab3/univer.txt";
        StreamWriter writer = new StreamWriter(path,true);
        Faculty.StartupIncubator startup = new Faculty.StartupIncubator();
        Console.WriteLine("The best startup score is: {0}", startup.BestStartup(10, 5));
    }
    
}

        