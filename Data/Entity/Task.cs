using System.ComponentModel.DataAnnotations;

namespace task_manager.Data.Entity
{
    public class Task
    {
        public int Id { get; set; }
        [Display(Name = "Título")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caráteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? Title { get; set; }
        [Display(Name = "Descripción")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caráteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        [Display(Name = "Fecha de Vencimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime ExpirationDate { get; set; }
        [Display(Name = "Tarea completada")]
        public bool Completed { get; set; }

        public User? User { get; set;}
    }
}