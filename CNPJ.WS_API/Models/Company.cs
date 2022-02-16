using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CNPJ.WS_API.Models
{
    public class Company
    {
        [JsonPropertyName("cnpj")]
        public string CNPJ { get; set; }
        [JsonPropertyName("cnpj_raiz")]
        public string CNPJRoot { get; set; }
        [JsonPropertyName("cnpj_ordem")]
        public string CNPJOrder { get; set; }
        [JsonPropertyName("cnpj_digito_verificador")]
        public string CNPJCheckDigit { get; set; }
        [JsonPropertyName("tipo")]
        public string Type { get; set; }
        [JsonPropertyName("nome_fantasia")]
        public string SocialName { get; set; }
        [JsonPropertyName("situacao_cadastral")]
        public string CadastralStatus { get; set; }
        [JsonPropertyName("data_situacao_cadastral")]
        public string CadastralStatusDate { get; set; }
        [JsonPropertyName("data_inicio_atividade")]
        public string StartActivitiesDate { get; set; }
        [JsonPropertyName("nome_cidade_exterior")]
        public string OverseasCityName { get; set; }
        [JsonPropertyName("pais")]
        public Country Country { get; set; }
        [JsonPropertyName("estado")]
        public State State { get; set; }
        [JsonPropertyName("cidade")]
        public City City { get; set; }
        [JsonPropertyName("tipo_logradouro")]
        public string StreetType { get; set; }
        [JsonPropertyName("logradouro")]
        public string Street { get; set; }
        [JsonPropertyName("numero")]
        public string Number { get; set; }
        [JsonPropertyName("complemento")]
        public string Complement { get; set; }
        [JsonPropertyName("bairro")]
        public string District { get; set; }
        [JsonPropertyName("cep")]
        public string CEP { get; set; }
        [JsonPropertyName("ddd1")]
        public string DDD1 { get; set; }
        [JsonPropertyName("telefone1")]
        public string Telephone1 { get; set; }
        [JsonPropertyName("ddd2")]
        public string DDD2 { get; set; }
        [JsonPropertyName("telefone2")]
        public string Telephone2 { get; set; }
        [JsonPropertyName("ddd_fax")]
        public string FaxDDD { get; set; }
        [JsonPropertyName("fax")]
        public string Fax { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("situacao_especial")]
        public string SpecialSituation { get; set; }
        [JsonPropertyName("data_situacao_especial")]
        public string SpecialSituationDate { get; set; }
        [JsonPropertyName("atividade_principal")]
        public Activity MainActivity { get; set; }
        [JsonPropertyName("atividades_secundarias")]
        public Activity[] SecondaryActivities { get; set; }
        [JsonPropertyName("motivo_situacao_cadastral")]
        public RegistrationStatus ReasonForRegistrationStatus { get; set; }
        [JsonPropertyName("inscricoes_estaduais")]
        public StateRegistration[] StateRegistrations { get; set; }
        [JsonPropertyName("atualizado_em")]
        public string Updated { get; set; }

        //public string Cnpj { get; set; }
        //public string Cnpj_raiz { get; set; }
        //public string Cnpj_ordem { get; set; }
        //public string Cnpj_digito_verificador { get; set; }
        //public string Tipo { get; set; }
        //public string Nome_fantasia { get; set; }
        //public string Situacao_cadastral { get; set; }
        //public string Data_situacao_cadastral { get; set; }
        //public string Data_inicio_atividade { get; set; }
        //public string Nome_cidade_exterior { get; set; }
        //public Country Pais { get; set; }
        //public State Estado { get; set; }
        //public City Cidade { get; set; }
        //public string Tipo_logradouro { get; set; }
        //public string Logradouro { get; set; }
        //public string Numero { get; set; }
        //public string complemento { get; set; }
        //public string Bairro { get; set; }
        //public string Cep { get; set; }
        //public string Ddd1 { get; set; }
        //public string Telefone1 { get; set; }
        //public string Ddd2 { get; set; }
        //public string Telefone2 { get; set; }
        //public string Ddd_fax { get; set; }
        //public string Fax { get; set; }
        //public string Email { get; set; }
        //public string Situacao_especial { get; set; }
        //public string Data_situacao_especial { get; set; }
        //public Activity Atividade_principal { get; set; }
        //public Activity[] Atividades_secundarias { get; set; }
        //public RegistrationStatus Motivo_situacao_cadastral { get; set; }
        //public StateRegistration[] Inscricoes_estaduais { get; set; }
        //public string Atualizado_em { get; set; }
    }
}
