using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerServices;

        public SellersController(SellerService sellersServices)
        {
            _sellerServices = sellersServices;
        }

        public IActionResult Index()
        {
            var list = _sellerServices.FindAll();
            return View(list);
        }
    }
}
