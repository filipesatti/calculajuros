using System;

namespace CalculadorJuros.Services
{
    /// <summary>
    /// Serviço de cálculo de juros
    /// </summary>
    public class JurosService
    {
        /// <summary>
        /// Método de cálculo de juros com base em valorinicial, meses e taxa fixa de 0.01
        /// </summary>
        /// <param name="valorinicial"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        public static decimal CalculaJuros(decimal valorinicial, int meses)
        {
            return Decimal.Round((valorinicial * (decimal)Math.Pow(1.01, meses)),2,MidpointRounding.AwayFromZero);
        }
    }
}
