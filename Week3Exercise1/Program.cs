using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise1
{
    internal class Program
    {
        public static double ConvertToUSD(double amount, string fromCurrency) //method to convert the inputed amount to USD currency
        {
            double exchangeRate = 0; //declares and initializes exchangeRate variable

            if (fromCurrency == "EUR") //if condition if fromCurrency is equal to EUR
            {
                exchangeRate = 1.1083; //sets the exchange rate variable
            }
            else if (fromCurrency == "JPY") //else if condition if fromCurrency is equal to JPY
            {
                exchangeRate = 0.0070; //sets the exchange rate variable
            }
            else //else condition if fromCurrency does not equal any valid options
            {
                Console.WriteLine("Please enter a valid currency."); //displays text informing user the input was invalid
                return 0; //returns a 0 for a default output
            }

            return exchangeRate * amount; //calculates the estimated conversion of currency
        }

        public static double ConvertToEUR(double amount, string fromCurrency) //method to convert the inputed amount to EUR currency
        {
            double exchangeRate = 0; //declares and initializes exchangeRate variable

            if (fromCurrency == "USD") //if condition if fromCurrency is equal to USD
            {
                exchangeRate = 0.9022; //sets the exchange rate variable
            }
            else if (fromCurrency == "JPY") //else if condition if fromCurrency is equal to JPY
            {
                exchangeRate = 0.0063; //sets the exchange rate variable
            }
            else //else condition if fromCurrency does not equal any valid options
            {
                Console.WriteLine("Please enter a valid currency."); //displays text informing user the input was invalid
                return 0; //returns a 0 for a default output
            }

            return exchangeRate * amount; //calculates the estimated conversion of currency
        }

        public static double ConvertToJPY(double amount, string fromCurrency) //method to convert the inputed amount to JPY currency
        {
            double exchangeRate = 0; //declares and initializes exchangeRate variable

            if (fromCurrency == "USD") //if condition if fromCurrency is equal to USD
            {
                exchangeRate = 143.655; //sets the exchange rate variable
            }
            else if (fromCurrency == "EUR") //else if condition if fromCurrency is equal to EUR
            {
                exchangeRate = 159.23; //sets the exchange rate variable
            }
            else //else condition if fromCurrency does not equal any valid options
            {
                Console.WriteLine("Please enter a valid currency."); //displays text informing user the input was invalid
                return 0; //returns a 0 for a default output
            }

            return exchangeRate * amount; //calculates the estimated conversion of currency
        }

        static void Main(string[] args) //main method
        {
            Console.Write("Please enter the amount you would like to convert: "); //prompts user to input a double number
            double amountInput = Convert.ToDouble(Console.ReadLine()); //converts user input into a double variable
            Console.Write("Please enter the currency you are converting from (USD, EUR, JPY): "); //prompts the user for what currency they are using
            string currentCurrency = Console.ReadLine(); //converts user input to currentCurrency variable

            if (currentCurrency == "USD") //if condition if current currency is USD
            {
                Console.WriteLine(amountInput + " in USD would be " + ConvertToEUR(amountInput, currentCurrency) + " in EUR."); //displays converted currency
                Console.WriteLine(amountInput + " in USD would be " + ConvertToJPY(amountInput, currentCurrency) + " in JPY."); //displays converted currency
            }
            else if (currentCurrency == "EUR") //if condition if current currency is EUR
            {
                Console.WriteLine(amountInput + " in EUR would be " + ConvertToUSD(amountInput, currentCurrency) + " in USD."); //displays converted currency
                Console.WriteLine(amountInput + " in EUR would be " + ConvertToJPY(amountInput, currentCurrency) + " in JPY."); //displays converted currency
            }
            else if (currentCurrency == "JPY") //if condition if current currency is JPY
            {
                Console.WriteLine(amountInput + " in JPY would be " + ConvertToEUR(amountInput, currentCurrency) + " in EUR."); //displays converted currency
                Console.WriteLine(amountInput + " in JPY would be " + ConvertToUSD(amountInput, currentCurrency) + " in USD."); //displays converted currency
            }
            else//else condition if currency does not equal any valid options
            {
                Console.WriteLine("Enter a valid currency"); //displays text informing user to input a valid currency
            }

            Console.ReadKey(); //allows user to read program
        }
    }
}
