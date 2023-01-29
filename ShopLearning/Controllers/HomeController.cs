using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ShopLearning.Models;
using System.Diagnostics;

namespace ShopLearning.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        { 

            return View();
        }

        public async Task<IActionResult> Privacy([FromServices] IProductServices )
        {
            var result = await productServices.SelectProducts();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}