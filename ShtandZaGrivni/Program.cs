using System;

namespace ShtandZaGrivni
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double moneyofTerezaforday= double.Parse(Console.ReadLine());
            double moneyfromsalingforday=double.Parse(Console.ReadLine());

            double costsforallperiod= double.Parse(Console.ReadLine());
            double priceofpresant= double.Parse(Console.ReadLine());

            //Calculations

            double allpocketmoneyofTereza = 5 * moneyofTerezaforday;
            double allwinmoney = 5 * moneyfromsalingforday;

            double allsavedmoney = allpocketmoneyofTereza + allwinmoney;

            double allmoneyofTerezawithoutcosts = allsavedmoney - costsforallperiod;

            //Print
            if (allmoneyofTerezawithoutcosts >= priceofpresant)
            {
                Console.WriteLine($"Profit: {allmoneyofTerezawithoutcosts:F2} BGN, the gift has been purchased.");
            }
            else if (allmoneyofTerezawithoutcosts < priceofpresant)
            {
                double neededmoney = priceofpresant - allmoneyofTerezawithoutcosts;
                Console.WriteLine($"Insufficient money: {neededmoney:F2} BGN.");
            }
        }
    }
}
