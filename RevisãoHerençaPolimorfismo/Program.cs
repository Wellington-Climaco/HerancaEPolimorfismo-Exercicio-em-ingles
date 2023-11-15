using RevisãoHerençaPolimorfismo.Entidades;
using RevisãoHerençaPolimorfismo.Entities;
using System.Globalization;

Console.Write("Enter the number of products: ");
int NumberOfProducts = int.Parse(Console.ReadLine());
List<Product> Products = new List<Product>();

for (int i = 0; i < NumberOfProducts; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Produto #{i+1} data:");
    Console.Write("Common, Used or Imported (c/u/i): ");
    string ProductType = Console.ReadLine().ToLower();
    Console.Write("Name: ");
    string Name = Console.ReadLine();
    Console.Write("Price: ");
    double Price = double.Parse(Console.ReadLine());

    if (ProductType == "c")
    {
        Products.Add(new Product(Name, Price));
    }
    else if (ProductType == "u")
    {
        Console.Write("Manufacture Date (DD/MM/YYYY): ");
        DateTime ManufactureDate = DateTime.Parse(Console.ReadLine());        
        Products.Add(new UsedProduct(Name,Price, ManufactureDate));
    }
    else if ( ProductType == "i")
    {
        Console.Write("Customs Fee: ");
        double customsfee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Products.Add(new ImportedProduct(Name,Price,customsfee));
    }
}
Console.WriteLine();
Console.WriteLine("Price Tags: ");
foreach (Product Product in Products)
{
    Console.WriteLine(Product.EtiquetaPreco());
}



