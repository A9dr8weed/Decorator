using System;

namespace Decorator
{
    /// <summary>
    /// 'Concrete Components'.
    /// A concrete implementation of a component to which new functionality is added using a decorator.
    /// </summary>
    public class RegularOrder : GuitarComponent
    {
        public RegularOrder(string name, int price) : base(name, price) { }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price of a {Name} regular order");

            return Price;
        }

        public override string Operation()
        {
            return $"ConcreteComponent {Name}";
        }
    }
}