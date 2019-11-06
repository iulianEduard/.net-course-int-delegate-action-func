using Delegate_Action_Func.Config;
using Delegate_Action_Func.Domain;
using Delegate_Action_Func.Services;
using System;
using System.Collections.Generic;

namespace Delegate_Action_Func
{
    class Program
    {
        private static List<Customer> customerList;
        private static List<Product> productList;
        private static AddItemService _addItemService;

        static void Main(string[] args)
        {
            Init();

            AddDelegateForCustomer();

            AddFuncForCustomer();

            Console.ReadKey();
        }

        private static void Init()
        {
            _addItemService = new AddItemService();
            ShoppingCarts.Init();

            customerList = Customers.Init();
            productList = Products.Init();
        }

        private static void AddDelegateForCustomer()
        {
            var shoppingCart = _addItemService.Handle(customerList[0], productList[0], 2, false);

            Console.WriteLine("*** Shopping cart ***");
            Console.WriteLine(shoppingCart.ToString());

            ShoppingCarts.Add(shoppingCart);
        }

        private static void AddFuncForCustomer()
        {
            var shoppingCart = _addItemService.Handle(customerList[0], productList[1], 2, true);

            Console.WriteLine("*** Shopping cart ***");
            Console.WriteLine(shoppingCart.ToString());

            ShoppingCarts.Add(shoppingCart);
        }
    }
}
