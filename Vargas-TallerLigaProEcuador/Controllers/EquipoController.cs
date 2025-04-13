using Microsoft.AspNetCore.Mvc;

namespace Vargas_TallerLigaProEcuador.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            return View();
        }
    }
}
