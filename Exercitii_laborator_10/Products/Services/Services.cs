using Exercitii_laborator_10.Interfaces;


namespace Exercitii_laborator_10.Products.Services
{
    abstract class Services : IProduct
    {
        public abstract string Id { get; }
        public abstract string Name { get; }
        public abstract double Price { get; }
    }
}
