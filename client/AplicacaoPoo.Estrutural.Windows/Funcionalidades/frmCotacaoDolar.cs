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
            double cotacao = double.Parse(txtCotacaoAtual.Text);
            double conversao = double.Parse(txtQtdConversao.Text);

            MessageBox.Show("O total de $" + conversao + " convertidos na cotação de $1 = R$" + cotacao + " é igual a R$" +ConversaoDolar.ConverterDolar(cotacao,conversao).ToString(), "Valor dólar convertido");

        }
    }
}
