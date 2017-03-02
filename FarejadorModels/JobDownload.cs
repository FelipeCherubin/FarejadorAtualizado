using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarejadorModels
{
    [Table("JobDownload")]
    public class JobDownload
    {
        [Key]
        public int cd_job { get; set; }

        public DateTime hr_horExec { get; set; }


        [ForeignKey("Participante")]
        public string id_CPF_CNPJ { get; set; }

        public virtual Participante Participante { get; set; }


        [ForeignKey("CertificadoA1")]
        public int id_CertificadoA1 { get; set; }

        public virtual CertificadoA1  CertificadoA1 { get; set; }
    }
}
