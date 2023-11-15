using Microsoft.VisualBasic;
using RevisãoHerençaPolimorfismo.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisãoHerençaPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureData { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price,DateTime manufactureData)
        {
            Name = name;
            Price = price;
            ManufactureData = manufactureData;
        }

        public override string EtiquetaPreco()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (ManufactureDate date: {ManufactureData.ToString("dd/MM/yyyy")})";
        }


    }
}
