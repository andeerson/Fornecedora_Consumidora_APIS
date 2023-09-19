using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCshsrp.Models;

namespace WebApiCshsrp.Controllers
{
   // [Authorize]
    public class VeiculosController : ApiController
    {
        public static List<Veiculos> listaVeiculos = new List<Veiculos>();

        [HttpGet]
        [Route("api/veiculos/popular")]
        public JObject Popular()
        {
            listaVeiculos.Add(new Veiculos(1, "FORD FIESTA", "1.0 MPI PERSONNALITÉ SEDAN 4P", 2005, 2005,
                "Preto", 2, false, 25000, true));

            listaVeiculos.Add(new Veiculos(3, "FORD Fumaça", "4.0 Turbo 4P", 1980, 1980,
               "Rosa", 2, false, 10000, true));

            listaVeiculos.Add(new Veiculos(2, "FIAT", "1.0 MPI UNO 4P", 2015, 2015,
                "AMARELO", 1, false, 40000, true));

            listaVeiculos.Add(new Veiculos(6, "HYUNDAY HB20", "1.0 MPI CONFORT 12 V FLEX 4P", 2017, 2017,
                "AZUL", 3, false, 43000, true));

            listaVeiculos.Add(new Veiculos(12, "CHEVROLE PRIMA", "1.4 MPFI 8 VALVULAS FLEX 4P", 2005, 2005,
                "Preto", 2, false, 25000, true));

            listaVeiculos.Add(new Veiculos(4, "Mitsubischi", "Eclipse 2P", 2015, 2015,
               "Branco", 2, false, 100000, true));


            listaVeiculos.Add(new Veiculos(5, "Hiunday", "Jupter 4P", 2021, 2022,
               "Vermelho", 1, true, 99000, true));

            var resultado = JObject.Parse("{resultado: \"populado\"}");
            return resultado;

        }


        // GET api/veiculos
      
        public List<Veiculos> Get()
        {
            return listaVeiculos;

        }

        // GET api/veiculos/5
        public Veiculos Get(int id)
        {
            return listaVeiculos.Find(x => x.Id.Equals(id));

        }

        // POST api/veiculos
        public void Post([FromBody]string value)
        {
        }

        // PUT api/veiculos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpGet]
        [Route("api/veiculos/excluir/{id}")]
        public JObject Excluir(int id)
        {
            var veiculos = listaVeiculos.Single(x => x.Id.Equals(id));
            listaVeiculos.Remove(veiculos);

            var resultado = JObject.Parse("{resultado: \"OK\"}");
            return resultado;


        }
    }
}
