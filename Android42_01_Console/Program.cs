// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try //Kļūdu ķeršana
            {
                int num = 0;
                foreach (var item in args)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Kvadrātsakne {args.Length} argumentiem:");
                if (args.Length == 0)
                {
                    Console.WriteLine("Ievadiet skaitli");
                    num = Convert.ToInt32(Console.ReadLine());
                    double result = SquareRoot(num);
                    Console.WriteLine("Kvadrātsakne");
                    Console.WriteLine(result);
                    // "Stoperis" konsolei
                    //  Console.ReadKey();
                }
                else
                {
                    foreach (var item in args)
                    {
                        num = Convert.ToInt32(item);
                        Console.WriteLine(SquareRoot(num));
                    }
                }
            }
            catch (FormatException ex) //Kļūdas apstrāde
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ar šo netikšu galā, dod veselu skaitli!");
            }
        }


        static double SquareRoot(int num)
        {
            double result;
            result = Math.Sqrt(num);
            return result;
        }
    }
}

