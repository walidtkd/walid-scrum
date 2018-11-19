using System;

namespace ConsoleApp4
{
    class Program
    {


        static void Main(string[] args)
        {
            double firstnumber;
            double secondnumber;
            double answer;
            string ops;

            Console.WriteLine("vul nummer in");
            firstnumber = Double.Parse(Console.ReadLine());

            Console.WriteLine("vul nummer in");
            secondnumber = Double.Parse(Console.ReadLine());

            {
                answer = firstnumber + secondnumber;
                Console.Write("\n" + answer);
                Console.ReadKey();
                answer = firstnumber - secondnumber;
                Console.Write("\n" + answer);
                Console.ReadKey();
                answer = secondnumber - firstnumber;
                Console.Write("\n" + answer);
                Console.ReadKey();
                answer = firstnumber * secondnumber;
                Console.Write("\n" + answer);
                Console.ReadKey();
                answer = firstnumber / secondnumber;
                Console.Write("\n" + answer);
                Console.ReadKey();
                answer = secondnumber + firstnumber;
                Console.Write("\n" + answer);
                Console.ReadKey();
                answer = firstnumber % secondnumber;
                Console.Write("\n" + answer);
                Console.ReadKey();
                answer = secondnumber % firstnumber;
                Console.Write("\n" + answer);

            }
            Console.ReadKey();
        }
    }
}
