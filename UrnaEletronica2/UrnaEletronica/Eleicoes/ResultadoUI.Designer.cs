namespace UrnaEletronica.Eleicoes
{
    partial class ResultadoUI
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
            this.voltar = new System.Windows.Forms.Button();
            this.prefeito_resultados = new System.Windows.Forms.DataGridView();
            this.vereador_resultados = new System.Windows.Forms.DataGridView();
            this.prefeito = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.segundo_turno_label = new System.Windows.Forms.Label();
            this.brancos_ver = new System.Windows.Forms.Label();
            this.nulos_ver = new System.Windows.Forms.Label();
            this.nulos_pref = new System.Windows.Forms.Label();
            this.brancos_pref = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prefeito_resultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vereador_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(144, 294);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(264, 33);
            this.voltar.TabIndex = 0;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // prefeito_resultados
            // 
            this.prefeito_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prefeito_resultados.Location = new System.Drawing.Point(12, 37);
            this.prefeito_resultados.Name = "prefeito_resultados";
            this.prefeito_resultados.Size = new System.Drawing.Size(240, 206);
            this.prefeito_resultados.TabIndex = 1;
            // 
            // vereador_resultados
            // 
            this.vereador_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vereador_resultados.Location = new System.Drawing.Point(303, 37);
            this.vereador_resultados.Name = "vereador_resultados";
            this.vereador_resultados.Size = new System.Drawing.Size(240, 206);
            this.vereador_resultados.TabIndex = 2;
            // 
            // prefeito
            // 
            this.prefeito.AutoSize = true;
            this.prefeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefeito.Location = new System.Drawing.Point(96, 18);
            this.prefeito.Name = "prefeito";
            this.prefeito.Size = new System.Drawing.Size(57, 17);
            this.prefeito.TabIndex = 3;
            this.prefeito.Text = "Prefeito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vereador";
            // 
            // segundo_turno_label
            // 
            this.segundo_turno_label.AutoSize = true;
            this.segundo_turno_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundo_turno_label.Location = new System.Drawing.Point(96, 261);
            this.segundo_turno_label.Name = "segundo_turno_label";
            this.segundo_turno_label.Size = new System.Drawing.Size(0, 16);
            this.segundo_turno_label.TabIndex = 5;
            // 
            // brancos_ver
            // 
            this.brancos_ver.AutoSize = true;
            this.brancos_ver.Location = new System.Drawing.Point(329, 261);
            this.brancos_ver.Name = "brancos_ver";
            this.brancos_ver.Size = new System.Drawing.Size(35, 13);
            this.brancos_ver.TabIndex = 6;
            this.brancos_ver.Text = "label3";
            // 
            // nulos_ver
            // 
            this.nulos_ver.AutoSize = true;
            this.nulos_ver.Location = new System.Drawing.Point(463, 261);
            this.nulos_ver.Name = "nulos_ver";
            this.nulos_ver.Size = new System.Drawing.Size(35, 13);
            this.nulos_ver.TabIndex = 7;
            this.nulos_ver.Text = "label4";
            // 
            // nulos_pref
            // 
            this.nulos_pref.AutoSize = true;
            this.nulos_pref.Location = new System.Drawing.Point(169, 261);
            this.nulos_pref.Name = "nulos_pref";
            this.nulos_pref.Size = new System.Drawing.Size(35, 13);
            this.nulos_pref.TabIndex = 9;
            this.nulos_pref.Text = "label5";
            // 
            // brancos_pref
            // 
            this.brancos_pref.AutoSize = true;
            this.brancos_pref.Location = new System.Drawing.Point(35, 261);
            this.brancos_pref.Name = "brancos_pref";
            this.brancos_pref.Size = new System.Drawing.Size(35, 13);
            this.brancos_pref.TabIndex = 8;
            this.brancos_pref.Text = "label6";
            // 
            // ResultadoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 330);
            this.Controls.Add(this.nulos_pref);
            this.Controls.Add(this.brancos_pref);
            this.Controls.Add(this.nulos_ver);
            this.Controls.Add(this.brancos_ver);
            this.Controls.Add(this.segundo_turno_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prefeito);
            this.Controls.Add(this.vereador_resultados);
            this.Controls.Add(this.prefeito_resultados);
            this.Controls.Add(this.voltar);
            this.Name = "ResultadoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultadoUI";
            ((System.ComponentModel.ISupportInitialize)(this.prefeito_resultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vereador_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.DataGridView prefeito_resultados;
        private System.Windows.Forms.DataGridView vereador_resultados;
        private System.Windows.Forms.Label prefeito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label segundo_turno_label;
        private System.Windows.Forms.Label brancos_ver;
        private System.Windows.Forms.Label nulos_ver;
        private System.Windows.Forms.Label nulos_pref;
        private System.Windows.Forms.Label brancos_pref;
    }
}