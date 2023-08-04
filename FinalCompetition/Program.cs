using System;

namespace FinalCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int countdansers= int.Parse(Console.ReadLine());
            double countpoints= double.Parse(Console.ReadLine()); 

            string season=Console.ReadLine();
            string placeofcompetition= Console.ReadLine();


            double pricemoney = 0;
            //Calculations
            if (placeofcompetition== "Bulgaria")
            {
                pricemoney = countpoints * countdansers;
            }
            else if (placeofcompetition == "Abroad")
            {
                pricemoney = countdansers * countpoints;
                pricemoney = pricemoney * 1.50;
            }




            //razhodi
            switch (placeofcompetition)
            {
                case "Bulgaria":

                    if (season== "summer")
                    {
                        pricemoney = pricemoney * 0.95;
                    }
                    else if (season == "winter")
                    {
                        pricemoney = pricemoney * 0.92;
                    }
                    break;


                case "Abroad":

                    if (season == "summer")
                    {
                        pricemoney = pricemoney * 0.90;
                    }
                    else if (season == "winter")
                    {
                        pricemoney = pricemoney * 0.85;
                    }

                    break;
            }


            double moneyofcharity = 0.75 * pricemoney;

            double leftmoneyaftercharity = pricemoney - moneyofcharity;

            double moneyfordanser = leftmoneyaftercharity / countdansers;

            //Print
            Console.WriteLine($"Charity - {moneyofcharity:F2}");
            Console.WriteLine($"Money per dancer - {moneyfordanser:F2}");

        }
    }
}
