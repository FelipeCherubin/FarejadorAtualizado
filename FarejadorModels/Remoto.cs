using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarejadorModels
{
    [Table("Remoto")]
    public class Remoto
    {
        [Key]
        public int cd_Remoto { get; set; }

        [Required, StringLength(8)]
        public string nr_Senha { get; set; }

        [ForeignKey("Participante")]
        public string id_CPF_CNPJ { get; set; }

        public virtual Participante Participante { get; set; }
    }
}
