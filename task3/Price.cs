using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    struct Price
    {
        private string title;
        private string shop;
        private decimal value;

        public string Title { get => title; set => title = value; }
        public string Shop { get => shop; set => shop = value; }
        public decimal Value { get => value; set => this.value = value; }

        public Price(string title, string shop, decimal value)
        {
            this.title = title;
            this.shop = shop;
            this.value = value;
        }
        public override string ToString()
        {
            return $"Products title: {title}, shop: {shop}, price: {value} grn.";
        }
        public static Price Parse(string infoOfProduct)
        {
            string[] infoArgs = infoOfProduct.Split(",");
            for (int i = 0; i < infoArgs.Length; i++)
                infoArgs[i] = infoArgs[i].Trim();
            if (infoArgs.Length != 3)
                throw new Exception("Wrong data format");

            decimal value;
            if (!decimal.TryParse(infoArgs[2], out value))
                throw new Exception("Wrong price format");

            return new Price(infoArgs[0], infoArgs[1].ToLower(), value);
        }
    }
}
