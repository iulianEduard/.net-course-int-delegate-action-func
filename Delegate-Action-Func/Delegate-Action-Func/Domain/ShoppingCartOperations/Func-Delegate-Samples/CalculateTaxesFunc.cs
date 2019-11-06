using Delegate_Action_Func.Domain;
using System;

namespace Delegate_Action_Func.Domain.ShoppingCartOperations.Func_Delegate_Samples
{
    public class CalculateTaxesFunc
    {
        public void Handle(ShoppingCartItem shoppingCartItem, Product product, int quantity, Func<Product, int, double> func)
        {
            shoppingCartItem.ProductTaxes = func(product, quantity);
        }
    }
}
