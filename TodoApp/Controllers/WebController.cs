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
            var item = new {
                Title = "accusamus et culpa eu ullamco accusamus ",
                News = "lorem ipsum dolor sit amet consectetur adipiscing elit occaecat omnis amet ipsum dolor eiusmod magna commodo iusto do quos officia qui iusto libero enim duis est quod atque veniam tempor pariatur sunt in velit animi quas quis repellendus cupidatat vel adipiscing occaecat mollitia consequatur enim voluptate id et laborum accusamus fugiat qui proident aut nobis et dolorum assumenda mollitia sit dolore non est voluptas quis optio in est odio iusto sunt fugiat sunt cum dolore dolorum nisi similique aliqua nobis consequatur duis temporibus in in ad ea proident voluptas deserunt dolor magna esse quibusdam officia ea voluptate provident adipiscing temporibus est et quod non nobis velit dolore molestias aliqua occaecat temporibus quis accusamus et culpa eu ullamco accusamus enim tempor quis ducimus quidem esse et ex tempore quod id cillum excepteur velit fugiat dolores corrupti",
                Date = DateTime.Now,
            };
            return View(item);
        }
    }
}
