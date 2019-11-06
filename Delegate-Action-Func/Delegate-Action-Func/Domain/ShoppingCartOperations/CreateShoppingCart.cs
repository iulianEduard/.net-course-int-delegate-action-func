using Delegate_Action_Func.Core;
using System;

namespace Delegate_Action_Func.Domain.ShoppingCartOperations
{
    public class CreateShoppingCart
    {
        private readonly DisplayMessage _displayMessage;

        public CreateShoppingCart()
        {
            _displayMessage = new DisplayMessage();
        }

        public ShoppingCart Handle(Customer customer)
        {
            var shoppingCart = new ShoppingCart
            {
                Id = Guid.NewGuid(),
                Customer = customer
            };

            _displayMessage.Handle(Write, shoppingCart.ToString());

            return shoppingCart;
        }

        private void Write(string message)
        {
            Console.WriteLine("-> Shopping cart created");
            Console.WriteLine(message);
        }
    }
}
