using AplicacaoPoo.Dominio;
using AplicacaoPoo.Dominio.Helpers;
using AplicacaoPoo.Dominio.services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    public partial class frmComissaoVersao2 : Form
    {
        public frmComissaoVersao2()
        {
            InitializeComponent();
            btnCalcular.Enabled = false;
            var lista = new FuncionarioService();
            var listaCodigo = new ProdutoService();

            cmbNomeDoVendedor.DataSource = lista.ListaFuncionario();
            cmbNomeDoVendedor.DisplayMember = "Nome";
            cmbNomeDoVendedor.ValueMember = "Id";

            cmbCodigoPeca.DataSource = listaCodigo.ListagemProdutoFake();
            cmbCodigoPeca.DisplayMember = "Nome";
            cmbCodigoPeca.ValueMember = "Id";
            txtValorUnitario.Text = "ValorUnitario";
        }
         
        private void btnCalcular_Click(object sender, EventArgs e)
        {
               
        }

        private void cmbCodigoPeca_ValueMemberChanged(object sender, EventArgs e)
        {
            switch (cmbCodigoPeca.ValueMember)
            {
                case "Produto A":
                    break;
            }
        }
    }
}