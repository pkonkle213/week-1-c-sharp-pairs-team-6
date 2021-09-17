using System;

namespace MakeChange
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.

        C:\Users> MakeChange

        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */
        static void Main(string[] args)
        {
            decimal totalBill;
            decimal amountTendered;
            decimal changeRequired;

            Console.Write("Please enter the amount of the bill: ");

            string totalBillStr = Console.ReadLine();

            totalBill = decimal.Parse(totalBillStr);

            Console.Write("Please enter the amount tendered: ");

            string amountTenderedStr = Console.ReadLine();

            amountTendered = decimal.Parse(amountTenderedStr);

            changeRequired = amountTendered - totalBill;

            Console.WriteLine("Change required is " + changeRequired);


            Console.ReadLine();



            
        }
    }
}
