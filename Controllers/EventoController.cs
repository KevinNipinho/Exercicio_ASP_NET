using Microsoft.AspNetCore.Mvc;

namespace ExercicioASP.NET.Controllers
{
    public class EventoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] 
        public IActionResult Criar()
        {
            return View();
        }

        

    }
}