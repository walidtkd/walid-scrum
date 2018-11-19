using System;

namespace ConsoleApp5
{
    class Program
    {

        
       
        static void Main(string[] args)
        {
            DateTime dob;
            DateTime today = DateTime.Now;

            Console.WriteLine("vul je voornaam in");
           string naam = Convert.ToString (Console.ReadLine());
            Console.WriteLine("vul nu je geboortedatum in d/m/j");
            dob = Convert.ToDateTime(Console.ReadLine()).Date;

            TimeSpan difference = today.Subtract(dob);

            Console.WriteLine( naam+" is "+ difference.Days /365 +" " + "jaar oud");
            Console.ReadLine();
        }
    }
}
