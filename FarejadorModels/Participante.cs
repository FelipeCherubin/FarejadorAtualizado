using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarejadorModels
{
    [Table("Participante")]
    public class Participante
    {
        public Participante()
        {
            Armazenamento = new List<ArmazenamentoXML>();
            CertificadoDigital = new List<CertificadoDigital>();
            JobDownload = new List<JobDownload>();
            Remoto = new List<Remoto>();
        }

        [Key, StringLength(14)]
        public string cd_CPF_CNPJ { get; set; }

        [StringLength(100)]
        public string nm_RazaoSocial { get; set; }

        [StringLength(100)]
        public string nm_NomeFantasia { get; set; }

        [StringLength(14)]
        public string nm_InscricaoEstadual { get; set; }

        [StringLength(20)]
        public string nm_InscricaoMunicipal { get; set; }


        public int nm_CnaePrincipal { get; set; }

        [EmailAddress]
        public string nm_Email { get; set; }


        public string nr_DDD { get; set; }

        public string nr_Telefone { get; set; }

        [StringLength(60)]
        public string nm_Logradouro { get; set; }


        public int nr_nLogradouro { get; set; }

        [StringLength(60)]
        public string nm_Bairro { get; set; }

        [StringLength(60)]
        public string nm_Complemento { get; set; }

        [ForeignKey("Municipio")]
        public int idMunicipio { get; set; }

        public virtual Municipio Municipio { get; set; }

        public virtual List<ArmazenamentoXML> Armazenamento { get; set; }

        public virtual List<CertificadoDigital> CertificadoDigital { get; set; }

        public virtual List<JobDownload> JobDownload { get; set; }

        public virtual List<Remoto> Remoto { get; set; }
    }
}
