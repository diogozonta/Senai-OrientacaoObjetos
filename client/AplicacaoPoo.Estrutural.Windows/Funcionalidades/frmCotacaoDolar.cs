using AplicacaoPoo.Dominio;
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
    public partial class frmCotacaoDolar : Form
    {
        public frmCotacaoDolar()
        {
            InitializeComponent();

            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
        }

        private void txtQtdConversao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQtdConversao.Text == "")
                {
                    return;
                }

                //var valor = decimal.Parse(txtQtdConversao.Text);

                //var moeda = new ConverterMoedaService();
                //var resultado = moeda.ConverterDolarEmReal(valorEmDolar);
                //lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                //lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
                
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dalor é um valor decimal");
                txtQtdConversao.Focus();

            }
        }

        private void cmbMoedaDesejada_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal resultado = 0;
            var moeda = new ConverterMoedaService();
            var valor = decimal.Parse(txtQtdConversao.Text);


            switch (cmbMoedaDesejada.Text)
            {
                //Dólar Americano
                case "Dólar Americano":
                    resultado = moeda.ConverterDolarEmReal(valor);
                    lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Dolar} igual a";
                    lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

                    break;

                //Euro
                case "Euro":
                    resultado = moeda.ConverterEuroEmReal(valor);
                    lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Euro} igual a";
                    lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

                    break;

                //Libra Esterlinas
                case "Libra Esterlinas":
                    resultado = moeda.ConverterLibraEmReal(valor);
                    lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Libras} igual a";
                    lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

                    break;

            }
        }
    }
}
