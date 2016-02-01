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
            // Call UserInterface class to build menu and recieve user input.
            UserInterface newUser = new UserInterface();
            String input = Console.ReadLine();

            int choice = newUser.RecieveInput();

            // Call WineItemCollection class to create array.
            WineItemCollection wineItemCollection = new WineItemCollection();

            // While loop build to process user input.
            while (choice != 5)
            {
                if (choice == 1) // Option 1 loads the array.
                {
                    wineItemCollection.Collection();
                    Console.WriteLine();
                    Console.WriteLine("Done.");
                }
                else if (choice == 2) // Option 2 prints the array.
                {
                    wineItemCollection.Print();
                }
                else if (choice == 3) // Option 3 allows user to search for a specific
                {                    // Item in the array.
                    Console.WriteLine("Enter the item you wish to search for:");
                    wineItemCollection.SearchList();
                }
                else if (choice == 4) // Option 4 allows the user to add an item to the
                {                    // the array.
                    Console.WriteLine("Enter the item you wish to add:");
                    wineItemCollection.AddItem();
                }
                else if (choice == 5) // Option 5 stops the array, and allows the
                {                    // program to close.
                    Console.WriteLine("Have a nice day.");
                }
                input = Console.ReadLine();
                choice = newUser.RecieveInput();
            }

        }
    }
}
