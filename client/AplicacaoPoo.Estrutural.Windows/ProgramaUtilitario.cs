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
    public partial class ProgramaUtilitario : Form
    {
        public ProgramaUtilitario()
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
    }
}


