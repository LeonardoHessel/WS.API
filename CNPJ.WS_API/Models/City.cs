using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CNPJ.WS_API.Models
{
    public class City
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nome")]
        public string Name { get; set; }
        [JsonPropertyName("ibge_id")]
        public int IbgeId { get; set; }
        [JsonPropertyName("siafi_id")]
        public string SiafiId { get; set; }

        //public int Id { get; set; }
        //public string Nome { get; set; }
        //public int Ibge_id { get; set; }
        //public string Siafi_id { get; set; }
    }
}
