using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите информацию о товарах в формате 'title product, shop, price'. " +
                "По одному товару на строке: ");
            Price[] products = InputInfoOfProducts(2);

            bool flag = true;
            while (flag)
            {
                Console.Write("Введите название магазина: ");
                try
                {
                    OutputProductFromShop(products, Console.ReadLine().ToLower());
                    flag = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    flag = true;
                }
            }
        }
        static Price[] InputInfoOfProducts(int pricesLength)
        {
            Price[] products = new Price[pricesLength];
            for (int i = 0; i < products.Length; i++)
            {
                try
                {
                    products[i] = Price.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            return products;
        }
        static void OutputProductFromShop(Price[] products, string shop)
        {
            int count = 0;
            Console.WriteLine("Товары доступные в магазине: ");
            foreach (Price element in products)
                if (element.Shop == shop)
                {
                    Console.WriteLine(element);
                    count++;
                }
            if (count == 0)
                throw new Exception("В базе данных нет товаров по заданому магазину!");
        }
    }
}
