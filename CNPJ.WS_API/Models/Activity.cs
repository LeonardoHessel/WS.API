using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CNPJ.WS_API.Models
{
    public class Activity
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("secao")]
        public string Section { get; set; }
        [JsonPropertyName("divisao")]
        public string Division { get; set; }
        [JsonPropertyName("grupo")]
        public string Group { get; set; }
        [JsonPropertyName("classe")]
        public string Class { get; set; }
        [JsonPropertyName("subclasse")]
        public string Subclass { get; set; }
        [JsonPropertyName("descricao")]
        public string Description { get; set; }

        //public string Id { get; set; }
        //public string Secao { get; set; }
        //public string Divisao { get; set; }
        //public string Grupo { get; set; }
        //public string Classe { get; set; }
        //public string Subclasse { get; set; }
        //public string Descricao { get; set; }
    }
}
