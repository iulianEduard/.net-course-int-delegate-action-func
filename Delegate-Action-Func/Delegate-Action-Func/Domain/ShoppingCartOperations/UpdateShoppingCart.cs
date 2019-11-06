using System.Collections.Generic;
using System.Linq;

namespace Delegate_Action_Func.Domain.ShoppingCartOperations
{
    public class UpdateShoppingCart
    {
        public void Handle(ShoppingCart shoppingCart)
        {
            shoppingCart.TotalPrice = CalculateTotalPrice(shoppingCart.ShoppingCartItems);
            shoppingCart.TotalTaxes = CalculateTotalTax(shoppingCart.ShoppingCartItems);
            shoppingCart.TotalValue = CalculateTotalValue(shoppingCart);
            shoppingCart.NumberOfProducts = CountNumberOfItems(shoppingCart.ShoppingCartItems);
        }

        private double CalculateTotalPrice(List<ShoppingCartItem> shoppingCartItems)
        {
            return shoppingCartItems.Sum(sci => sci.ProductPrice);
        }

        private double CalculateTotalTax(List<ShoppingCartItem> shoppingCartItems)
        {
            return shoppingCartItems.Sum(sci => sci.ProductTaxes);
        }

        private double CalculateTotalValue(ShoppingCart shoppingCart)
        {
            return shoppingCart.TotalPrice + shoppingCart.TotalTaxes;
        }

        private int CountNumberOfItems(List<ShoppingCartItem> shoppingCartItems)
        {
            return shoppingCartItems.Count();
        }
    }
}
