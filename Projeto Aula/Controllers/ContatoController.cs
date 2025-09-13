using Microsoft.AspNetCore.Mvc;

namespace Projeto_Aula.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
