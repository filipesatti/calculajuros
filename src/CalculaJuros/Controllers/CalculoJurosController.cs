using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using CalculadorJuros.Services;

namespace CalculadorJuros.Controllers
{
    [Produces("application/json")]
    [Route("api/")]
    public class CalculoJurosController : Controller
    {
        // GET: api/Teste/5
        [HttpGet("calculajuros")]
        public string GetCalculaJuros(decimal valorinicial,int meses)
        {
            return JurosService.CalculaJuros(valorinicial,meses).ToString("C", CultureInfo.CurrentCulture);
        }

        //ShowMeTheCode
        [HttpGet("showmethecode")]
        public string ShowMeTheCode()
        {
            return @"https://github.com/filipesatti/calculajuros.git";
        }
    }
}
