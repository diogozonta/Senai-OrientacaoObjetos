using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    public class ProdutoService
    {
        public List<Produto> ListagemProdutoFake()
        {
            var lista = new List<Produto>();

            lista.Add(new Produto()
            {
                Id = 1,
                Nome = "Produto A",
                ValorUnitario = 10m
            });
            
            lista.Add(new Produto()
            {
                Id = 2,
                Nome = "Produto B",
                ValorUnitario = 20m
            });

            lista.Add(new Produto()
            {
                Id = 3,
                Nome = "Produto C",
                ValorUnitario = 30m
                
            });

            return lista;

        }
    }
}
