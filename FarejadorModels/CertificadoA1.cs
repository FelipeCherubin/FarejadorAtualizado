using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarejadorModels
{
    [Table("CertificadoA1")]
    public class CertificadoA1
    {

        public CertificadoA1()
        {
            JobDownload = new List<JobDownload>();
        }
        [Key]
        public int cd_certificado { get; set; }

        [StringLength(256)]
        public string nm_CaminhoServidor { get; set; }

        [StringLength(8)]
        public string nm_Senha { get; set; }

        [ForeignKey("CertificadoDigital")]
        public string id_ThumbPrint { get; set; }

        public virtual CertificadoDigital CertificadoDigital { get; set; }

        public virtual List<JobDownload> JobDownload { get; set; }
    }
}
