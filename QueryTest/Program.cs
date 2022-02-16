using CNPJ.WS_API;
using CNPJ.WS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            CNPJ_API.InitializeClient();
            Console.WriteLine("Insira o cnpj da consulta? (somente numeros)");
            string cnpjNumber = Console.ReadLine();
            await Load(cnpjNumber);
            Console.ReadKey();
        }

        private static async Task Load(string cnpjNumber)
        {
            CNPJ_WS cnpj_ws = await CNPJ_API.QueryAsync(cnpjNumber) as CNPJ_WS;
        }
    }
}
