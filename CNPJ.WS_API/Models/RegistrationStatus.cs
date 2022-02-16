using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CNPJ.WS_API.Models
{
    public class RegistrationStatus
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("descricao")]
        public string Description { get; set; }

        //public string Id { get; set; }
        //public string Descricao { get; set; }
    }
}
