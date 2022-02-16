using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CNPJ.WS_API.Models
{
    public class StateRegistration
    {
        [JsonPropertyName("inscricao_estadual")]
        public string Number { get; set; }
        [JsonPropertyName("ativo")]
        public bool Active { get; set; }
        [JsonPropertyName("atualizado_em")]
        public string Updated { get; set; }
        [JsonPropertyName("estado")]
        public State State { get; set; }

        //public string Incricao_estadual { get; set; }
        //public string Atualizado_em { get; set; }
        //public bool Ativo { get; set; }
        //public State Estado { get; set; }
    }
}
