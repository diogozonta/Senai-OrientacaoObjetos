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
        int numero = 0;

        public frmComissao()
        {
            InitializeComponent();
            btnEnviarComissao.Enabled = false;

        }
        private void btnEnviarComissao_Click(object sender, EventArgs e)
        {

            ltbResultado.Items.Clear();

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

        private void txtNomeDoVendedor_Validating(object sender, CancelEventArgs e)
        {
            //bool bStatus = true;
            if (txtNomeDoVendedor.Text.All(char.IsNumber))
            {
                errorProvider1.SetError(txtNomeDoVendedor, "É necessário declarar um nome válido!!");
                txtNomeDoVendedor.Focus();
                //bStatus = false;
            }

            else
                errorProvider1.SetError(txtNomeDoVendedor, "");
        }

        private void txtCodigoPeca_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(txtCodigoPeca.Text, out numero))
            {
                errorProvider1.SetError(txtCodigoPeca, "");
            }

            else
            {
                errorProvider1.SetError(txtCodigoPeca, "É necessário informar um número inteiro");
                txtCodigoPeca.Focus();
            }


        }

        private void txtPrecoUnitario_Validating(object sender, CancelEventArgs e)
        {
            double numeroDecimal = 0.0;
            if (double.TryParse(txtPrecoUnitario.Text, out numeroDecimal))
            {
                errorProvider1.SetError(txtPrecoUnitario, "");
            }

            else
            {
                errorProvider1.SetError(txtPrecoUnitario, "É necessário informar um valor válido");
                txtCodigoPeca.Focus();
            }
        }

        private void txtQtdVendida_Validating(object sender, CancelEventArgs e)
        {
            if(int.TryParse(txtQtdVendida.Text, out numero))
            {
                errorProvider1.SetError(txtQtdVendida, "");
            }

            else
            {
                errorProvider1.SetError(txtQtdVendida, "É necessário informar um valor válido");
                txtQtdVendida.Focus();
            }
        }
    }
}
