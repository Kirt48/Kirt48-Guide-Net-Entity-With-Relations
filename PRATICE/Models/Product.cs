using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace PRATICE.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Precio unitario")]
        public float UnitPrice { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Cantidad")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Estado")]
        public int Status { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Fecha de vencimiento")]
        public DateTime DueDate { get; set; }

        [ForeignKey("ProviderId")]
        public Guid ProviderId { get; set; }

        public virtual Provider? Provider { get; set; }
    }
}