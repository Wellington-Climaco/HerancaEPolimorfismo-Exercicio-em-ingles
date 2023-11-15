
using RevisãoHerençaPolimorfismo.Entities;
using System.Globalization;

namespace RevisãoHerençaPolimorfismo.Entidades
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public UsedProduct UsedProduct { get; set; }
        public ImportedProduct ImportedProduct { get; set; }

        public Product() 
        {
        
        }

        public Product (string name,double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string EtiquetaPreco()
        {
            return $"{Name} $ {Price.ToString("F2",CultureInfo.InvariantCulture)}";

        }

    }
}
