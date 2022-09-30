using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    public class Comissao
    {
        public static double CalcularComissao(double precoUnitario, int qtdVendida)
        {
            double resultadoComissao = precoUnitario * qtdVendida;
            resultadoComissao = resultadoComissao * 0.05;

            Math.Round(resultadoComissao, 1);

            return resultadoComissao;         
        }
    }
}
