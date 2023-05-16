using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;
using shopapp.webui.ViewModels;

namespace shopapp.webui.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>(){
                new Product{Name="IPhone 8",Price=8000,Description="İyi telefon",IsApproved = false},
                new Product{Name="IPhone X",Price=8000,Description="Çok iyi telefon",IsApproved = true},
                new Product{Name="IPhone 11",Price=9000,Description="Çok iyi telefon",IsApproved = true},
                new Product{Name="IPhone 12",Price=10000,Description="Çok iyi telefon"},
            };

            var productViewModel = new ProductViewModel{
                Products = products
            };

            return View(productViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}