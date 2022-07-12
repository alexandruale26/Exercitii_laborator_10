using Exercitii_laborator_10.Interfaces;
using System.Text;


namespace Exercitii_laborator_10.Products.Electronic
{
    abstract class ElectronicProduct : IProduct
    {
        public abstract string Id { get; }
        public abstract string Name { get; }
        public abstract double Price { get; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append($"Id: {this.Id}  |  Name: {this.Name}  |  Price: {this.Price} lei").ToString();
        }
    }
}
