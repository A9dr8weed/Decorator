using System;

namespace Decorator
{
    /// <summary>
    /// Concrete Decorator class which add additional functionality to our object.
    /// </summary>
    public class PremiumPreorder : GuitarDecorator
    {
        public PremiumPreorder(GuitarComponent guitarComponent) : base(guitarComponent.Name, guitarComponent.Price, guitarComponent) { }

        /// <summary>
        /// In this method, we are calculating the total price of the GuitarComponent object,
        /// but also adding the additional discount behavior.
        /// </summary>
        /// <returns> Total price. </returns>
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price in the {nameof(PremiumPreorder)} class.");

            return base.CalculateTotalOrderPrice() * 0.9;
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}