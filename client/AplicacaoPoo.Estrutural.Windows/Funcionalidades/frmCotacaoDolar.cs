using AplicacaoPoo.Dominio;
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
    public partial class frmCotacaoDolar : Form
    {
        public frmCotacaoDolar()
        {
            InitializeComponent();
            btnFazerConversao.Enabled = false;
        }

        private void txtQtdConversao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQtdConversao.Text == "")
                {
                    btnFazerConversao.Enabled = false;
                    return;
                }


                var resultado = decimal.Parse(txtQtdConversao.Text);
                btnFazerConversao.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dalor é um valor decimal");
                txtQtdConversao.Focus();
                btnFazerConversao.Enabled = false;

            }
        }

        private void btnFazerConversao_Click(object sender, EventArgs e)
        {
            var valorEmDolar = decimal.Parse(txtQtdConversao.Text);
            
            var moeda = new ConverterMoedaService();
            var resultado = moeda.ConverterDolarEmReal(valorEmDolar);
            
            //string interpolation
            MessageBox.Show($"Valor convertido em real é: {resultado} reais");

            txtQtdConversao.Text = string.Empty;
        }
    }
}
