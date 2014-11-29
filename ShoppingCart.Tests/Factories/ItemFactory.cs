using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Logic;

namespace ShoppingCart.Tests.Factories
{
    public class ItemFactory
    {
        public static Item CreatePencil()
        {
            var pencil = new Item
            {
                UnitPrice = 3.0f,
                Name = "Penciru"
            };
            return pencil;
        }
    }
}
