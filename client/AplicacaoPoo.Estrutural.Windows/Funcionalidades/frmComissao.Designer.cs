namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    partial class frmComissao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoPeca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtdVendida = new System.Windows.Forms.TextBox();
            this.ltbResultado = new System.Windows.Forms.ListBox();
            this.btnEnviarComissao = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNomeDoVendedor = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(191, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código da peça\r\n";
            // 
            // txtCodigoPeca
            // 
            this.txtCodigoPeca.Location = new System.Drawing.Point(191, 45);
            this.txtCodigoPeca.Name = "txtCodigoPeca";
            this.txtCodigoPeca.Size = new System.Drawing.Size(145, 23);
            this.txtCodigoPeca.TabIndex = 3;
            this.txtCodigoPeca.TextChanged += new System.EventHandler(this.VerificarSeExisteTxtBoxVazio);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço unitário\r\n";
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(12, 112);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(145, 23);
            this.txtPrecoUnitario.TabIndex = 5;
            this.txtPrecoUnitario.TextChanged += new System.EventHandler(this.VerificarSeExisteTxtBoxVazio);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(191, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade vendida";
            // 
            // txtQtdVendida
            // 
            this.txtQtdVendida.Location = new System.Drawing.Point(191, 112);
            this.txtQtdVendida.Name = "txtQtdVendida";
            this.txtQtdVendida.Size = new System.Drawing.Size(145, 23);
            this.txtQtdVendida.TabIndex = 7;
            this.txtQtdVendida.TextChanged += new System.EventHandler(this.VerificarSeExisteTxtBoxVazio);
            // 
            // ltbResultado
            // 
            this.ltbResultado.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltbResultado.FormattingEnabled = true;
            this.ltbResultado.ItemHeight = 18;
            this.ltbResultado.Location = new System.Drawing.Point(12, 151);
            this.ltbResultado.Name = "ltbResultado";
            this.ltbResultado.Size = new System.Drawing.Size(324, 130);
            this.ltbResultado.TabIndex = 8;
            // 
            // btnEnviarComissao
            // 
            this.btnEnviarComissao.Location = new System.Drawing.Point(125, 306);
            this.btnEnviarComissao.Name = "btnEnviarComissao";
            this.btnEnviarComissao.Size = new System.Drawing.Size(109, 37);
            this.btnEnviarComissao.TabIndex = 9;
            this.btnEnviarComissao.Text = "ENVIAR";
            this.btnEnviarComissao.UseVisualStyleBackColor = true;
            this.btnEnviarComissao.Click += new System.EventHandler(this.btnEnviarComissao_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarFuncionárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarFuncionárioToolStripMenuItem
            // 
            this.adicionarFuncionárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem});
            this.adicionarFuncionárioToolStripMenuItem.Name = "adicionarFuncionárioToolStripMenuItem";
            this.adicionarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adicionarFuncionárioToolStripMenuItem.Text = "Adicionar";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // txtNomeDoVendedor
            // 
            this.txtNomeDoVendedor.Location = new System.Drawing.Point(12, 45);
            this.txtNomeDoVendedor.Name = "txtNomeDoVendedor";
            this.txtNomeDoVendedor.Size = new System.Drawing.Size(145, 23);
            this.txtNomeDoVendedor.TabIndex = 12;
            this.txtNomeDoVendedor.TextChanged += new System.EventHandler(this.VerificarSeExisteTxtBoxVazio);
            // 
            // frmComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 368);
            this.Controls.Add(this.txtNomeDoVendedor);
            this.Controls.Add(this.btnEnviarComissao);
            this.Controls.Add(this.ltbResultado);
            this.Controls.Add(this.txtQtdVendida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoPeca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmComissao";
            this.Text = "Calculo de Comissão";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCodigoPeca;
        private Label label3;
        private TextBox txtPrecoUnitario;
        private Label label4;
        private TextBox txtQtdVendida;
        private ListBox ltbResultado;
        private Button btnEnviarComissao;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adicionarFuncionárioToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private TextBox txtNomeDoVendedor;
    }
}