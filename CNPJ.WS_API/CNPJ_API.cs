using CNPJ.WS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CNPJ.WS_API
{
    public class CNPJ_API
    {
        public static HttpClient Client { get; set; }

        public static void InitializeClient()
        {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Clear();
            //Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
        }

        public static async Task<object> QueryAsync(string cnpj, string token = null)
        {
            string url = "";
            if (token == null)
            {
                url = $"https://publica.cnpj.ws/cnpj/{cnpj}";
            }
            else
            {
                url = $"https://comercial.cnpj.ws/cnpj/{cnpj}?token={token}";
            }

            var streamTask = Client.GetStreamAsync(url);
            var cnpj_ws = await JsonSerializer.DeserializeAsync<CNPJ_WS>(await streamTask);

            return cnpj_ws;

            //using (HttpResponseMessage response = await Client.GetAsync(url))
            //{
            //    if (response.IsSuccessStatusCode)
            //    {
            //        CNPJ_WS cnpj_ws = await response.Content.ReadAsAsync<CNPJ_WS>();
            //        return cnpj_ws;
            //    }
            //    else
            //    {
            //        throw new Exception(response.ReasonPhrase);
            //    }
            //}
        }
    }
}
