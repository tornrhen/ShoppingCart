using System.Collections.Generic;
using ShoppingCart.Logic;

namespace ShoppingCart.Tests.Mocks
{
    public class CartRepositoryMockEmpty : ICartRepository
    {
        public List<Item> GetProducts()
        {
            return new List<Item>();
        }
    }
}