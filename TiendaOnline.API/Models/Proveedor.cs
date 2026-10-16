
using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.API.Models
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }

        public string Nombre { get; set; } = "";

        public string? Telefono { get; set; }
    }
}

