using System.Globalization;

namespace _29_Exercicio_HerancaEPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustormsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double custormsFee) : base (name, price)
        {
            CustormsFee = custormsFee;
        }

        public double TotalPrice()
        {
            return Price * CustormsFee;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + "(Custorms fee: $ "
                + CustormsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
