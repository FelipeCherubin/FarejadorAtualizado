using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarejadorModels
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key, StringLength(14)]
        public string cd_CPF_CNPJ { get; set; }

        [StringLength(100)]
        public string nm_Razao { get; set; }

        [StringLength(8)]
        public string nm_Senha { get; set; }

        [EmailAddress]
        public string nm_Email { get; set; }

        public string nr_DDD { get; set; }

        public string nr_Telefone { get; set; }

        public DateTime dt_Cadastro { get; set; }

        public Int16 nr_CadastroGratis { get; set; }

        public Int16 nr_CadastroBloqueado { get; set; }
    }
}
