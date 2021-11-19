using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOPsPrograms
{
    public class InventoryManagementMain
    {
        List<InventoryModel> riceList;
        List<InventoryModel> wheatList;
        List<InventoryModel> pulsesList;
        public void ReadData(string filepath)
        {
            try
            {
                using (StreamReader r = new StreamReader(filepath))
                {
                    var json = r.ReadToEnd();
                    InventoryFactory item = JsonConvert.DeserializeObject<InventoryFactory>(json);
                    riceList = item.Rice;
                    wheatList = item.Wheat;
                    pulsesList = item.Pulses;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DisplayData(string state)
        {
            if (state == "Rice")
            {
                Console.WriteLine("Name\tWeight\tPrice");
                foreach (var item in riceList)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", item.Name, item.Weight, item.Price);
                }
            }
            if (state == "Wheat")
            {
                Console.WriteLine("Name\tWeight\tPrice");
                foreach (var item in wheatList)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", item.Name, item.Weight, item.Price);
                }
            }
            if (state == "Pulses")
            {
                Console.WriteLine("Name\tWeight\tPrice");
                foreach (var item in pulsesList)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", item.Name, item.Weight, item.Price);
                }
            }
        }
    }
}
