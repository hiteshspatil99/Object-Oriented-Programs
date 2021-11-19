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
                Console.WriteLine("Choose the Option : \n 1. JSON \n 2. Inventory Management \n 3. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryMain im = new InventoryMain();
                        im.DisplayData(@"D:\JSON\Object-Oriented-Programs\OOPsPrograms\OOPsPrograms\Files\Inventory.json");
                        break;
                    case 2:
                        InventoryManagementMain imm = new InventoryManagementMain();
                        imm.ReadData(@"D:\JSON\Object-Oriented-Programs\OOPsPrograms\OOPsPrograms\Files\InventoryList.json");
                        imm.DisplayData("Rice");
                        imm.DisplayData("Wheat");
                        imm.DisplayData("Pulses");
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}