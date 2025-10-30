namespace GimnasioGrupo2.Models
{
    public class Maquina
    {
        public int Id { get; set; } //Clave primaria
        public bool Estado { get; set; }
        public string Nome { get; set; } = string.Empty;
    }
}
