using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        public static string[] collection = new string[4000];

        int arrayIndex = 3964;

        public void Collection() // Option 1
        {
            WineItem[] wineItems = new WineItem[3964];

            CSVProcessor wineList = new CSVProcessor();

            wineList.AccessCSVFile("../data/WineList.csv", wineItems);

            int index = 0;

            foreach (WineItem item in wineItems)
            {
                if (item != null)
                {
                    collection[index] = item.ToString();
                }
                index++;
            }
        }

        public void Print() // Option 2
        {
            if (collection[0] != null)
            {
                for (int i = 0; i < 3964; i++)
                {
                    Console.WriteLine(collection[i]);
                }
            }
            else if (collection[0] == null)
            {
                Console.WriteLine("No items listed.");
            }
        }

        // I know this isn't what you were looking for, but I ran into some
        // problems and couldn't code a proper search in time
        public void SearchList() // Option 3
        {
            if (collection[0] != null)
            {
                string userSearch = Console.ReadLine();

                string searchString = "Item not found.";
                for (int i = 0; i < arrayIndex; i++)
                {
                    if (userSearch == collection[i])
                    {
                        searchString = "Item found!";
                    }
                }
                Console.WriteLine(searchString);
            }
            else
            {
                Console.WriteLine("No items listed.");
            }
        }

        public void AddItem() // Option 4
        {
            arrayIndex += 1;

            string newItem = Console.ReadLine();
            collection[arrayIndex] = newItem;
        }
    
    }
}
