using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    public class FuncionarioService
    {
        public List<Funcionario> ListaFuncionario()
        {
            var lista = new List<Funcionario>();

            lista.Add(new Funcionario()
            {
                Id = 1,
                Nome = "Gustavo Zói"
            });

            lista.Add(new Funcionario()
            {
                Id = 2,
                Nome = "Marcos"
            });

            lista.Add(new Funcionario()
            {
                Id = 3,
                Nome = "Fábio"
            });

            lista.Add(new Funcionario()
            {
                Id = 4,
                Nome = "Lucas"
            });

            lista.Add(new Funcionario()
            {
                Id = 5,
                Nome = "Luiz"
            });

            lista.Add(new Funcionario()
            {
                Id = 6,
                Nome = "Claudio"
            });

            return lista;

        }
    }
}
