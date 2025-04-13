using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vargas_TallerLigaProEcuador.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [DisplayName("Nombre de Equipo")]
        [Required]
        public string NombreEquipo
        { get; set; }
        [Range(0, 20)]
        public int PartidosJugados { get; set; }
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 20)]
        public int Puntos
        {
            get
            {
                int puntos = PartidosGanados*3 + PartidosEmpatados*1;
                return puntos;
            }
        }

    }
}
