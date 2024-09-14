using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El titulo es obligatorio" )]
        [StringLength(50, ErrorMessage = "El titulo no puede tener mas de 50 caracteres")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El autor es obligatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(0.01, 999.99, ErrorMessage = "El precio debe estar entre 0.01 y 999.99")]
        public decimal Precio { get; set; }
    }
}
