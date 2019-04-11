using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstAmount, secondAmount, thirdAmount, amountJ, amountS, amountThi;
            double avg, totalAmt;
            string firstAmt, secondAmt, thirdAmt;
            bool success1, success2, success3;
            double rateS = 9.30229, rateJ = 111.72, rateThi = 31.77;
            //Get users three dollar amount from user and parse to double
            do
            {
                Console.WriteLine("Please enter frist amount in USD:");
                firstAmt = Console.ReadLine();
                success1 = double.TryParse(firstAmt, out firstAmount);
                if (firstAmount < 0 || !success1)
                {
                    Console.WriteLine("This is not a valid amount in USD...........");
                }
            } while (firstAmount < 0 || !success1);

            do
            {
                Console.WriteLine("Please enter second amount in USD:");
                secondAmt = Console.ReadLine();
                success2 = double.TryParse(secondAmt, out secondAmount);
                if (secondAmount < 0 || !success2)
                {
                    Console.WriteLine("This is not a valid amount in USD...........");
                }
            } while (secondAmount < 0 || !success2);

            do

            {
                Console.WriteLine("Please enter third amoount in USD:");
                thirdAmt = Console.ReadLine();
                success3 = double.TryParse(thirdAmt, out thirdAmount);
                if (thirdAmount < 0 || !success3)
                {
                    Console.WriteLine("This is not a valid amount in USD............");
                }
            } while (thirdAmount < 0 || !success3);


            totalAmt = firstAmount + secondAmount + thirdAmount;

            //Calculate the average
            avg = (firstAmount + secondAmount + thirdAmount) / 3;
            Console.WriteLine("The average of three numbers = " + avg);
            if (firstAmount <= secondAmount && firstAmount <= thirdAmount)
            {
                Console.WriteLine("Smallest amount is = " + firstAmount);
            }
            else if (secondAmount <= firstAmount && secondAmount <= thirdAmount)
            {
                Console.WriteLine("Smallest amount is = " + secondAmount);
            }
            else if (thirdAmount <= firstAmount && thirdAmount <= secondAmount)
            {
                Console.WriteLine("Smallest amount is = " + thirdAmount);
            }
            else
            {

            }

            if (firstAmount >= secondAmount && firstAmount >= thirdAmount)
            {
                Console.WriteLine("Largest amount is = " + firstAmount);
            }
            else if (secondAmount >= firstAmount && secondAmount >= thirdAmount)
            {
                Console.WriteLine("Largest amount is = " + secondAmount);
            }
            else if (thirdAmount >= firstAmount && thirdAmount >= secondAmount)
            {
                Console.WriteLine("Largest amount is = " + thirdAmount);
            }
            else
            {

            }
            //Conversion to othercurrency and console out
            amountJ = totalAmt * rateJ;
            amountS = totalAmt * rateS;
            amountThi = totalAmt * rateThi;
            //NumberFormatInfo american = new CultureInfo("en-US", false).NumberFormat;
            //Console.WriteLine("US:" + totalAmt.ToString("C", american));
            Console.WriteLine("US: " + totalAmt.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Swedish: " + amountS.ToString("C", CultureInfo.CreateSpecificCulture("da-DK")));
            Console.WriteLine("Japanese: " + amountJ.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Thai: " + amountThi.ToString("C", CultureInfo.CreateSpecificCulture("th-THB")));
            Console.ReadLine();
        }

    }
}


