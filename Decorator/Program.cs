using System;

namespace Decorator
{
    public static class Program
    {
        private static void Main()
        {
            GuitarComponent regularOrder = new RegularOrder("Cort", 2000);
            Console.WriteLine(regularOrder.CalculateTotalOrderPrice());

            GuitarComponent preorder = new Preorder("Fender", 2300);
            Console.WriteLine(preorder.CalculateTotalOrderPrice());

            Console.WriteLine();

            // As we can see, with the premiumPreorder object we are wrapping the preorder object to which we add an additional behavior.
            GuitarComponent premium = new PremiumPreorder(preorder);
            GuitarComponent premium2 = new PremiumPreorder(premium);

            Console.WriteLine(premium.CalculateTotalOrderPrice());
            Console.WriteLine(premium.Operation());

            Console.WriteLine();

            Console.WriteLine(premium2.CalculateTotalOrderPrice());
            Console.WriteLine(premium2.Operation());
        }
    }
}