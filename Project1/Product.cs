using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Product
    {
        public static decimal Count { get; internal set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int discount { get; set; }
        public string code { get; set; }
        public decimal total => (price * quantity) - (price * (discount / 100));
    }
}
