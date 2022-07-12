using Exercitii_laborator_10.Interfaces;
using System.Collections.Generic;

namespace Exercitii_laborator_10
{
    class Basket
    {
        public List<IProduct> products = new List<IProduct>();


        public void Add(IProduct product)
        {
            products.Add(product);
        }

        public void Remove(IProduct product)
        {
            foreach (var item in products)
            {
                if (string.Equals(item.Id, product.Id))
                {
                    products.Remove(item);
                    break;
                }
            }
        }
    }
}
