using RestSharp;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ApiConsumirCsharp
{
   public  class Veiculos
    {
        private static string _urlBase = "http://localhost:58749/";

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public short Ano { get; set; }
        public short Fabricacao { get; set; }
        public string Cor { get; set; }
        public byte Combustivel { get; set; }
        public bool Automatico { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }

        public static List<Veiculos> GetVeiculos()      
        {
            var listaVeiculos = new List<Veiculos>();

            var Client = new RestClient(_urlBase + "api/Veiculos");
            var request = new RestRequest( Method.GET);

           IRestResponse response = Client.Execute(request);


            if(response.StatusCode == HttpStatusCode.OK)
            {
                listaVeiculos = JsonConvert.DeserializeObject<List<Veiculos>>(response.Content);

            }
            return listaVeiculos;

        }





        public Veiculos GetVeiculo(int id)
        {
            var Veiculo = new Veiculos();

            var Client = new RestClient(_urlBase + "api/Veiculos/" + id);
            var request = new RestRequest(Method.GET);

            IRestResponse response = Client.Execute(request);


            if (response.StatusCode == HttpStatusCode.OK)
            {
                Veiculo = JsonConvert.DeserializeObject<Veiculos>(response.Content);

            }
            return Veiculo;

        }








    }
}
