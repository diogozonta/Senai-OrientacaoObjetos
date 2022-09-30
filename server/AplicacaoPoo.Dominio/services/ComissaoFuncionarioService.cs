using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    public class ComissaoFuncionarioService
    {
        public static double ComissaoVersaoDois(double valorUnitario, int quantidadeVendida)
        {
            double resultadoComissaoDois = (valorUnitario * quantidadeVendida) * 0.05;
            Math.Round(resultadoComissaoDois, 1);
            return resultadoComissaoDois;
        }
    }
}
