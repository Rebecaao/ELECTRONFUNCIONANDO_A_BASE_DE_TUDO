using Microsoft.AspNetCore.Mvc;

namespace voltandoClasseStartup.Controllers
{
    public class PalletController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}