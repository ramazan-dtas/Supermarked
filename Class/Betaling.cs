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
                            break;
                        case "100":
                            break;
                        case "200":
                            break;
                        case "500":
                            break;
                        case "1000":
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