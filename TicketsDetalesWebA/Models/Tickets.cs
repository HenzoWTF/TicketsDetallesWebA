using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TicketsDetalesWebA.Models
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "Debe de insertar una Fecha")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El campo Solicitado Por es obligatorio")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "El campo SolicitadoPor solo debe de contener caracteres alfabeticos")]
        public string SolicitadoPor { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Asunto es obligatorio")]
        public string Asunto { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Descripcion es obligatorio")]
        public string Descripcion { get; set; } = string.Empty;

        [ForeignKey("TicketId")]
        public ICollection<TicketsDetalles> TicketsDetalle { get; set; } = new List<TicketsDetalles>();

    }
}
