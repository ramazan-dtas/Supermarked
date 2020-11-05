using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarked.Class
{
    public class Varer
    {//De her tre tager 
        public int number { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public void varer(int Number, string Name, double Price)
        {
            Name = funktionalitet.Select(new string[] { "Coca Cola", "Fanta", "Sødmælk", "Letmælk", "Løg", "Agurk", "Chips", "Slik", "Gå til kassen" });
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
                    new Betaling();
                    break;
            }
           
            name = Name;
            number = Number;
            price = Price;
        }
    }
}