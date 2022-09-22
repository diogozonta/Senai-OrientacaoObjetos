using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    //static
    //partial
    //abstract
    public class ConversaoDolar
    {
        public static decimal ConverterDolar(decimal cotacao, decimal conversao)
        {
            decimal totalConversao = cotacao * conversao;
            Math.Round(totalConversao, 2);

            return totalConversao;
        }
    }
}
