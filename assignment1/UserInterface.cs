using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        public int RecieveInput()
        {
            // Call method for interface menu.
            this.UserMenu();
            String userChoice = Console.ReadLine();

            // This loop checks to make sure user enters a valid choice and displays
           // an error messege if not.
            while (userChoice != "1" && userChoice != "2" && userChoice != "3" &&
                   userChoice != "4" && userChoice != "5")
            {

                Console.WriteLine("Your selection was not understood.");
                Console.WriteLine("Please select one of the options listed:");
                Console.WriteLine();
                Console.WriteLine();

                this.UserMenu();
                userChoice = Console.ReadLine();
            }
            return Int32.Parse(userChoice);
        }

        // Private Method for displaying interface menu.
        private void UserMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1- Load product list");
            Console.WriteLine("2- Print list");
            Console.WriteLine("3- Search list");
            Console.WriteLine("4- Add item to list");
            Console.WriteLine("5- End program");
        }
    }
}
