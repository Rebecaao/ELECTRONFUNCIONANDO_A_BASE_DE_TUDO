using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using voltandoClasseStartup.Models;
using voltandoClasseStartup.Data;

namespace voltandoClasseStartup.Controllers;

public class HomeController : Controller
    {
        readonly private ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> crud = _db.Emprestimos;
            return View(crud);
        }
    }

