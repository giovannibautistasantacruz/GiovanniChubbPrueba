using System.ComponentModel.DataAnnotations;

namespace chubbExamen.Models.DTO
{
    public class direccionDTO
    {
        [Key]
        public int IdDireccion { get; set; }
        [Required]
        public string Calle { get; set; }
        public string? NoInterior { get; set; }
        public string? NoExterior { get; set; }
        public int IdColonia { get; set; }

    }
}
