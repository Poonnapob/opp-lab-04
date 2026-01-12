using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_VendingMachine
{
    public class VendingMachine
    {
        int coffee = 0;
        int water = 0;
        int milk = 0;
        int chokkolat = 0;
        //constructor
        public VendingMachine(int coffee, int water,int milk,int  chokkolat)
        {
            this.coffee = coffee;
            this.water = water;
            this.milk = milk;
            this.chokkolat = chokkolat;

        }

        public void Buyblackcoffee()
        {
            int co = 20;
            int wa = 300;
            if (CheckStock(co, wa, 0, 0))
            {
                UseStock(co, wa, 0, 0);
                Console.WriteLine("Enjoy your black coffee!");
            }
            else
            {
                Console.WriteLine("Sorry, not enough stock for black coffee.");
            }
        }   
        public void Buymokca() 
        {
            int co = 20;
            int wa = 300;
            int ckl = 10;
            if (CheckStock(co, wa, 0, ckl))
            {
                UseStock(co, wa, 0, ckl );
                Console.WriteLine("Enjoy your mokca!");
            }
            else
            {
                Console.WriteLine("Sorry, not enough stock for mokca.");
            }
        }
        public void Buylatte() 
        {
            int co = 20;
            int wa = 300;
            int mk = 10;
            if (CheckStock(co, wa, mk, 0))
            {
                UseStock(co, wa, mk , 0);
                Console.WriteLine("Enjoy your latte!");
            }
            else
            {
                Console.WriteLine("Sorry, not enough stock for latte.");
            }
        }
        public void Buychokkolat(int amount)
        {
            int ckl = 20;
            int wa = 300;
            if (CheckStock(0, wa, 0, ckl))
            {
                UseStock(0, wa, 0, ckl);
                Console.WriteLine("Enjoy your chokkolat!");
            }
            else
            {
                Console.WriteLine("Sorry, not enough stock for chokkolat.");
            }
        }
        public void ShowStock()
        {
            Console.WriteLine("Current stock:");
            Console.WriteLine("coffee: " + this.coffee);
            Console.WriteLine("Water: " + this.water);
            Console.WriteLine("Milk: " + this.milk);
            Console.WriteLine("Chokkolat: " + this.chokkolat);
        }
        public void IncreaseStock(int co, int wa, int mk, int ckl, int no)
        {
            // Fix: Read input from Console, parse to int
            Console.Write("Enter stock item number to increase (7: coffee, 8: water, 9: milk, 10: chokkolat): ");
            string input = Console.ReadLine();
            int itemNo;
            if (int.TryParse(input, out itemNo))
            {
                if (itemNo == 7)
                {
                    this.coffee += 1000;
                }
                else if (itemNo == 8)
                {
                    this.water += 10000;
                }
                else if (itemNo == 9)
                {
                    this.milk += 1000;
                }
                else if (itemNo == 10)
                {
                    this.chokkolat += 1000;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            ShowStock();
        }
        public void UseStock(int co, int wa, int mk, int ckl)
        {
            this.coffee -= co;
            this.water -= wa;
            this.milk -= mk;
            this.chokkolat -= ckl;
            ShowStock();
        }
        private bool CheckStock(int co, int wa, int mk, int ckl)
        {
            return (this.coffee >= co && this.water >= wa && this.milk >= mk && this.chokkolat >= ckl);
        }
        
            
    }
}