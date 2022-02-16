using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CNPJ.WS_API.Models
{
    public class CNPJ_WS
    {
        [JsonPropertyName("cnpj_raiz")]
        public string CNPJRoot { get; set; }
        [JsonPropertyName("razao_social")]
        public string LegalName { get; set; }
        [JsonPropertyName("capital_social")]
        public string ShareCapital { get; set; }
        [JsonPropertyName("responsavel_federativo")]
        public string ResponsibleFederative { get; set; }
        [JsonPropertyName("atualizado_em")]
        public string Updated { get; set; }
        [JsonPropertyName("porte")]
        public Size Size { get; set; }
        [JsonPropertyName("natureza_juridica")]
        public LegalNature LegalNature { get; set; }
        [JsonPropertyName("qualificacao_do_responsavel")]
        public Qualification AccountableQualification { get; set; }
        [JsonPropertyName("socios")]
        public Partner[] Partners { get; set; }
        [JsonPropertyName("simples")]
        public SimpleMEI SimpleMEI { get; set; }
        [JsonPropertyName("estabelecimento")]
        public Company Company { get; set; }

        //public string Cnpj_raiz { get; set; }
        //public string Razao_social { get; set; }
        //public string Capital_social { get; set; }
        //public string Responsavel_federativo { get; set; }
        //public string Atualizado_em { get; set; }
        //public Size Porte { get; set; }
        //public LegalNature Natureza_juridica { get; set; }
        //public Qualification Qualificacao_do_responsavel { get; set; }
        //public Partner[] Socios { get; set; }
        //public SimpleMEI Simples { get; set; }
        //public Company Estabelecimento { get; set; }
    }
}
