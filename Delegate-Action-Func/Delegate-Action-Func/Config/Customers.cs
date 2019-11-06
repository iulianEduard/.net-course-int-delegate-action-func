using Delegate_Action_Func.Core;
using Delegate_Action_Func.Domain;
using System.Collections.Generic;

namespace Delegate_Action_Func.Config
{
    public static class Customers
    {
        public static List<Customer> Init()
        {
            var customerList = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Jon Snow",
                    Address = "Knight's watch",
                    CustomerType = CustomerType.Gold
                },
                new Customer
                {
                    Id = 2,
                    Name = "Sansa Stark",
                    Address = "Winterfell",
                    CustomerType = CustomerType.Premium
                },
                new Customer
                {
                    Id = 3,
                    Name = "Danerys",
                    Address = "Dragonstone",
                    CustomerType = CustomerType.Standard
                },
                new Customer
                {
                    Id = 4,
                    Name = "Arya Stark",
                    Address = "Pentos",
                    CustomerType = CustomerType.Basic
                }
            };

            return customerList;
        }
    }
}
