namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    partial class frmCotacaoDolar
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
            this.txtQtdConversao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFazerConversao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQtdConversao
            // 
            this.txtQtdConversao.Location = new System.Drawing.Point(104, 98);
            this.txtQtdConversao.Name = "txtQtdConversao";
            this.txtQtdConversao.Size = new System.Drawing.Size(91, 23);
            this.txtQtdConversao.TabIndex = 3;
            this.txtQtdConversao.TextChanged += new System.EventHandler(this.txtQtdConversao_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade para conversão\r\n(em dólares)\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFazerConversao
            // 
            this.btnFazerConversao.Location = new System.Drawing.Point(104, 163);
            this.btnFazerConversao.Name = "btnFazerConversao";
            this.btnFazerConversao.Size = new System.Drawing.Size(91, 35);
            this.btnFazerConversao.TabIndex = 5;
            this.btnFazerConversao.Text = "CONVERTER";
            this.btnFazerConversao.UseVisualStyleBackColor = true;
            this.btnFazerConversao.Click += new System.EventHandler(this.btnFazerConversao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(60, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "$ =";
            // 
            // frmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 267);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFazerConversao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdConversao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCotacaoDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCotacaoDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtQtdConversao;
        private Label label3;
        private Button btnFazerConversao;
        private Label label4;
    }
}