using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CNPJ.WS_API.Models
{
    public class SimpleMEI
    {
        [JsonPropertyName("simples")]
        public string Simple { get; set; }
        [JsonPropertyName("data_opcao_simples")]
        public string SimpleOptionDate { get; set; }
        [JsonPropertyName("data_exclusao_Simples")]
        public string SimpleExclusionDate { get; set; }
        [JsonPropertyName("mei")]
        public string MEI { get; set; }
        [JsonPropertyName("data_opcao_mei")]
        public string MEIOptionDate { get; set; }
        [JsonPropertyName("data_exclusao_mei")]
        public string MEIExclusionDate { get; set; }
        [JsonPropertyName("atualizado_em")]
        public string Updated { get; set; }

        //public string Simples { get; set; }
        //public string Data_opcao_simples { get; set; }
        //public string Data_exclusao_simples { get; set; }
        //public string Mei { get; set; }
        //public string Data_opcao_mei { get; set; }
        //public string Data_exclusao_mei { get; set; }
        //public string Atualizado_em { get; set; }
    }
}
