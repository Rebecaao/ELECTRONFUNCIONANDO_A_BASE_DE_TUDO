using Microsoft.AspNetCore.Mvc;

namespace voltandoClasseStartup.Controllers
{
    public class CaixaMasterController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}