using System.ComponentModel.DataAnnotations;

namespace GimnasioGrupo2.Models
{
    public class Gimnasio
    {        [Key]
        public string id { get; set; }
        public int nombre { get; set; }
        public string direccion { get; set; }
        
        public string telefono { get; set; }
        
        //Relaciones

        public List<Cliente> Clientes { get; set; }

        public List<Rutina> Rutinas { get; set; }
    }
}
