namespace UrnaEletronica
{
    partial class PartidoCrud
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
            this.salvar_part = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.nome_partido = new System.Windows.Forms.TextBox();
            this.sigla_partido = new System.Windows.Forms.TextBox();
            this.numero_partido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salvar_part
            // 
            this.salvar_part.Location = new System.Drawing.Point(150, 223);
            this.salvar_part.Name = "salvar_part";
            this.salvar_part.Size = new System.Drawing.Size(122, 26);
            this.salvar_part.TabIndex = 0;
            this.salvar_part.Text = "Salvar";
            this.salvar_part.UseVisualStyleBackColor = true;
            this.salvar_part.Click += new System.EventHandler(this.salvar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(12, 223);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(122, 26);
            this.cancelar.TabIndex = 1;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // nome_partido
            // 
            this.nome_partido.Location = new System.Drawing.Point(12, 61);
            this.nome_partido.Name = "nome_partido";
            this.nome_partido.Size = new System.Drawing.Size(260, 20);
            this.nome_partido.TabIndex = 2;
            // 
            // sigla_partido
            // 
            this.sigla_partido.Location = new System.Drawing.Point(12, 136);
            this.sigla_partido.Name = "sigla_partido";
            this.sigla_partido.Size = new System.Drawing.Size(61, 20);
            this.sigla_partido.TabIndex = 3;
            // 
            // numero_partido
            // 
            this.numero_partido.Location = new System.Drawing.Point(211, 136);
            this.numero_partido.MaxLength = 2;
            this.numero_partido.Name = "numero_partido";
            this.numero_partido.Size = new System.Drawing.Size(61, 20);
            this.numero_partido.TabIndex = 4;
            this.numero_partido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_partido_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sigla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Número";
            // 
            // PartidoCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero_partido);
            this.Controls.Add(this.sigla_partido);
            this.Controls.Add(this.nome_partido);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.salvar_part);
            this.Name = "PartidoCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartidoCrud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvar_part;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox nome_partido;
        private System.Windows.Forms.TextBox sigla_partido;
        private System.Windows.Forms.TextBox numero_partido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}