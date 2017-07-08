using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            
            stocks.Add("GE", "General Electrics");
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("HP", "Hevlett Packard");
            stocks.Add("MS", "Microsoft");
            stocks.Add("CNN", "Cable News Network");

            Console.WriteLine(stocks["GM"]);

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            
            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 150, price: 23.21));

            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));

            purchases.Add((ticker: "CAT", shares: 145, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 145, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 145, price: 19.02));

            purchases.Add((ticker: "HP", shares: 341, price: 18.21));
            purchases.Add((ticker: "HP", shares: 341, price: 18.21));
            purchases.Add((ticker: "HP", shares: 341, price: 18.21));

            purchases.Add((ticker: "MS", shares: 167, price: 45.23));
            purchases.Add((ticker: "MS", shares: 167, price: 45.23));
            purchases.Add((ticker: "MS", shares: 167, price: 45.23));

            purchases.Add((ticker: "CNN", shares: 143, price: 32.23));
            purchases.Add((ticker: "CNN", shares: 143, price: 32.23));
            purchases.Add((ticker: "CNN", shares: 143, price: 32.23));

            Dictionary<string, double> totalStock = new Dictionary<string, double>();

            foreach((string ticker, int shares, double price) purchase in purchases)
            {
                if(stocks.ContainsKey(purchase.ticker))
                {
                    if(totalStock.ContainsKey(stocks[purchase.ticker]))
                    {
                        totalStock[stocks[purchase.ticker]] += (purchase.shares * purchase.price);
                    } else 
                    {
                        totalStock.Add(stocks[purchase.ticker], purchase.shares * purchase.price);
                    }
                }
            }
            foreach (KeyValuePair<string, double> stock in totalStock)
            {
                Console.WriteLine(stock);
            }
        }
    }
}
