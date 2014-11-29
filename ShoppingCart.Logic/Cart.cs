using System.Collections.Generic;

namespace ShoppingCart.Logic
{
    public class Cart
    {
        private ICartRepository _cartRepository;
        private List<Item> _itemList= new List<Item>();

        public Cart(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
      
        public float CalculateTotal()
        {
            var total = 0.0f;
            foreach (var item in _itemList)
            {
                total += item.UnitPrice;
            }
            return total;
        }

        public void AddItem(Item item)
        {
            _itemList.Add(item);
        }

        public void AddItem(Item item, int quantity)
        {
            for(var i=0;i<quantity;i++)
                AddItem(item);
        }

        public void LoadItemsFromStorage()
        {
           _itemList =  _cartRepository.GetProducts();
        }
    }
}