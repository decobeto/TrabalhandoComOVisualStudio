using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrabalhandoComOVisualStudio.Models;


namespace TrabalhandoComOVisualStudio.Controllers
{
    public class HomeController : Controller {
        public IActionResult Index()
        {
            return View(SimpleRepository.SharedRepository.Products);
        }
    }
}
