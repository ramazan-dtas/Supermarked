using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarked
{
    class Program
    {
        static void Main(string[] args)
        {
            Class.Varer p1 = new Class.Varer();
            /*
            string svar = Class.funktionalitet.Select(new string[] { "Kunde", "medarbejder", "leder"}).ToLower();
            switch (svar)
            {
                case "Kunde":
                    p1.udskriv();
                    Console.Clear();
                    break;
                case "medarbejder":
                    new Class.Status();
                    break;
                case "leder":
                    new Class.Status();
                    break;
                default:
                    break;
            }
            */
            p1.varer(p1.number,p1.name,p1.price);
            Console.WriteLine($"Vare navn {p1.name} nummer {p1.number.ToString()} pris {p1.price}");
            Console.ReadKey();
        }
    }
}