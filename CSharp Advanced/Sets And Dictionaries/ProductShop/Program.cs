using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shopsAndProducts = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var input = Console.ReadLine().Split(',').ToArray();
                if (input[0] == "Revision")
                {
                    break;
                }

                string shopName = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shopsAndProducts.ContainsKey(shopName))
                {
                    shopsAndProducts[shopName] = new Dictionary<string, double>();
                }
                shopsAndProducts[shopName].Add(product, price);
            }
            foreach (var shopName in shopsAndProducts.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}->", shopName.Key);
                Dictionary<string, double> productsAndPrice = shopName.Value;

                foreach (var shops in productsAndPrice)
                {
                    Console.WriteLine($"Product:{shops.Key}, Price: {shops.Value}");
                }
            }
        }
    }
}
