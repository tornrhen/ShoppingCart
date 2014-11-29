using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using ShoppingCart.Logic;
using ShoppingCart.Tests.Factories;
using ShoppingCart.Tests.Mocks;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void AnEmptyCartShouldHaveATotalOf0()
        {
            ICartRepository mockCartRepository = new CartRepositoryMockEmpty();
            var cart = new Cart(mockCartRepository);
            var total = cart.CalculateTotal();
            Assert.AreEqual(0, total, "JAJAJA LOLOLOL XDXD el total esta malo XD");
        }

        [TestMethod]
        public void OnePencilInTheCartShouldHaveATotalOf3()
        {
            ICartRepository mockCartRepository = new CartRepositoryMockEmpty();
            var cart = new Cart(mockCartRepository);
            var pencil = ItemFactory.CreatePencil();
            cart.AddItem(pencil);
            var total = cart.CalculateTotal();
            Assert.AreEqual(3, total, "JAJAJA LOLOLOL XDXD el total esta malo XD");
        }

        [TestMethod]
        public void TwoPencilsInTheCartShouldHaveATotalOf6()
        {
            ICartRepository mockCartRepository = new CartRepositoryMockEmpty();
            var cart = new Cart(mockCartRepository);
            var pencil = ItemFactory.CreatePencil();
            cart.AddItem(pencil,2);
            var total = cart.CalculateTotal();
            Assert.AreEqual(6, total, "JAJAJA LOLOLOL XDXD el total esta malo XD");
        }


        [TestMethod]
        public void TwoPencilsStoredInTheCartShouldHaveATotalOf6()
        {
            ICartRepository mockCartRepository = new CartRepositoryMock2Pencils();
            var cart = new Cart(mockCartRepository);
            cart.LoadItemsFromStorage();
            var total = cart.CalculateTotal();
            Assert.AreEqual(6, total, "JAJAJA LOLOLOL XDXD el total esta malo XD");
        }

        [TestMethod]
        public void TwoPencilsStoredInTheCartPlusAddingANewOneShouldHaveATotalOf9()
        {
            var mockCartRepository = MockRepository.GenerateMock<ICartRepository>();
            mockCartRepository.Stub(cartRepository => cartRepository.GetProducts()).
                             Return(new List<Item>(){ItemFactory.CreatePencil(),ItemFactory.CreatePencil()});
            var cart = new Cart(mockCartRepository);
            cart.LoadItemsFromStorage();
            cart.AddItem(ItemFactory.CreatePencil());
            var total = cart.CalculateTotal();
            Assert.AreEqual(9, total, "JAJAJA LOLOLOL XDXD el total esta malo XD");
        }
}
}
