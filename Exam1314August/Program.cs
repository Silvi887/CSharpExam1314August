using System;

namespace Exam1314August
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int countpeopleingroup = int.Parse(Console.ReadLine());

            int countnights= int.Parse(Console.ReadLine());
            int countcardstransport= int.Parse(Console.ReadLine());
            int countticketsmuseums= int.Parse(Console.ReadLine());

            //Calculatons
            double pricenightoneperson = countnights * 20.0;
            double pricecardtransportoneperson = countcardstransport * 1.60;
            double ticketsmuseumoneperson = countticketsmuseums * 6.0;

            double allsumoneperson = pricenightoneperson + pricecardtransportoneperson + ticketsmuseumoneperson;

            double sumallgroup = allsumoneperson * countpeopleingroup;
            double addpricecosts = sumallgroup * 1.25;

            Console.WriteLine($"{addpricecosts:F2}");

        }
    }
}
