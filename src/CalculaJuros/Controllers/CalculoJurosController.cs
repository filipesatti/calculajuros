using Microsoft.AspNetCore.Mvc;
using CalculadorJuros.Services;

namespace CalculadorJuros.Controllers
{
    /// <summary>
    /// API Rest .Net Core para cálculo de juros compostos
    /// </summary>
    [Produces("application/json")]
    [Route("api/")]
    public class CalculoJurosController : Controller
    {
        /// <summary>
        /// Recebe valorinicial e meses como parâmetros para cálculo de juros compostos com base em taxa de 0.01
        /// </summary>
        /// <param name="valorinicial"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        [HttpGet("calculajuros")]
        public string GetCalculaJuros(decimal valorinicial,int meses)
        {
            return JurosService.CalculaJuros(valorinicial,meses).ToString();
        }

        /// <summary>
        /// Informações sobre repositório
        /// </summary>
        /// <returns></returns>
        [HttpGet("showmethecode")]
        public string ShowMeTheCode()
        {
            return @"https://github.com/filipesatti/calculajuros.git";
        }
    }
}
