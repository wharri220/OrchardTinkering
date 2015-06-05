using System.Web.Mvc;
using Orchard;
using Orchard.Mvc;
using Skywalker.Webshop.Services;

namespace Skywalker.Webshop.Controllers
{
    class ShoppingCartController : Controller
    {

        private readonly IShoppingCart _shoppingCart;
        private readonly IOrchardServices _services;

        public ShoppingCartController(IShoppingCart shoppingCart, IOrchardServices services)
        {
            _shoppingCart = shoppingCart;
            _services = services;
        }

        [HttpPost]
        public ActionResult Add(int id)
        {
            // Add item to the shopping cart
            _shoppingCart.Add(id, 1);

            // Redirect the user to index action (not implemented yet)
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            // Create a new shape using the "New" property of IOrchardServices
            var shape = _services.New.ShoppingCart();

            // Return a shape result
            return new ShapeResult(this, shape);
        }
    }
}
