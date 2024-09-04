using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise1
{
    internal class Program
    {
        public static double ConvertToUSD(double amount, string fromCurrency)
        {
            double exchangeRate = 0;

            if (fromCurrency == "EUR")
            {
                exchangeRate = 1.1083;
            }
            else if (fromCurrency == "JPY")
            {
                exchangeRate = 0.0070;
            }
            else
            {
                Console.WriteLine("Please enter a valid currency.");
                return 0;
            }

            return exchangeRate * amount;
        }

        public static double ConvertToEUR(double amount, string fromCurrency)
        {
            double exchangeRate = 0;

            if (fromCurrency == "USD")
            {
                exchangeRate = 0.9022;
            }
            else if (fromCurrency == "JPY")
            {
                exchangeRate = 0.0063;
            }
            else
            {
                Console.WriteLine("Please enter a valid currency.");
                return 0;
            }

            return exchangeRate * amount;
        }

        public static double ConvertToJPY(double amount, string fromCurrency)
        {
            double exchangeRate = 0;

            if (fromCurrency == "USD")
            {
                exchangeRate = 143.655;
            }
            else if (fromCurrency == "EUR")
            {
                exchangeRate = 159.23;
            }
            else
            {
                Console.WriteLine("Please enter a valid currency.");
                return 0;
            }

            return exchangeRate * amount;
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter the amount you would like to convert: ");
            double amountInput = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the currency you are converting from (USD, EUR, JPY): ");
            string currentCurrency = Console.ReadLine();

            if (currentCurrency == "USD")
            {
                Console.WriteLine(amountInput + " in USD would be " + ConvertToEUR(amountInput, currentCurrency) + " in EUR.");
                Console.WriteLine(amountInput + " in USD would be " + ConvertToJPY(amountInput, currentCurrency) + " in JPY.");
            }
            else if (currentCurrency == "EUR")
            {
                Console.WriteLine(amountInput + " in EUR would be " + ConvertToUSD(amountInput, currentCurrency) + " in USD.");
                Console.WriteLine(amountInput + " in EUR would be " + ConvertToJPY(amountInput, currentCurrency) + " in JPY.");
            }
            else if (currentCurrency == "JPY")
            {
                Console.WriteLine(amountInput + " in JPY would be " + ConvertToEUR(amountInput, currentCurrency) + " in EUR.");
                Console.WriteLine(amountInput + " in JPY would be " + ConvertToUSD(amountInput, currentCurrency) + " in USD.");
            }
            else
            {
                Console.WriteLine("Enter a valid currency");
            }

            Console.ReadKey();
        }
    }
}
