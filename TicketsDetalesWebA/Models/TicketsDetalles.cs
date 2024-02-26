using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TicketsDetalesWebA.Models
{
    public class TicketsDetalles
    {
        [Key]
        public int DetalleId { get; set; }

        [ForeignKey("TicketId")]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [StringLength(35, ErrorMessage = "El Emisor es demasiado largo. Excede los {0} caracteres")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "El campo Emisor solo debe de contener caracteres alfabeticos")]
        public string Emisor { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Mensaje es obligatorio")]
        [StringLength(75, ErrorMessage = "Ha insertado mas de {0} caracteres")]
        public string Mensaje { get; set; } = string.Empty;

    }
}
