namespace Decorator
{
    /// <summary>
    /// 'Component' class.
    /// The Component class contains functionality that will be shared with other Concrete Component classes.
    /// </summary>
    public abstract class GuitarComponent
    {
        /// <summary>
        /// Guitar name.
        /// </summary>
        public string Name { get; protected set; }

        public int Price { get; protected set; }

        protected GuitarComponent(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public abstract string Operation();

        public abstract double CalculateTotalOrderPrice();
    }
}