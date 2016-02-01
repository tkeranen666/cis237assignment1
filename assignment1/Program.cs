using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Tim Keranen
 * CIS 237 Advanced C#
 * Assignment 1
*/

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call UserInterface class to build menu and recieve user input
            UserInterface newUser = new UserInterface();
            String input = Console.ReadLine();

            int choice = newUser.RecieveInput();

            WineItemCollection wineItemCollection = new WineItemCollection();

            while (choice != 5)
            {
                if (choice == 1)
                {
                    wineItemCollection.Collection();
                    Console.WriteLine();
                    Console.WriteLine("Done.");
                }
                else if (choice == 2)
                {
                    wineItemCollection.Print();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter the item you wish to search for:");
                    wineItemCollection.SearchList();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Enter the item you wish to add:");
                    wineItemCollection.AddItem();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Have a nice day.");
                }
                input = Console.ReadLine();
                choice = newUser.RecieveInput();
            }

        }
    }
}
