using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarejadorModels
{
    [Table("CertificadoDigital")]
    public class CertificadoDigital
    {
        public CertificadoDigital()
        {
            CertificadoA1 = new List<CertificadoA1>();
        }
        [Key, StringLength(40)]
        public string cd_ThumpPrint { get; set; }

        [StringLength(100)]
        public string nm_FriendlyName { get; set; }

        [StringLength(300)]
        public string nm_SubjectName { get; set; }

        [StringLength(100)]
        public string nm_IssuerName { get; set; }

        public DateTime dt_DtInicial { get; set; }

        public DateTime dt_DtFinal { get; set; }

        [ForeignKey("Participante")]
        public string id_CPF_CNPJ { get; set; }

        public virtual Participante Participante { get; set; }

        public virtual List<CertificadoA1> CertificadoA1 { get; set; }
    }
}
