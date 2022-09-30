using AplicacaoPoo.Estrutural.Windows.Funcionalidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCotacao_Click(object sender, EventArgs e)
        {
            var form = new frmCotacaoDolar();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new frmComissao();
            form.Show();
        }

        private void btnCotacao_MouseHover(object sender, EventArgs e)
        {
            btnCotacao.BackColor = Color.Gray; 
        }

        private void btnCotacao_MouseLeave(object sender, EventArgs e)
        {
            btnCotacao.BackColor = Color.White;
        }

        private void conversorDeMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCotacaoDolar();
            form.MdiParent = this;
            form.Show();
        }

        private void versao10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmComissao();
            form.MdiParent = this;
            form.Show();
        }

        private void versao20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmComissaoVersao2();
            form.MdiParent = this;
            form.Show();
        }
    }
}


