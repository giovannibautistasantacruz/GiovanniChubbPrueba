using System.ComponentModel.DataAnnotations;

namespace chubbExamen.Models
{
    public class tbl_Colonia
    {
        [Key]
        public int IdColonia { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string CP { get; set; }
        public int IdMunicipio { get; set; }

        public tbl_Municipio Municipio { get; set; }
        public ICollection<tbl_Direccion> Direcciones { get; set; }
        public bool status { get; set; } = true;

    }
}
