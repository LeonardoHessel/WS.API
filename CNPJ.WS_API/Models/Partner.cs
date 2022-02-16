using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CNPJ.WS_API.Models
{
    public class Partner
    {
        [JsonPropertyName("cpf_cnpj_socio")]
        public string Document { get; set; }
        [JsonPropertyName("nome")]
        public string Name { get; set; }
        [JsonPropertyName("tipo")]
        public string Type { get; set; }
        [JsonPropertyName("data_entrada")]
        public string EntryDate { get; set; }
        [JsonPropertyName("cpf_representante_legal")]
        public string LegalRepresentativeDocument { get; set; }
        [JsonPropertyName("nome_representante")]
        public string RepresentativeName { get; set; }
        [JsonPropertyName("faixa_etaria")]
        public string AgeGroup { get; set; }
        [JsonPropertyName("atualizado_em")]
        public string Updated { get; set; }
        [JsonPropertyName("pais_id")]
        public string Country { get; set; }
        [JsonPropertyName("qualificacao_socio")]
        public Qualification Qualification { get; set; }
        [JsonPropertyName("qualificacao_representante")]
        public Qualification RepresentativeQualification { get; set; }

        //public string Cpf_cnpj_socio { get; set; }
        //public string Nome { get; set; }
        //public string Tipo { get; set; }
        //public string Data_entrada { get; set; }
        //public string Cpf_representante_legal { get; set; }
        //public string Nome_representante { get; set; }
        //public string Faixa_etaria { get; set; }
        //public string Atualizado_em { get; set; }
        //public string Pais_id { get; set; }
        //public Qualification Qualificacao_socio { get; set; }
        //public Qualification Qualificaca0_representante { get; set; }
    }
}
