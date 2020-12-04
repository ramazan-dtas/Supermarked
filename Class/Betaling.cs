using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarked.Class
{
    public class Betaling: Varer
    {
        public string betalingsmiddel { get; set; }
        public int totalpris { get; set; }

        public void betal(string Betalingsmiddel, int Totalpris)
        {

            Betalingsmiddel = funktionalitet.Select(new string[] { "Kontant", "Dankort" });
            Console.Clear();
            switch (Betalingsmiddel)
            {
                case "Kontant":
                    break;
                case "Dankort":
                    break;
                default:
                    break;
            }

            if(Betalingsmiddel == "Kontant")
            {
                bool pay = true;
                while (pay)
                {
                    Betalingsmiddel = funktionalitet.Select(new string[] { "50", "100", "200", "500", "1000" });
                    Console.Clear();
                    switch (Betalingsmiddel)
                    {
                        case "50":
                            Console.WriteLine(50 - price);
                            break;
                        case "100":
                            Console.WriteLine(100 - price);
                            break;
                        case "200":
                            Console.WriteLine(200 - price);
                            break;
                        case "500":
                            Console.WriteLine(500 - price);
                            break;
                        case "1000":
                            Console.WriteLine(1000 - price);
                            if(price <= 0)
                            {

                            }
                            else{
                            }
                            break;
                        default:
                            break;
                    }
                }
                
            }

            if(Betalingsmiddel == "Dankort")
            {
                
            }
            betalingsmiddel = Betalingsmiddel;
            totalpris = Totalpris;
        }
    }
}