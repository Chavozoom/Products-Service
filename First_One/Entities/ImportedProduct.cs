using System.Globalization;

namespace First_One.Entities
{
    internal class ImportedProduct : Product
    {
        public double CostumsFee { get; set; }


        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double costumsFee) : base(name, price)
        {
            CostumsFee = costumsFee;
        }
        public double TotalPrice()
        {
            return Price + CostumsFee;
        }

        public override string TagPrice()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ " 
                + CostumsFee.ToString("F2", CultureInfo.InvariantCulture)
                +")";
        }
    }
}
