using Delegate_Action_Func.Domain;
using System.Collections.Generic;

namespace Delegate_Action_Func.Config
{
    public static class Products
    {
        public static List<Product> Init()
        {
            var productList = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Basic Armor",
                    Price = 25.99,
                    Discount = 0.01
                },
                new Product
                {
                    Id = 2,
                    Name = "Reinforced Armor",
                    Price = 49.99,
                    Discount = 0.02
                },
                new Product
                {
                    Id = 3,
                    Name = "Small Sword",
                    Price = 19.99,
                    Discount = 0.001
                },
                new Product
                {
                    Id = 4,
                    Name = "Steel Sword",
                    Price = 49.99,
                    Discount = 0.02
                },
                new Product
                {
                    Id = 5,
                    Name = "Dragon Glass Sword",
                    Price = 199.99,
                    Discount = 0.2
                }
            };

            return productList;
        }
    }
}
