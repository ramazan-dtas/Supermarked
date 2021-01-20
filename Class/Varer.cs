using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarked.Class
{
    public class Varer
    {//De her tre tager værdierne fra varer og sætter dem ud på output
        public int number { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public void varer(int Number, string Name, double Price)
        {
            name = Name;
            number = Number;
            price = Price;
            List<Varer> products = new List<Varer>
            {
                new Varer {Name = "Coca Cola", Number = 132456, Price = 15.00},
                new Varer {Name = "Fanta", Number = 123489, Price = 15.00},
                new Varer {Name = "Sødmælk", Number = 145213, Price = 7.95},
                new Varer {Name = "Letmælk", Number = 132457, Price = 7.50},
                new Varer {Name = "Løg", Number = 983212, Price = 5.00},
                new Varer {Name = "Agurk", Number = 321893, Price = 6.00},
                new Varer {Name = "Chips", Number = 843290, Price = 23.00},
                new Varer {Name = "Slik", Number = 198432, Price = 25.00}
            };
            /*
            bool sa = false;
            while (!sa)
            {
                Console.Clear();
                switch (Name)
                {
                    case "Coca Cola":
                        Number = 132456;
                        Price = 15.00;
                        break;

                    case "Fanta":
                        Number = 123489;
                        Price = 15.00;
                        break;

                    case "Sødmælk":
                        Number = 421429;
                        Price = 7.95;
                        break;

                    case "Letmælk":
                        Number = 789201;
                        Price = 7.50;
                        break;

                    case "Løg":
                        Number = 647892;
                        Price = 5.00;
                        break;

                    case "Agurk":
                        Number = 782345;
                        Price = 9.00;
                        break;

                    case "Chips":
                        Number = 723456;
                        Price = 18.32;
                        break;

                    case "Slik":
                        Number = 045678;
                        Price = 33.21;
                        break;

                    case "Gå til kassen":
                        sa = true;
                        Console.Clear();
                        Betaling p1 = new Betaling();
                        break;

                }
            }*/

        }
    }
}