using AplicacaoPoo.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    public partial class frmComissao : Form
    {
        public frmComissao()
        {
            InitializeComponent();
        }
        private void btnEnviarComissao_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaração das variáveis recebidas pelo Windows Forms
                string nome = cmbNomeVendedor.Text;
                int codigoPeca = int.Parse(txtCodigoPeca.Text);
                double precoUnitario = double.Parse(txtPrecoUnitario.Text);
                int qtdVendida = int.Parse(txtQtdVendida.Text);

                //chamando a função de calcular comissão
                var resultadoComissao = (Comissao.CalcularComissao(precoUnitario, qtdVendida).ToString());

                //Adicionando os dados na List Box
                ltbResultado.Items.Add("Nome do vendendor: " + nome);
                ltbResultado.Items.Add("Código da peça: " + codigoPeca);
                ltbResultado.Items.Add("Preço unitário: R$" + precoUnitario);
                ltbResultado.Items.Add("Quantidade Vendida: " + qtdVendida);
                ltbResultado.Items.Add("Valor da comissão: R$" + resultadoComissao);
            }
            catch (Exception)
            {
                MessageBox.Show("Confira as informações passadas novamente", "Erro ao receber informações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbNomeVendedor.Text = null;
            txtCodigoPeca.Text = null;
            txtPrecoUnitario.Text = null;
            txtQtdVendida.Text = null;
            ltbResultado.Items.Clear();
        }
    }
}
