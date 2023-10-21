using System.ComponentModel.DataAnnotations;

namespace chubbExamen.Models
{
    public class tbl_Direccion
    {
        [Key]
        public int IdDireccion { get; set; }
        [Required]
        public string Calle { get; set; }
        public string? NoInterior { get; set; }
        public string? NoExterior { get; set; }
        public int IdColonia { get; set; }

        public tbl_Colonia Colonia { get; set; }

        //public ICollection<tbl_Persona> Personas { get; set; }
        public bool status { get; set; } = true;

    }
}
