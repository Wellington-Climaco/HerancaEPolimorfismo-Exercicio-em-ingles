using RevisãoHerençaPolimorfismo.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisãoHerençaPolimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() 
        {
        }

        public ImportedProduct(string name, double price,double customsfee) :base(name,price)
        {
            CustomsFee = customsfee;
        }

        public double TotalPrice(double value)
        {
            return Price + CustomsFee;
        }


        public override string EtiquetaPreco()
        {
            return $"{Name} $ {TotalPrice(Price).ToString("F2",CultureInfo.InvariantCulture)} (Customs Fee: $ {CustomsFee})";
        }

    }
}
