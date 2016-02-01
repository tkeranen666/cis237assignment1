using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// I had a lot of trouble making this class, so a lot of the code is pretty crude.

namespace assignment1
{
    class WineItemCollection
    {
        // Create array to load CSV file into -- Set to 4000 to allow added items
        public static string[] collection = new string[4000];

        // This is set to the index of the last item in the file -- It's here to show
       // where to put new user added items into the array
        int arrayIndex = 3962;

        public void Collection() // Option 1
        {
            // Call WineItems class
            WineItem[] wineItems = new WineItem[3964];

            // Call CSVProcessor class
            CSVProcessor wineList = new CSVProcessor();

            // Load CSV file into an array with the fields from WineItem class
            wineList.AccessCSVFile("../data/WineList.csv", wineItems);

            int index = 0;

            // Foreach loop fills collection array
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
                // For loop prints collection array
                for (int i = 0; i < 3964; i++)
                {
                    Console.WriteLine(collection[i]);
                }
            }

            // If CSV file hasen't been loaded program tells user that the array is
           // empty
            else if (collection[0] == null)
            {
                Console.WriteLine("No items listed.");
            }
        }

        // I know this isn't what you were looking for, but I ran into some problems 
       // and I couldn't manage to re-separate the file into multiple arrays.
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
                Console.WriteLine(searchString); // Tells user whether or not the
                                                // searched item was found
            }
            else
            {
                Console.WriteLine("No items listed.");
            }
        }

        // Similar problem here. I know it's kind of bare-bones.
        public void AddItem() // Option 4
        {
            // Adds to the arrayIndex each time the method is called
            arrayIndex += 1;

            string newItem = Console.ReadLine();
            collection[arrayIndex] = newItem;
        }
    
    }
}
