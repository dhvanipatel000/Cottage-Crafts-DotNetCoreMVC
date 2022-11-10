using cottage_crafts.data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace cottage_crafts.Controllers
{
    public class HomePageController : Controller
    {
        private readonly AppDbContext context;
        public HomePageController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var res = context.Crafts.ToList();
            return View(res);
        }
    }
}
