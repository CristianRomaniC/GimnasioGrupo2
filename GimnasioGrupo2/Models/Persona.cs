using System.ComponentModel.DataAnnotations;

namespace GimnasioGrupo2.Models
{
    public class Persona
    {
        [Key]
        public int Dni { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(50)]
        public string Apellido { get; set; }
        [StringLength(50)]
        public string Telefono { get; set; }
        [StringLength(50)]
        public DateTime FechaNacimiento { get; set; }
    }
}
