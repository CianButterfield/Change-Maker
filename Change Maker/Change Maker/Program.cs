using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            //call Change Maker
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);

            //keep the console open
            Console.ReadKey();
        }

        static void ChangeMaker(double amount)
        {
            //declare a variable to track the amount left
            double amountLeft = amount;
            //declare a variable for each denomination and asign values to them
            double hundred = 100;
            double fifty = 50;
            double twenty = 20;
            double ten = 10;
            double five = 5;
            double one = 1;
            double quarter = 0.25;
            double dime = 0.1;
            double nickle = 0.05;
            double penny = 0.01;

            //declare variables for the number of each denomination
            double numHundred = 0;
            double numFifty = 0;
            double numTwenty = 0;
            double numTen = 0;
            double numFive = 0;
            double numOne = 0;
            double numQuarter = 0;
            double numDime = 0;
            double numNickle = 0;
            double numPenny = 0;

            //make change
            //find the number of hundreds and hand down the remainder
            numHundred = Math.Floor(amountLeft / hundred);
            amountLeft = amountLeft % hundred;
            //find # of fifties
            numFifty = Math.Floor(amountLeft / fifty);
            amountLeft = amountLeft % fifty;
            //# twenties
            numTwenty = Math.Floor(amountLeft / twenty);
            amountLeft = amountLeft % twenty;
            //# tens
            numTen = Math.Floor(amountLeft / ten);
            amountLeft = amountLeft % ten;
            //fives
            numFive = Math.Floor(amountLeft / five);
            amountLeft = amountLeft % five;
            //ones
            numOne = Math.Floor(amountLeft / one);
            amountLeft = amountLeft % one;
            //quarters
            numQuarter = Math.Floor(amountLeft / quarter);
            amountLeft = amountLeft % quarter;
            //dimes
            numDime = Math.Floor(amountLeft / dime);
            amountLeft = amountLeft % dime;
            //nickles
            numNickle = Math.Floor(amountLeft / nickle);
            amountLeft = amountLeft % nickle;
            //pennies
            numPenny = Math.Round(amountLeft / penny);

            //outputs
            Console.WriteLine("Amount: $" + amount);
            Console.WriteLine("$100s: " + numHundred);
            Console.WriteLine("$50s: " + numFifty);
            Console.WriteLine("$20s: " + numTwenty);
            Console.WriteLine("$10s: " + numTen);
            Console.WriteLine("$5s: " + numFive);
            Console.WriteLine("$1s: " + numOne);
            Console.WriteLine("Quarters: " + numQuarter);
            Console.WriteLine("Dimes: " + numDime);
            Console.WriteLine("Nickles: " + numNickle);
            Console.WriteLine("Pennies: " + numPenny);
            Console.WriteLine("\n\n");
        }
    }
}
