namespace GimnasioGrupo2.Models
{
    public class Rutina
    {
        public int Id { get; set; } //Clave primaria
        public double TiempoEstimado { get; set; }
        public int CantidadEjercicios { get; set; }

        //Relaciones

        public TipoRutina Tipo { get; set; }
    }
}
