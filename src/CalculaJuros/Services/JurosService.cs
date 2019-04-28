using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadorJuros.Services
{
    public class JurosService
    {
        public static decimal CalculaJuros(decimal valorinicial, int meses)
        {
            return Decimal.Round((valorinicial * (decimal)Math.Pow(1.01, meses)),2,MidpointRounding.AwayFromZero);
        }
    }
}
