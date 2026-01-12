using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object
            VendingMachine vendingMachineA = new VendingMachine(0, 10000, 0, 0);
            //menu interface
            while (true)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Wellcome to Coffee Machine");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("What do you buy?");
                Console.WriteLine("----------------------");
                Console.WriteLine("1:Black Coffee");
                Console.WriteLine("----------------------");
                Console.WriteLine("2:Mokca");
                Console.WriteLine("----------------------");
                Console.WriteLine("3:Latte");
                Console.WriteLine("----------------------");
                Console.WriteLine("4:Chokkocat");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("5:Show stock");
                Console.WriteLine("6:Increase stock");
                Console.WriteLine("----------------------");
                Console.WriteLine("0:Exit program");
                Console.WriteLine("----------------------");
                Console.WriteLine("--------------------------------");

                string input = Console.ReadLine();
                switch (input)
                {
                    
                    case "1":
                        vendingMachineA.Buyblackcoffee();
                        break;
                    case "2":
                        vendingMachineA.Buymokca();
                        break;
                    case "3":
                        vendingMachineA.Buylatte();
                        break;
                    case "4":
                        vendingMachineA.Buychokkolat(1);
                        break;
                    case "5":
                        vendingMachineA.ShowStock();
                        break;
                    case "6":
                            vendingMachineA.IncreaseStock(0, 0, 0, 0, 0);
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong input try again");
                        break;

                }
            }
        }
    }
}
