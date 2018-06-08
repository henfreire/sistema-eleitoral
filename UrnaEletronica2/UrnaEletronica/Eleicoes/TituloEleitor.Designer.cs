namespace UrnaEletronica.Eleicoes
{
    partial class TituloEleitor
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
            this.finalizar_eleicoes = new System.Windows.Forms.Button();
            this.entrar = new System.Windows.Forms.Button();
            this.titulo_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // finalizar_eleicoes
            // 
            this.finalizar_eleicoes.Location = new System.Drawing.Point(12, 226);
            this.finalizar_eleicoes.Name = "finalizar_eleicoes";
            this.finalizar_eleicoes.Size = new System.Drawing.Size(128, 23);
            this.finalizar_eleicoes.TabIndex = 1;
            this.finalizar_eleicoes.Text = "Finalizar";
            this.finalizar_eleicoes.UseVisualStyleBackColor = true;
            this.finalizar_eleicoes.Click += new System.EventHandler(this.finalizar_eleicoes_Click);
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(144, 226);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(128, 23);
            this.entrar.TabIndex = 2;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // titulo_input
            // 
            this.titulo_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_input.Location = new System.Drawing.Point(12, 99);
            this.titulo_input.Name = "titulo_input";
            this.titulo_input.Size = new System.Drawing.Size(260, 23);
            this.titulo_input.TabIndex = 3;
            this.titulo_input.TextChanged += new System.EventHandler(this.titulo_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o título de eleitor";
            // 
            // TituloEleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo_input);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.finalizar_eleicoes);
            this.Name = "TituloEleitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TituloEleitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finalizar_eleicoes;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.TextBox titulo_input;
        private System.Windows.Forms.Label label1;
    }
}