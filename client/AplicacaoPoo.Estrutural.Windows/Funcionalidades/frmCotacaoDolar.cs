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

            var list = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libras);
            cmbMoedaDesejada.DataSource = list;
            cmbMoedaDesejada.SelectedIndex = 0; 
        }

        private void txtQtdConversao_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtQtdConversao.Text == "")
                {
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dalor é um valor decimal");
                txtQtdConversao.Focus();

            }
        }

        private void cmbMoedaDesejada_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region MEU PROGRAMA

            //decimal resultado = 0;
            //var moeda = new ConverterMoedaService();
            //decimal valor = decimal.Parse(txtQtdConversao.Text);
            //switch (cmbMoedaDesejada.Text)
            //{
            //    //Dólar Americano
            //    case "Dólar Americano":
            //        resultado = moeda.ConverterDolarEmReal(valor);
            //        lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Dolar} igual a";
            //        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

            //        break;

            //    //Euro
            //    case "Euro":
            //        resultado = moeda.ConverterEuroEmReal(valor);
            //        lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Euro} igual a";
            //        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

            //        break;

            //    //Libra Esterlinas
            //    case "Libra Esterlinas":
            //        resultado = moeda.ConverterLibraEmReal(valor);
            //        lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Libras} igual a";
            //        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

            //        break;

            //}

            #endregion

            #region PROGRAMA PROFESSOR
            if (txtQtdConversao.Text == "") return;

            var moedaService = new ConverterMoedaService();
            var valorConversao = decimal.Parse(txtQtdConversao.Text);

            switch (cmbMoedaDesejada.SelectedValue)
            {


                case MoedaHelper.Dolar:
                    {
                        var valorConvertido = moedaService.ConverterDolarEmReal(decimal.Parse(txtQtdConversao.Text));
                        lblPrimeiroValor.Text = $"{valorConversao}{MoedaHelper.Dolar} igual a";
                        lblSegundoValor.Text = $"{valorConvertido}{MoedaHelper.Real}";
                        break;
                    }

                case MoedaHelper.Euro:
                    {
                        var valorConvertido = moedaService.ConverterEuroEmReal(decimal.Parse(txtQtdConversao.Text));
                        lblPrimeiroValor.Text = $"{valorConversao}{MoedaHelper.Euro} igual a";
                        lblSegundoValor.Text = $"{valorConvertido}{MoedaHelper.Real}";
                        break;
                    }

                case MoedaHelper.Libras:
                    {
                        var valorConvertido = moedaService.ConverterLibraEmReal(decimal.Parse(txtQtdConversao.Text));
                        lblPrimeiroValor.Text = $"{valorConversao}{MoedaHelper.Libras} igual a";
                        lblSegundoValor.Text = $"{valorConvertido}{MoedaHelper.Real}";
                        break;
                    }
            }

            #endregion
        }

    }
}
