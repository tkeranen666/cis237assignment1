using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace assignment1
{
    class CSVProcessor
    {

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

            catch (Exception)
            {
                Console.WriteLine("Error! Unable to load file.");
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
