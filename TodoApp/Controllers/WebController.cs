using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    [Route("")]
    public class WebController : Controller
    {
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var item = new
            {
                Id = 1,
                Name = "Sample Data from controller.",
                Age = 20,
                Address = "Chennai, 600001"
            };
            return View(item);
        }

        [Route("show/{id:int}")]
        public IActionResult Show(int id)
        {
            var item = new { Id = id };
            return View(item);
        }

        [Route("product/{id:int}/overview")]
        public IActionResult OverView(int id)
        {
            var item = new { ProductId = id };
            return View(item);
        }

    }
}
