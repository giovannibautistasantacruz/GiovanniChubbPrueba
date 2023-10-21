using System.ComponentModel.DataAnnotations;

namespace chubbExamen.Models
{
    public class tbl_Municipio
    {
        [Key]
        public int IdMunicipio { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int IdEstado { get; set; }

        public tbl_Estado Estado  { get; set; }

        public ICollection<tbl_Colonia> Colonias { get; set; }
        public bool status { get; set; } = true;

    }
}
