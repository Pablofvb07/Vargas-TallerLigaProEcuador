using Microsoft.AspNetCore.Mvc;
using Vargas_TallerLigaProEcuador.Models;

namespace Vargas_TallerLigaProEcuador.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo()
            {
                Id = 1,
                NombreEquipo="Ldu",
                PartidosJugados=10,
                PartidosGanados=10,
                PartidosEmpatados=0,
                PartidosPerdidos=0,
            };
            equipos.Add(ldu);
            Equipo bsc = new Equipo()
            {
                Id = 2,
                NombreEquipo = "Bsc",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 1,
                PartidosPerdidos = 8,
            };
            equipos.Add(bsc);

            return View(equipos);
        }
    }
}
