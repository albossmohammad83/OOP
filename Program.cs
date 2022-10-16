using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           RetailSalesPerson retailSalesPerson = new RetailSalesPerson("Steve", "Roger");
           retailSalesPerson.Sell();
           
           CarSalesman carSalesman = new CarSalesman("Mike", "Roger");
           carSalesman.Sell();
        }
    }
}