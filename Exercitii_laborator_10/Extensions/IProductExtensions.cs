using Exercitii_laborator_10.Interfaces;

namespace Exercitii_laborator_10.Extensions
{
    static class IProductExtensions
    {
        public static string Description(this IProduct product)
        {
            return $"Id: {product.Id}  |  Name: {product.Name}  |  Price: {product.Price} lei";
        }
    }
}
