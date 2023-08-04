using System;

namespace Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int cdaysfortrain= int.Parse(Console.ReadLine());

            double kmrunfirstday= double.Parse(Console.ReadLine());

            double kminday = kmrunfirstday;
            double allsumkm = kmrunfirstday;

            //Calculations
            for (int daytrain = 1; daytrain <= cdaysfortrain; daytrain++)
            {
                int percent= int.Parse(Console.ReadLine());// % za vseki den

                kminday = kminday + (percent * 0.01)* kminday;// za vseki den

                allsumkm = allsumkm + kminday;


            }

            
            if (allsumkm >=1000)
            {
                double additionalkm = allsumkm - 1000;
                Console.WriteLine($"You've done a great job running {Math.Ceiling(additionalkm)} more kilometers!");
            }
            else if(allsumkm < 1000)
            {
                double neededkm = 1000 - allsumkm;
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(neededkm)} more kilometers");
            }



        }
    }
}
