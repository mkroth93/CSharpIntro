using System;
using static System.Console;

namespace Tester
{
    /// <summary>
    /// Program:       Phone Store Inventory Class
    /// Name:          Michael Kroth
    /// Date:          2/27/19
    /// Purpose:       This class will create an instance for 
    ///                different phone inventories
    /// </summary>
    class Phone
    {
        private decimal cost;
        private string name;
        private decimal price;
        private string prodCode;
        private int qty;

        public Phone(string prodCode, string name, int qty, decimal cost, decimal price)
        {
            this.prodCode = prodCode;
            this.name = name;
            this.qty = qty;
            this.cost = cost;
            this.price = price;
        }

        public override string ToString()
        {
            string message = "";

            message += ($"ProdCode    : {prodCode}\n");
            message += ($"Name        : {name}\n");
            message += ($"Qty         : {qty}\n");
            message += ($"Cost        : {cost:c}\n");
            message += ($"Price       : {price:c}\n");

            return message;
        }

        public void CalcProfit()
        {

        }

        public void PrintValues()
        {
            WriteLine($"ProdCode    = {prodCode}\n");
            WriteLine($"Name        = {name}\n");
            WriteLine($"Qty         = {qty}\n");
            WriteLine($"Cost        = {cost:c}\n");
            WriteLine($"Price       = {price:c}\n");
        }
    }
}
