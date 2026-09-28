using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    [Route("")]
    public class WebController : Controller
    {
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
    }
}
