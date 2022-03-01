using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TarjetasDebitoCreditoCol.Models;
using TarjetasDebitoCreditoCol.Proxy;

namespace TarjetasDebitoCreditoCol.Controllers
{
    public class OperacionesController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                using (SodaProxy client = new SodaProxy())
                    return View(new List<Operacion>(client.GetOperacionesXCodEntidad()));
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return NotFound();

            }
        }
    }
}
