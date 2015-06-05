﻿using System.Collections.Generic;
using Orchard;
using Skywalker.Webshop.Models;

namespace Skywalker.Webshop.Services
{
    public interface IShoppingCart : IDependency
    {
        IEnumerable<ShoppingCartItem> Items { get; }
        
        void Add(int productId, int quantity = 1);
        
        void Remove(int productId);

        ProductPart GetProduct(int productId);

        decimal Subtotal();

        decimal Vat();

        decimal Total();

        int ItemCount();

        void UpdateItems();
    }
}
