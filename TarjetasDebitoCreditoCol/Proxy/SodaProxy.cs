using Microsoft.AspNetCore.Mvc;
using SODA;
using System;
using MoreLinq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TarjetasDebitoCreditoCol.Models;
using MoreLinq.Extensions;

namespace TarjetasDebitoCreditoCol.Proxy
{
    public class SodaProxy : IDisposable
    {
        private SodaClient client { get; set; }
        private const string ID_DATASET = "h2jg-r3zg";        
        private const string URL_PORTAL = "datos.gov.co";
        private const string APP_TOKEN = "veLMt6wVQ4EU4s7llyWtjeHbD";//sirve para las casas
        //private const string APP_TOKEN = "nmhMLihEKnCV2dxi8AaZ3l6um";        
        private const string USUARIO = "mdariogallardo@gmail.com";
        private const string CLAVE = "F66zASd7hp.9H*5";

        public SodaProxy()
        {
            client = new SodaClient(URL_PORTAL, APP_TOKEN, USUARIO, CLAVE);
        }
        public void Dispose()
        {
            if (client != null)
                client = null;
        }

        public IEnumerable<Operacion> GetOperaciones()
        {
            var dataset = client.GetResource<Operacion>(ID_DATASET);
            return dataset.GetRows(limit: 5000);
        }

        //[HttpGet]
        public IEnumerable<Operacion> GetOperacionesXCodEntidad()
        {
            string[] columns = new[] { "tipoentidad", "codigoentidad", "nombreentidad" };

            var dataset = client.GetResource<Operacion>(ID_DATASET);

            //var filtro = from n in dataset.GetRows()
            //             where n.CodigoEntidad == 2
            //             select n;

            var distinctEntidades = from e in dataset.GetRows().Take(4)
                                    orderby e.CodigoEntidad descending
                                    
                                    select e;
                




            return distinctEntidades;

        }
    }
}
