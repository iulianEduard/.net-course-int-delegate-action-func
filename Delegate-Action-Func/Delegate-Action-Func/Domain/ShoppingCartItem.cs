using System;
using System.Text;

namespace Delegate_Action_Func.Domain
{
    public class ShoppingCartItem
    {
        public Guid Id { get; set; }

        public int ProductId { get; set; }

        public double ProductPrice { get; set; }

        public double ProductQuantity { get; set; }

        public double ProductTaxes { get; set; }

        public double ProductDiscount { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("----> Shopping cart item");
            sb.AppendLine($"----> Id: {Id}");
            sb.AppendLine($"----> ProductId: {ProductId}");
            sb.AppendLine($"----> Price: {ProductPrice}");
            sb.AppendLine($"----> Quantity: {ProductQuantity}");
            sb.AppendLine($"----> Taxes: {ProductTaxes}");
            sb.AppendLine($"----> Discount: {ProductDiscount}%");

            return sb.ToString();
        }
    }
}
