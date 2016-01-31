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

            Console.WriteLine("Hello new user.");
            Console.WriteLine("Please type your name:");

            string userInputString = Console.ReadLine();

            Console.WriteLine("Hello " + userInputString + ".");



            WineItem[] wineItems = new WineItem[3964];

            CSVProcessor wineList = new CSVProcessor();

            wineList.AccessCSVFile("../datafiles/WineList.CSV", wineItems);


        
        }
    }
}
