﻿using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Skywalker.Webshop.Models;

namespace Skywalker.Webshop.Handlers
{
    public class ProductPartHandler : ContentHandler
    {
        public ProductPartHandler(IRepository<ProductPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
