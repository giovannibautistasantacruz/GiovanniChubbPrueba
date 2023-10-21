using System.ComponentModel.DataAnnotations;

namespace chubbExamen.Models
{
    public class tbl_Persona
    {
        [Key]
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
        //public int IdDireccion { get; set; }
        //public tbl_Direccion Direccion { get; set; }
        [Required]
        public string Direccion { get; set; }

        public bool status { get; set; } = true;


    }
}
