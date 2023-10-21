using Azure;
using System.ComponentModel.DataAnnotations;

namespace chubbExamen.Models
{
    public class tbl_Estado
    {
        [Key]
        public int IdEstado { get; set; }
        [Required]
        public string Nombre { get; set; }
        public ICollection<tbl_Municipio> Municipios { get; set; }

        public bool status { get; set; } = true;

    }
}
