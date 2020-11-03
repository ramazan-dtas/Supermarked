using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarked.Class
{
    public class Varer
    {
        public int number { get;  set; }
        public string name { get; set; }
        public double price { get; set; }
        /*
        public Varer(int Number, string Name, int Price)
        {
            number = Number;
            name = Name;
            price = Price;
        }*/

        public void vare(int Number, string Name, double Price)
        {
            number = Number;
            name = Name;
            price = Price;

            Name = funktionalitet.Select(new string[] { "Coca Cola", "Fanta", "Sødmælk", "Letmælk", "Løg", "Agurk", "Chips", "Slik", "Gå til kassen"}).ToLower();

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
                    break;
            }
        }
    }
}