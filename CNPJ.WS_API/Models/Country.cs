using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CNPJ.WS_API.Models
{
    public class Country
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("iso2")]
        public string ISO2 { get; set; }
        [JsonPropertyName("iso3")]
        public string ISO3 { get; set; }
        [JsonPropertyName("nome")]
        public string Name { get; set; }
        [JsonPropertyName("comex_id")]
        public string ComexId { get; set; }

        //public string Id { get; set; }
        //public string Iso2 { get; set; }
        //public string Iso3 { get; set; }
        //public string Nome { get; set; }
        //public string Comex_id { get; set; }
    }
}
