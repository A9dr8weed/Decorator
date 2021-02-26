using System;

namespace Decorator
{
    /// <summary>
    /// Decorator class which is going to wrap our GuitarComponent.
    /// Implements communication with the base class through inheritance and through an aggregation relation.
    /// </summary>
    public class GuitarDecorator : GuitarComponent
    {
        /// <summary>
        /// A reference to the decorated object in the form of an object of the base class Component.
        /// </summary>
        protected GuitarComponent _guitarComponent;

        public GuitarDecorator(string name, int price, GuitarComponent guitarComponent) : base(name, price)
        {
            _guitarComponent = guitarComponent;
        }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price in a {Name} decorator class");

            return _guitarComponent.CalculateTotalOrderPrice();
        }

        public override string Operation()
        {
            return _guitarComponent != null ? _guitarComponent.Operation() : string.Empty;
        }
    }
}