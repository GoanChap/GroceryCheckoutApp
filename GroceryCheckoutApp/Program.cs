using System;

namespace GroceryCheckoutApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CheckoutApp app = new CheckoutApp();
            app.Scan('A');
            app.Scan('B');
            app.Scan('A');
            app.Scan('X');
            Console.WriteLine("Your total is: " + app.Total());
        }
    }
}
