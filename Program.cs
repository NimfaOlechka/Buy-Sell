using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string userChoice = Console.ReadLine();

           if (Sell)
            {
                Sell

            }else
            {
                (Buy)
            }

        }
    }

    class Money
    {
        public static double userMoney = 500;
    }
    class Sell
    {
        
        private double sellPrice = 0.5;

        Money newMoney = new Money();
        

        public void SetPrice(double userMoney)
        {
            Random rand = new Random();
            sellPrice += rand.Next(11,33);
        }

        public double GetNewMoney()
        {
           return Money.userMoney += sellPrice;
           
        }
    }
}

}
