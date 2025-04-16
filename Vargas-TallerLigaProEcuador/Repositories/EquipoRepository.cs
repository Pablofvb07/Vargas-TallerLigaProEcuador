using Vargas_TallerLigaProEcuador.Interfaces;
using Vargas_TallerLigaProEcuador.Models;

namespace Vargas_TallerLigaProEcuador.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        private static List<Equipo> equipos = new List<Equipo>
    {
        new Equipo
        {
            Id = 1,
            NombreEquipo = "Ldu",
            PartidosJugados = 10,
            PartidosGanados = 10,
            PartidosEmpatados = 0,
            PartidosPerdidos = 0,
            ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/5/50/LOGOS_5TA._ESTRELLA_I.png",
            Descripcion = "Liga Deportiva Universitaria es uno de los equipos más grandes de Ecuador, Vigente campeón de la liga pro."
        },
        new Equipo
        {
            Id = 2,
            NombreEquipo = "Bsc",
            PartidosJugados = 10,
            PartidosGanados = 1,
            PartidosEmpatados = 1,
            PartidosPerdidos = 8,
            ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6a/Barcelona_Sporting_Club_Logo.png",
            Descripcion = "Barcelona SC es uno de los clubes más populares del país."

        }
    };

        public bool ActualizarEquipo(Equipo equipo)

        {
            /*LINEAS DE CODIGO GENERADAS POR CHATGPT*/
            var equipoExistente = equipos.FirstOrDefault(e => e.Id == equipo.Id);
            if (equipoExistente != null)
            {
                equipoExistente.NombreEquipo = equipo.NombreEquipo;
                equipoExistente.PartidosJugados = equipo.PartidosJugados;
                equipoExistente.PartidosGanados = equipo.PartidosGanados;
                equipoExistente.PartidosEmpatados = equipo.PartidosEmpatados;
                equipoExistente.PartidosPerdidos = equipo.PartidosPerdidos;
                equipoExistente.ImagenUrl = equipo.ImagenUrl;
                equipoExistente.Descripcion = equipo.Descripcion;

                return true;
            }
            return false;
        }

        public List<Equipo> DevuelveListadoEquipos() => equipos;

        public Equipo DevuelveInfoEquipo(int id) => equipos.FirstOrDefault(e => e.Id == id);

        public bool CrearEquipo() => throw new NotImplementedException();

        public bool EliminarEquipo() => throw new NotImplementedException();
    }

}
