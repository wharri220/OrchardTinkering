using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Orchard.ContentManagement;

namespace Skywalker.Webshop2.Models
{
    public class ProductPartRecord : ContentPart<ProductPartRecord>
    {
        public virtual decimal UnitPrice { get; set; }
        public virtual string Sku { get; set; }
    }
}
