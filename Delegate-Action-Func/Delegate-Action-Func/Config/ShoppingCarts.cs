using Delegate_Action_Func.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Delegate_Action_Func.Config
{
    public static class ShoppingCarts
    {
        private static List<ShoppingCart> _shoppingCartList;

        public static void Init()
        {
            _shoppingCartList = new List<ShoppingCart>();
        }

        public static ShoppingCart GetShoppingCartForCustomer(int customerId)
        {
            return _shoppingCartList.Where(sc => sc.Customer.Id == customerId).FirstOrDefault();
        }

        public static void Add(ShoppingCart shoppingCart)
        {
            _shoppingCartList.Add(shoppingCart);
        }
    }
}
