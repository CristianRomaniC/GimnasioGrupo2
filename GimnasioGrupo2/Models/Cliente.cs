namespace GimnasioGrupo2.Models
{
    public class Cliente : Persona
    // Hereda de la clase Persona
    {
        public string id { get; set; }
        public bool Habilitado { get; set; }

        public bool MembresiaVigente { get; set; }

        public string Objetivo { get; set; }

        //Relaciones

        // Relación 1 a 1 con Rutina
        public int RutinaId { get; set; }
        public Rutina Rutina { get; set; }
    }
}
