using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Controllers
{
    [Produces("application/json")]
    [Route("api/")]
    public class TesteController : Controller
    {
        // GET: api/Teste/5
        [HttpGet("calculajuros")]
        public string GetCalculaJuros(double valorinicial,int meses)
        {
            return Math.Pow(valorinicial*(1.01), meses).ToString();
        }

        //ShowMeTheCode
        [HttpGet("showmethecode")]
        public string ShowMeTheCode()
        {
            return "value";
        }
    }
}
