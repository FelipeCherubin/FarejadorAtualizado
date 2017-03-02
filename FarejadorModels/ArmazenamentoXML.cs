using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarejadorModels
{
    [Table("ArmazenamentoXML")]
    public class ArmazenamentoXML
    {
        [Key, StringLength(44)]
        public string cd_Chave { get; set; }

        public Int16 nr_Modelo { get; set; }

        [StringLength(14)]
        public string nm_CNPJEmit { get; set; }

        [StringLength(60)]
        public string nm_NomeEmit { get; set; }

        [StringLength(14)]
        public string nm_IEEmit { get; set; }

        public DateTime dt_dhEmi { get; set; }

        public Int16 nr_Tipo { get; set; }

        public decimal nr_valorDoc { get; set; }

        public DateTime dt_dhRecbto { get; set; }

        [StringLength(15)]
        public string nm_digVal { get; set; }

        [StringLength(28)]
        public string nm_nProt { get; set; }

        [StringLength(7000)]
        public string nm_xmlCompactado { get; set; }

        [ForeignKey("Participante")]
        public string id_CPF_CNPJ { get; set; }

        public virtual Participante Participante { get; set; }
    }
}
