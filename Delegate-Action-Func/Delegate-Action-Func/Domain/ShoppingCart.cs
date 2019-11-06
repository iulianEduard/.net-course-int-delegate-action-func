using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Action_Func.Domain
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }

        public Customer Customer { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public int NumberOfProducts { get; set; }

        public double TotalPrice { get; set; }

        public double TotalTaxes { get; set; }

        public double TotalValue { get; set; }

        public ShoppingCart()
        {
            ShoppingCartItems = new List<ShoppingCartItem>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("--> Shopping Cart Details");
            sb.AppendLine($"Id: {Id}");
            sb.AppendLine("Cart items:");

            foreach(var cartItem in ShoppingCartItems)
            {
                sb.AppendLine(cartItem.ToString());
            }

            sb.AppendLine($"Number of products: {NumberOfProducts}");
            sb.AppendLine($"Total price: {TotalPrice}");
            sb.AppendLine($"Total taxes: {TotalTaxes}");
            sb.AppendLine($"Total value: {TotalValue}");
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
