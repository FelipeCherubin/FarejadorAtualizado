using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarejadorModels
{
    [Table("Municipio")]
    public class Municipio
    {
        public Municipio()
        {
            Participante = new List<Participante>();
        }
        [Key]
        public int cd_Municipio { get; set; }

        [StringLength(100)]
        public string nm_Municipio { get; set; }

        [StringLength(2)]
        public string sg_UF { get; set; }

        public virtual List<Participante> Participante { get; set; }
    }
}
