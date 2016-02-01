using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // Required for Streamreader.

namespace assignment1
{
    class CSVProcessor
    {
        // Public method created to read CSV file.
        public bool AccessCSVFile(string wineListCSV, WineItem[] wine)
        {
            StreamReader wineItemStreamReader = null;

            try
            {
                string list;

                wineItemStreamReader = new StreamReader(wineListCSV);

                int counter = 0;

                while ((list = wineItemStreamReader.ReadLine()) != null)
                {
                    compileList(list, wine, counter++);
                }

                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine("Error! Unable to load file.");
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.StackTrace);
            }

            finally
            {
                if (wineItemStreamReader != null)
                {
                    wineItemStreamReader.Close();
                }
            }

            return false;
        }

        // Private method created to assign values to array.
        private void compileList(string wineList, WineItem[] wine, int index)
        {
            string[] collumns = wineList.Split(',');

            int idInteger = wineList[0];
            string desctriptionString = wineList[1].ToString();
            string packString = wineList[2].ToString();

            wine[index] = new WineItem(idInteger, desctriptionString, wineList);
        }
    }
}
