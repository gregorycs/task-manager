using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using task_manager.Enums;

namespace task_manager.Data.Entity
{
    public class User : IdentityUser
    {
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caráteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? FirstName { get; set; }
        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caráteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? LastName { get; set; }
        [Display(Name = "Tipo de usuario")]
        public UserType  UserType { get; set; }
        [Display(Name = "Usuario")]
        public string FullName => $"{FirstName} {LastName}";

        public ICollection<Task> Task { get; set;}
    }
}