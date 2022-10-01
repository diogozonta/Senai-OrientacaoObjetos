using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    public class ComissaoFuncionarioService
    {
        public static decimal ComissaoVersaoDois(decimal valorUnitario, decimal quantidadeVendida)
        {
            decimal resultadoComissaoDois = valorUnitario * quantidadeVendida;
            return resultadoComissaoDois * 0.05m;
        }
    }
}
