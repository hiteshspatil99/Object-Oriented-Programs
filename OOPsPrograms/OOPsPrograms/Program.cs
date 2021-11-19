using System;

namespace OOPsPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {

                Console.WriteLine("Select the Option : \n 1.JSON Inventory \n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryMain im = new InventoryMain();
                        im.DisplayData(@"D:\JSON\Object-Oriented-Programs\OOPsPrograms\OOPsPrograms\Files\Inventory.json");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}