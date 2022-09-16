namespace AplicacaoPoo.Estrutural.Windows
{
    partial class ProgramaUtilitario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramaUtilitario));
            this.btnCotacao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCotacao
            // 
            this.btnCotacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCotacao.BackgroundImage")));
            this.btnCotacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCotacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCotacao.Location = new System.Drawing.Point(60, 12);
            this.btnCotacao.Name = "btnCotacao";
            this.btnCotacao.Size = new System.Drawing.Size(188, 73);
            this.btnCotacao.TabIndex = 0;
            this.btnCotacao.Text = "CONVERSOR";
            this.btnCotacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCotacao.UseVisualStyleBackColor = true;
            this.btnCotacao.Click += new System.EventHandler(this.btnCotacao_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(60, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "COMISSÃO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProgramaUtilitario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(322, 182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCotacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProgramaUtilitario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa Utilitário";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCotacao;
        private Button button1;
    }
}