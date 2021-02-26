using System;

namespace Decorator
{
    /// <summary>
    /// 'Concrete Components'.
    /// A concrete implementation of a component to which new functionality is added using a decorator.
    /// </summary>
    public class Preorder : GuitarComponent
    {
        public Preorder(string name, int price) : base(name, price) { }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price of a {Name} preorder.");

            return Price * 0.9;
        }

        public override string Operation()
        {
            return $"ConcreteComponent {Name}";
        }
    }
}
