using System.Globalization;

namespace Heranca_Ex_02.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) ${Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufactored date: {ManufacturedDate:dd/MM/yyyy})";
        }
    }
}
