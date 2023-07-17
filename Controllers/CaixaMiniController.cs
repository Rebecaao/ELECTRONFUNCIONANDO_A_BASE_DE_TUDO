using Microsoft.AspNetCore.Mvc;

namespace voltandoClasseStartup.Controllers
{
    public class CaixaMiniController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}