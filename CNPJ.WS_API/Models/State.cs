using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CNPJ.WS_API.Models
{
    public class State
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nome")]
        public string Name { get; set; }
        [JsonPropertyName("sigla")]
        public string Initials { get; set; }
        [JsonPropertyName("ibge_id")]
        public int IbgeId { get; set; }

        //public int Id { get; set; }
        //public string Nome { get; set; }
        //public string Sigla { get; set; }
        //public int Ibge_id { get; set; }
    }
}
