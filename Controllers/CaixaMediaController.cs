using Microsoft.AspNetCore.Mvc;

namespace voltandoClasseStartup.Controllers
{
    public class CaixaMediaController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}