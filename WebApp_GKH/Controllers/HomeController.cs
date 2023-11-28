using Microsoft.AspNetCore.Mvc;

namespace WebApp_GKH.Controllers
{ 
        public class HomeController : Controller
        {
        public HomeController()
        {
            
        }
        
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
