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
        public frmCotacaoDolar()
        {
            InitializeComponent();
        }

        private void btnFazerConversao_Click(object sender, EventArgs e)
        {

            try
            {
                //Variáveis a serem passadas a classe.

                decimal cotacao = decimal.Parse(txtCotacaoAtual.Text);
                decimal conversao = decimal.Parse(txtQtdConversao.Text);

                MessageBox.Show("O valor da conversão é R$" + ConversaoDolar.ConverterDolar(cotacao, conversao).ToString(), "Resultado conversão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Você não digitou um valor  válido", "ERRO AO PROCESSAR DADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
                  
        }
    }
}
