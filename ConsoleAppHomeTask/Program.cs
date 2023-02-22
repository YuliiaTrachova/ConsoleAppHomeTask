using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTask
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1
            Console.WriteLine("Input the nominal of the trade:");
            int nominal = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the trade price:");
            double tradePrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Transaction type “Buy”=0 or “Sell”=1:");
            var userInput = Console.ReadLine();
            TransactionType trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            int sign = trcType is TransactionType.Buy ? 1 : -1;
            var currentValue = nominal * tradePrice * sign;
            Console.WriteLine($"Current value is {currentValue}");


            //Assignment 2

            Console.WriteLine("Input the original price:");
            double originPrice = double.Parse(Console.ReadLine());

            int sellTrc = trcType is TransactionType.Sell ? 1 : 0;

            var profitLoss = (tradePrice - originPrice) * nominal * sellTrc;
            var result = profitLoss > 0 ? "profit" : "loss";
            Console.WriteLine($"Your {result} is {profitLoss}");

            Console.ReadKey();


        }
    }
}

