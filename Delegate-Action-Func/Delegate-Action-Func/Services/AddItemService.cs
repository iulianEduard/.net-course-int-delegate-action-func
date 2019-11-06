using Delegate_Action_Func.Config;
using Delegate_Action_Func.Core;
using Delegate_Action_Func.Domain;
using Delegate_Action_Func.Domain.ShoppingCartOperations;

namespace Delegate_Action_Func.Services
{
    public class AddItemService
    {
        private readonly AddItemToShoppingCart _addItemToShoppingCart;
        private readonly CreateShoppingCart _createShoppingCart;
        private readonly UpdateShoppingCart _updateShoppingCart;

        public AddItemService()
        {
            _addItemToShoppingCart = new AddItemToShoppingCart();
            _createShoppingCart = new CreateShoppingCart();
            _updateShoppingCart = new UpdateShoppingCart();
        }

        public ShoppingCart Handle(Customer customer, Product product, int quantity, bool isDelegate)
        {
            var shoppingCart = GetOrCreateShoppingCart(customer);

            AddProductToCart(shoppingCart, customer.CustomerType, product, quantity, isDelegate);

            UpdateShoppingCart(shoppingCart);

            return shoppingCart;
        }

        private ShoppingCart GetOrCreateShoppingCart(Customer customer)
        {
            var cart = ShoppingCarts.GetShoppingCartForCustomer(customer.Id);

            if (cart == null)
            {
                cart = _createShoppingCart.Handle(customer);
            }

            return cart;
        }

        private void AddProductToCart(ShoppingCart shoppingCart, CustomerType customerType, Product product, int quantity, bool isDelegate)
        {
            _addItemToShoppingCart.Handle(shoppingCart, customerType, product, quantity, isDelegate);
        }

        private void UpdateShoppingCart(ShoppingCart shoppingCart)
        {
            _updateShoppingCart.Handle(shoppingCart);
        }
    }
}
