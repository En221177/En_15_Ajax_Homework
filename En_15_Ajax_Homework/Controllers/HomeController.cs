using En_15_Ajax_Homework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace En_15_Ajax_Homework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DemoContext _context;
        public HomeController(ILogger<HomeController> logger, DemoContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult register()
        {
            return View();
        }

        public IActionResult check(string name)
        {
            Member a = _context.Members.FirstOrDefault(x => x.Name.Contains(name));
            if (a != null)
                return Content($"{name}已經存在", "text/plane", Encoding.UTF8);
            else 
                return Content($"OK", "text/plane", Encoding.UTF8);
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