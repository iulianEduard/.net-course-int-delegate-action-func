using Delegate_Action_Func.Core;

namespace Delegate_Action_Func.Domain.ShoppingCartOperations.Func_Delegate_Samples
{
    public delegate double CalculateTax(Product product, int quantity);

    public class CalculateTaxesDelegate
    {
        private readonly ProductTaxCalculation _productTaxCalculation;

        public CalculateTaxesDelegate()
        {
            _productTaxCalculation = new ProductTaxCalculation();
        }

        public void Handle(ShoppingCartItem shoppingCartItem, CustomerType customerType, Product product, int quantity)
        {
            switch(customerType)
            {
                case Core.CustomerType.Basic:
                    CalculateTax basicTax = new CalculateTax(_productTaxCalculation.CalculateTaxForBasicCustomer);
                    shoppingCartItem.ProductTaxes = basicTax(product, quantity);
                    break;
                case Core.CustomerType.Standard:
                    CalculateTax standardTax = new CalculateTax(_productTaxCalculation.CalculateTaxForStandardCustomer);
                    shoppingCartItem.ProductTaxes = standardTax(product, quantity);
                    break;
                case Core.CustomerType.Premium:
                    CalculateTax premiumTax = new CalculateTax(_productTaxCalculation.CalculateTaxForPremiumCustomer);
                    shoppingCartItem.ProductTaxes = premiumTax(product, quantity);
                    break;
                case Core.CustomerType.Gold:
                    CalculateTax goldTax = new CalculateTax(_productTaxCalculation.CalculateTaxForGoldCustomer);
                    shoppingCartItem.ProductTaxes = goldTax(product, quantity);
                    break;
            }
        }
    }
}
