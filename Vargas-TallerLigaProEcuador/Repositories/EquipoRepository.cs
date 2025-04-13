using Vargas_TallerLigaProEcuador.Interfaces;
using Vargas_TallerLigaProEcuador.Models;

namespace Vargas_TallerLigaProEcuador.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        public bool ActualizarEquipo()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.Where(item => item.Id== Id).First();
            return equipo;
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo()
            {
                Id = 1,
                NombreEquipo = "Ldu",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
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

            return equipos;
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }
}
