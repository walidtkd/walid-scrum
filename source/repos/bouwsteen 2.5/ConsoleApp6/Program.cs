﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodealer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Goede middag, welkom bij auto service walid!\nVoer uw naam in!...");
            string naam = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Danku," + naam);
            Console.WriteLine("Voer het standaard bedrag in!");
            int stdbedrag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Danku!\nWilt i Metalic lak? ja/nee");
            string ant1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Oke!\nWilt u Leren bekleding? ja/nee");
            string ant2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Oke!\nWil u een automaat? ja/nee");
            string ant3 = Convert.ToString(Console.ReadLine());

            int p1 = stdbedrag / 100 * 5;

            if (ant1.Contains("ja") == true)
            {
                stdbedrag = stdbedrag + p1;
            }
            else
            {
                stdbedrag = stdbedrag + 0;
            }

            if (ant2.Contains("ja") == true)
            {
                stdbedrag = stdbedrag + p1;
            }
            else
            {
                stdbedrag = stdbedrag + 0;
            }

            if (ant3.Contains("ja") == true)
            {
                stdbedrag = stdbedrag + 1000;
            }
            else
            {
                stdbedrag = stdbedrag + 0;
            }

            Console.WriteLine("Uw kosten zijn: " + stdbedrag + " euro excl. BTW\nDruk op enter om uw btw te berekenen!");
            Console.ReadKey();
            Console.WriteLine("BTW: 21%");
            int p2 = stdbedrag / 100 * 21;
            Console.WriteLine("Druk op enter!");
            Console.ReadKey();
            stdbedrag = stdbedrag + p2;
            Console.WriteLine("Uw totale kosten zijn:" + stdbedrag + " euro incl. BTW!");
        }
    }
}