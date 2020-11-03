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
            string svar = Class.funktionalitet.Select(new string[] { "Kunde", "medarbejder", "leder"}).ToLower();
            switch (svar)
            {
                case "Kunde":
                    new Class.Varer();
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
            Console.ReadKey();
        }
    }
}