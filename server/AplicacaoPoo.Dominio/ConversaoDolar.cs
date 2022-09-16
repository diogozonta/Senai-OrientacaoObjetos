using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    public class ConversaoDolar
    {
        public static double ConverterDolar(double cotacao, double conversao)
        {
            double totalConversao = cotacao * conversao;
            return totalConversao;
        }
    }
}
