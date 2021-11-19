using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOPsPrograms
{
    public class StockMain
    {
        public void DisplayData(string filepath)
        {
            try
            {
                using (StreamReader r = new StreamReader(filepath))
                {
                    var json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<StockPortfolio>>(json);
                    Console.WriteLine("StockName\tNo.ofShares\tPricePerShare\tTotal");
                    foreach (var item in items)
                    {
                        Console.WriteLine("{0}" + "\t\t" + "{1}" + "\t\t" + "{2}" + "\t\t" + "{3}", item.StockName, item.NumberOfShares, item.PricePerShare, item.NumberOfShares * item.PricePerShare);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
