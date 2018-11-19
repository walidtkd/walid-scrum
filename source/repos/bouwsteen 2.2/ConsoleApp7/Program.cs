using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer uw lichaamsgewicht in...(KG)");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer uw lengte in... (M)");
            double lengte = Convert.ToDouble(Console.ReadLine());

            double BMI = kg / (lengte * lengte);

            if (BMI < 16)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Je BMI is: " + Math.Round(BMI, 2));
                Console.WriteLine("Je hebt ondergewicht!");
                Console.ReadKey();
            }
            else if (BMI < 26)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Je BMI is: " + Math.Round(BMI, 2));
                Console.WriteLine("Je bent gezond!");
                Console.ReadKey();
            }
            else if (BMI < 31)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Je BMI is: " + Math.Round(BMI, 2));
                Console.WriteLine("Je hebt lichte overgewicht! U heeft een verhoogde kans op hart en vaart ziekten en rug klachten!");
                Console.ReadKey();
            }
            else if (BMI > 31)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Je BMI is: " + Math.Round(BMI, 2));
                Console.WriteLine("Je hebt overgewicht! Zo spoedig mogelijk afslanken!");
                Console.ReadKey();
            }
        }
    }
}