using System.Collections.Generic;

namespace ShoppingCart.Logic
{
    public interface ICartRepository
    {
        List<Item> GetProducts();
    }
}