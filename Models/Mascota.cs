using System.ComponentModel.DataAnnotations;

namespace TuApp.Models
{
    public class Mascota
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La especie es obligatoria.")]
        public string Especie { get; set; }

        public string Raza { get; set; }

        [Range(0, 100, ErrorMessage = "Edad inválida.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El nombre del dueño es obligatorio.")]
        public string Dueno { get; set; }
    }
}
