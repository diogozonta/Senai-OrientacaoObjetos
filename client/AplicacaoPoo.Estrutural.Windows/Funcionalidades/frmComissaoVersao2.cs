using AplicacaoPoo.Dominio.Helpers;
using AplicacaoPoo.Dominio.services;
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
    public partial class frmComissaoVersao2 : Form
    {
        public frmComissaoVersao2()
        {
            InitializeComponent();

            btnCalcular.Enabled = false;

            var listaNome = new List<string>();
            listaNome.Add(FuncionarioHelper.FuncionarioUm);
            listaNome.Add(FuncionarioHelper.FuncionarioDois);
            listaNome.Add(FuncionarioHelper.FuncionarioTres);
            cmbNomeDoVendedor.DataSource = listaNome;
            cmbNomeDoVendedor.SelectedIndex = 0;

            var listaCodigo = new List<int>();
            listaCodigo.Add(CodigoHelper.Peca1);
            listaCodigo.Add(CodigoHelper.Peca2);
            listaCodigo.Add(CodigoHelper.Peca3);
            cmbCodigoPeca.DataSource = listaCodigo;
            cmbCodigoPeca.SelectedIndex = 0;
        }

        private void cmbCodigoPeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCodigoPeca.SelectedValue)
            {
                case CodigoHelper.Peca1:
                    txtValorUnitario.Text = CodigoHelper.PrecoPeca1;
                    break;

                case CodigoHelper.Peca2:
                    txtValorUnitario.Text = CodigoHelper.PrecoPeca2;
                    break;

                case CodigoHelper.Peca3:
                    txtValorUnitario.Text = CodigoHelper.PrecoPeca3;
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                ltbResultadoComissao2.Items.Clear();

                double valorUnitario = double.Parse(txtValorUnitario.Text);
                int quantidadeVendida = int.Parse(txtQuantidadeVendida.Text);

                ltbResultadoComissao2.Items.Add("Nome do funcionário: " + cmbNomeDoVendedor.SelectedValue);
                ltbResultadoComissao2.Items.Add("Código da peça: " + cmbCodigoPeca.SelectedValue);
                ltbResultadoComissao2.Items.Add("Valor unitário: R$" + txtValorUnitario.Text);
                ltbResultadoComissao2.Items.Add("Quantidade vendida: " + quantidadeVendida);
                ltbResultadoComissao2.Items.Add("Resultado comissão: R$" + ComissaoFuncionarioService.ComissaoVersaoDois(valorUnitario, quantidadeVendida));
            }
            catch (Exception)
            {
                MessageBox.Show("É necessario declarar um valor válido na quantidade vendida!!", "Erro ao realizar cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantidadeVendida.Focus();
                btnCalcular.Enabled = false;
            }
            
        }

        private void txtQuantidadeVendida_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidadeVendida.Text.All(char.IsLetter) |
                txtQuantidadeVendida.Text == "")
            {
                errorProvider1.SetError(txtQuantidadeVendida, "A quantidade vendida precisar ser um número!!");
                txtQuantidadeVendida.Focus();
                btnCalcular.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(txtQuantidadeVendida, "");
                btnCalcular.Enabled = true;
            }

  
        }
    }
}