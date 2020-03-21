using System;

namespace Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many days is the campaign?");

            int days = int.Parse(Console.ReadLine());

            if (days < 365)
            {


                Console.WriteLine("How many bakers are participating?");
                int bakers = int.Parse(Console.ReadLine());

                if (bakers < 1000)
                {
                    Console.WriteLine("How many cakes can 1 baker make in 1 day?");
                    int cakes = int.Parse(Console.ReadLine());


                    if (cakes < 2000)
                    {
                        Console.WriteLine("How many waffles can 1 baker make in 1 day?");
                        int waffles = int.Parse(Console.ReadLine());

                        if (waffles < 2000)
                        {

                            Console.WriteLine("How many pancakes can 1 baker make in 1 day?");
                            int pancakes = int.Parse(Console.ReadLine());

                            if (pancakes < 2000)
                            {

                                double cakeprice = cakes * 45;
                                double wafflesprice = waffles * 5.80;
                                double pancakeprice = pancakes * 3.20;

                                double daily = (cakeprice + wafflesprice + pancakeprice) * bakers;
                                double campaign = (cakeprice + wafflesprice + pancakeprice) * bakers * days;

                                double profit = campaign - campaign / 8;

                                // Console.WriteLine("The daily income is " + daily);
                                //Console.WriteLine("THe entire campaign made " +campaign);
                                //Console.WriteLine("The profit is " + profit);
                                Console.WriteLine("The daily income is:");

                                Console.WriteLine(string.Format("{0:0.00}", Math.Round(daily, 2)));


                                Console.WriteLine("THe entire campaign made:");

                                Console.WriteLine(string.Format("{0:0.00}", Math.Round(campaign, 2)));


                                Console.WriteLine("The profit is:" +
                                    "");
                                Console.WriteLine(string.Format("{0:0.00}", Math.Round(profit, 2)));
                            }

                            else { Console.WriteLine("Pancakes can not exceed 2000."); }
                        }

                        else { Console.WriteLine("Waffles can not exceed 2000."); }
                    }

                    else { Console.WriteLine("Cakes can not exceed 2000."); }
                }

                else { Console.WriteLine("Bakers can not exceed 1000."); }
            }

            else { Console.WriteLine("Days can not exceed 365."); }


        }
    }
}
