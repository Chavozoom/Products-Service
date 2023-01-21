using System.Globalization;
using First_One.Entities;

namespace Training
{

    class Program

    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");

                Console.Write("Common, used, imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'c' || type == 'C')
                {
                    list.Add(new Product(name, price));
                }
                else if (type == 'u' || type == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    Console.Write("Costums fee: ");
                    double costumsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, costumsFee));
                }
                Console.WriteLine();
            }
            Console.WriteLine("Price Tags: ");
            foreach(Product product in list)
            {
                Console.WriteLine(product.TagPrice());
            }
        }      
    }
}