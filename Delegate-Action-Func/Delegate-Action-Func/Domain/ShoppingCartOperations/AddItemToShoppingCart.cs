using Delegate_Action_Func.Core;
using Delegate_Action_Func.Domain.ShoppingCartOperations.Func_Delegate_Samples;
using System;

namespace Delegate_Action_Func.Domain.ShoppingCartOperations
{
    public class AddItemToShoppingCart
    {
        private readonly CalculateTaxesFunc _calculateTaxesFunc;
        private readonly CalculateTaxesDelegate _calculateTaxesDelegate;
        private readonly ProductTaxCalculation _taxCalculation;

        public AddItemToShoppingCart()
        {
            _calculateTaxesFunc = new CalculateTaxesFunc();
            _calculateTaxesDelegate = new CalculateTaxesDelegate();
            _taxCalculation = new ProductTaxCalculation();
        }

        public void Handle(ShoppingCart shoppingCart, CustomerType customerType, Product product, int quantity, bool isDelegate)
        {
            var shoppingCartItem = CreateShoppingCartItem(product, quantity);

            CalculateTaxes(shoppingCartItem, product, shoppingCart, customerType, quantity, isDelegate);

            AddShoppingCartItemToCart(shoppingCartItem, shoppingCart);
        }

        private ShoppingCartItem CreateShoppingCartItem(Product product, int quantity)
        {
            var shoppingCartItem = new ShoppingCartItem
            {
                Id = Guid.NewGuid(),
                ProductId = product.Id,
                ProductQuantity = quantity,
                ProductPrice = quantity * product.Price,
            };

            return shoppingCartItem;
        }

        private void CalculateTaxes(ShoppingCartItem shoppingCartItem, Product product, ShoppingCart shoppingCart, CustomerType customerType, int quantity, bool isDelegate)
        {
            if (isDelegate)
            {
                _calculateTaxesDelegate.Handle(shoppingCartItem, customerType, product, quantity);
            }
            else
            {
                switch (customerType)
                {
                    case CustomerType.Basic:
                        _calculateTaxesFunc.Handle(shoppingCartItem, product, quantity,
                            _taxCalculation.CalculateTaxForBasicCustomer);

                        break;
                    case CustomerType.Standard:
                        _calculateTaxesFunc.Handle(shoppingCartItem, product, quantity,
                            _taxCalculation.CalculateTaxForStandardCustomer);

                        break;
                    case CustomerType.Premium:
                        _calculateTaxesFunc.Handle(shoppingCartItem, product, quantity,
                            _taxCalculation.CalculateTaxForPremiumCustomer);

                        break;
                    case CustomerType.Gold:
                        _calculateTaxesFunc.Handle(shoppingCartItem, product, quantity,
                            _taxCalculation.CalculateTaxForGoldCustomer);

                        break;
                }
            }
        }

        private void AddShoppingCartItemToCart(ShoppingCartItem shoppingCartItem, ShoppingCart shoppingCart)
        {
            shoppingCart.ShoppingCartItems.Add(shoppingCartItem);
        }
    }
}
