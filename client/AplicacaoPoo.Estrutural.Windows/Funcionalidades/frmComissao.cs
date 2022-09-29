using AplicacaoPoo.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            btnEnviarComissao.Enabled = false;

        }
        private void btnEnviarComissao_Click(object sender, EventArgs e)
        { 
               
            try
            {
                //Declaração das variáveis recebidas pelo Windows Forms
                string nome = txtNomeDoVendedor.Text;
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


        //evento usado para verificar se todos os txtBox estão preenchidos ou não
        //Após a criação desse evento é necessário utilizado em todos os txtBox que irão sofrer esse evento
        private void VerificarSeExisteTxtBoxVazio(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomeDoVendedor.Text) &
                !string.IsNullOrEmpty(txtCodigoPeca.Text) &
                !string.IsNullOrEmpty(txtPrecoUnitario.Text) &
                !string.IsNullOrEmpty(txtQtdVendida.Text))
            {
                btnEnviarComissao.Enabled = true;
            }

            else
                btnEnviarComissao.Enabled = false;
        }

        private void VerificarSeOsTxtBoxSaoNumeros(object sender, EventArgs e)
        {
            int number = 0;

            if(int.TryParse(txtCodigoPeca.Text, out number))
            {

            }
        }
    }
}
