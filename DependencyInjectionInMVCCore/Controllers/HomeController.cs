using DependencyInjectionInMVCCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionInMVCCore.Controllers
{
    public class HomeController : Controller
    {
        //ProductRepository repo = new ProductRepository();

        private readonly IProductRepository _repo;

        public HomeController(IProductRepository repo)
        {
            _repo = repo;
            //_logger = logger;
        }

        public IActionResult Index()
        {
            var productse = _repo.GetAllProduct();

            return View(productse);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
