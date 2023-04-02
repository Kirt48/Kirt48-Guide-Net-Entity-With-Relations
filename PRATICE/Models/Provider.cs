using System.ComponentModel.DataAnnotations;

namespace PRATICE.Models
{
    public class Provider
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Edad")]
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Product>? Products { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Estado")]
        public int Status { get; set; }
    }
}
