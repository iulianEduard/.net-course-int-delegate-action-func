namespace Delegate_Action_Func.Domain
{
    public class ProductTaxCalculation
    {
        private const double BASE_TAX = 0.19;

        public double CalculateTaxForBasicCustomer(Product product, int quantity)
        {
            double basicDiscount = 0.001;

            double tax = (product.Price * BASE_TAX) + (product.Price * basicDiscount);

            return tax * quantity;
        }

        public double CalculateTaxForStandardCustomer(Product product, int quantity)
        {
            double standardDiscount = 0.010;

            double tax = (product.Price * BASE_TAX) + (product.Price * standardDiscount);

            return tax * quantity;
        }

        public double CalculateTaxForPremiumCustomer(Product product, int quantity)
        {
            double premiumDiscount = 0.1;

            double tax = (product.Price * BASE_TAX) + (product.Price * premiumDiscount)
                + (product.Price * product.Discount);

            return tax * quantity;
        }

        public double CalculateTaxForGoldCustomer(Product product, int quantity)
        {
            double goldDiscount = 0.2;

            double tax = (product.Price * BASE_TAX) + (product.Price * goldDiscount)
                + (product.Price * product.Discount);

            return tax * quantity;
        }
    }
}
