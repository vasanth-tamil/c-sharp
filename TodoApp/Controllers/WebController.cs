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
            var item = new {};
            return View(item);
        }
    }
}
