using Vargas_TallerLigaProEcuador.Models;

namespace Vargas_TallerLigaProEcuador.Interfaces
{
    public interface IEquipoRepository
    {

        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveInfoEquipo(int Id);
        bool CrearEquipo();
        bool ActualizarEquipo(Equipo equipo);
        bool EliminarEquipo();

    }
}
