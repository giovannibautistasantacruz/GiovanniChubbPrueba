using System.ComponentModel.DataAnnotations;

namespace chubbExamen.Models.DTO
{
    public class personaDTO
    {
        public int IdPersona { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apaterno { get; set; }
        public string? Amaterno { get; set; }
        [Required]
        [Phone]
        public string Telefono { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Direccion { get; set; }
        //public int IdDireccion { get; set; }
        //public direccionDTO Direccion { get; set; }
    }
}
