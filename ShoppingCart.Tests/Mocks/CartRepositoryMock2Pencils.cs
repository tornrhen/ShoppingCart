using System;
using System.Collections.Generic;
using ShoppingCart.Logic;
using ShoppingCart.Tests.Factories;

namespace ShoppingCart.Tests.Mocks
{
    public class CartRepositoryMock2Pencils : ICartRepository
    {
        public List<Item> GetProducts()
        {
            return new List<Item>()
            {
                ItemFactory.CreatePencil(),
                ItemFactory.CreatePencil()
            };
        }
    }
}