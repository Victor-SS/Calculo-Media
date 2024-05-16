namespace CalculoMedia
{
    partial class FrmCalculoMedia
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(236, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(77, 38);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(236, 20);
            this.txtMateria.TabIndex = 1;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(29, 38);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "Materia";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(77, 64);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(76, 20);
            this.txtNota1.TabIndex = 2;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(29, 64);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(39, 13);
            this.lblNota1.TabIndex = 4;
            this.lblNota1.Text = "Nota 1";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(77, 90);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(76, 20);
            this.txtNota2.TabIndex = 3;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(29, 90);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(39, 13);
            this.lblNota2.TabIndex = 6;
            this.lblNota2.Text = "Nota 2";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(32, 129);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 51);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(192, 129);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 51);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular Média";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmCalculoMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 208);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculoMedia";
            this.Text = "Calculo Média";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
    }
}

