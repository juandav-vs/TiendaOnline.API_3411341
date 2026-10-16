
using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.API.Models
{
    public class MetodoPago
    {
        [Key]
        public int IdMetodoPago { get; set; }

        public string Nombre { get; set; } = "";
    }
}
