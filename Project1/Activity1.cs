// Create and ADT to manage orders and products
// Order: can have 0 or more products -shipping -total (equals to the total of all products) 0 if is empty
// Product: -price -quantity - total= price * quantity -discount -title -description

using System;
using Project1;

namespace Activity1
{
    class Activity1
    {
        private static void Main(string[] args)
        {
            Order order1 = new Order();
            Product product1 = new Product();
            product1.price = 100M;
            product1.quantity = 2;
            product1.title = "Calculator";
            product1.description = "Casio cientific calculator";
            product1.discount = 10;
            product1.code = "001";

            Product product2 = new Product();
            product2.price = 100M;
            product2.quantity = 3;
            product2.title = "Calculator";
            product2.description = "Casio cientific calculator";
            product2.discount = 10;
            product2.code = "001";

            order1.addProduct(product1);
            order1.addProduct(product2);
            Console.WriteLine("Product 1 quantity: " + product1.quantity);
            //Console.WriteLine("Product 2 quantity: " + product2.quantity);
            Console.WriteLine("Total of products: " + order1.total);
            order1.totalP();
            Console.WriteLine("Total of the order: " + order1.totalPrice);
        }
    }
}


