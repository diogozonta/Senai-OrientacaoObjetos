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
    public partial class frmCotacaoDolar : Form
    {
        private bool ValorEmDolarEhValido;
        private bool CotacaoEhValido;
        
        public frmCotacaoDolar()
        {
            InitializeComponent();
            btnFazerConversao.Enabled = false;  
        }

        private void btnFazerConversao_Click(object sender, EventArgs e)
        {
            decimal cotacao = decimal.Parse(txtCotacaoAtual.Text);
            decimal qtdConversao = decimal.Parse(txtQtdConversao.Text);
            decimal resultadoConversao = cotacao * qtdConversao;
            MessageBox.Show("O valor da conversão é " + resultadoConversao);
        }
        
        private void txtCotacaoAtual_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtCotacaoAtual.Text);
                HabilitarOuDesabilitarBotaoCalcularConversao();
            }
            catch (Exception)
            {
                MessageBox.Show("Você não informou um valor válido ", "ERRO AO RECEBER VALOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCotacaoAtual.Focus();
            }
        }

        private void txtQtdConversao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtQtdConversao.Text);
                //HabilitarOuDesabilitarBotaoCalcularConversao();
            }
            catch (Exception)
            {
                MessageBox.Show("Você não informou um valo válido ", "ERRO AO RECEBER VALOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtdConversao.Focus();
            }
        }

        private void HabilitarOuDesabilitarBotaoCalcularConversao()
        {
            if (ValorEmDolarEhValido && CotacaoEhValido)
            {
                btnFazerConversao.Enabled = true;
            }

            else
            {
                btnFazerConversao.Enabled = false;
            }
        }
    }
}
