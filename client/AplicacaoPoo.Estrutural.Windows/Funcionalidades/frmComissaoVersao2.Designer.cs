namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    partial class frmComissaoVersao2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNomeDoVendedor = new System.Windows.Forms.ComboBox();
            this.cmbCodigoPeca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ltbResultadoComissao2 = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtQuantidadeVendida = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(186, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código da peça";
            // 
            // cmbNomeDoVendedor
            // 
            this.cmbNomeDoVendedor.FormattingEnabled = true;
            this.cmbNomeDoVendedor.Location = new System.Drawing.Point(12, 48);
            this.cmbNomeDoVendedor.Name = "cmbNomeDoVendedor";
            this.cmbNomeDoVendedor.Size = new System.Drawing.Size(146, 23);
            this.cmbNomeDoVendedor.TabIndex = 2;
            // 
            // cmbCodigoPeca
            // 
            this.cmbCodigoPeca.FormattingEnabled = true;
            this.cmbCodigoPeca.Location = new System.Drawing.Point(186, 48);
            this.cmbCodigoPeca.Name = "cmbCodigoPeca";
            this.cmbCodigoPeca.Size = new System.Drawing.Size(146, 23);
            this.cmbCodigoPeca.TabIndex = 3;
            this.cmbCodigoPeca.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoPeca_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor unitário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(186, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade vendida";
            // 
            // ltbResultadoComissao2
            // 
            this.ltbResultadoComissao2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltbResultadoComissao2.FormattingEnabled = true;
            this.ltbResultadoComissao2.ItemHeight = 18;
            this.ltbResultadoComissao2.Location = new System.Drawing.Point(12, 168);
            this.ltbResultadoComissao2.Name = "ltbResultadoComissao2";
            this.ltbResultadoComissao2.Size = new System.Drawing.Size(320, 184);
            this.ltbResultadoComissao2.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(120, 397);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 42);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Enabled = false;
            this.txtValorUnitario.Location = new System.Drawing.Point(12, 120);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(145, 23);
            this.txtValorUnitario.TabIndex = 10;
            // 
            // txtQuantidadeVendida
            // 
            this.txtQuantidadeVendida.Location = new System.Drawing.Point(186, 120);
            this.txtQuantidadeVendida.Name = "txtQuantidadeVendida";
            this.txtQuantidadeVendida.Size = new System.Drawing.Size(146, 23);
            this.txtQuantidadeVendida.TabIndex = 11;
            this.txtQuantidadeVendida.TextChanged += new System.EventHandler(this.txtQuantidadeVendida_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmComissaoVersao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 474);
            this.Controls.Add(this.txtQuantidadeVendida);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.ltbResultadoComissao2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCodigoPeca);
            this.Controls.Add(this.cmbNomeDoVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmComissaoVersao2";
            this.Text = "Cálculo de Comissão 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbNomeDoVendedor;
        private ComboBox cmbCodigoPeca;
        private Label label3;
        private Label label4;
        private ListBox ltbResultadoComissao2;
        private Button btnCalcular;
        private TextBox txtValorUnitario;
        private TextBox txtQuantidadeVendida;
        private ErrorProvider errorProvider1;
    }
}