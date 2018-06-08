namespace UrnaEletronica.Urna
{
    partial class UrnaCRUD
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
            this.label4 = new System.Windows.Forms.Label();
            this.abertura = new System.Windows.Forms.DateTimePicker();
            this.secao = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zona = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.fechamento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Seção";
            // 
            // abertura
            // 
            this.abertura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.abertura.Location = new System.Drawing.Point(13, 132);
            this.abertura.Name = "abertura";
            this.abertura.ShowUpDown = true;
            this.abertura.Size = new System.Drawing.Size(77, 20);
            this.abertura.TabIndex = 47;
            // 
            // secao
            // 
            this.secao.Location = new System.Drawing.Point(13, 81);
            this.secao.Name = "secao";
            this.secao.Size = new System.Drawing.Size(260, 20);
            this.secao.TabIndex = 45;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(32, 13);
            this.label.TabIndex = 44;
            this.label.Text = "Zona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Abertura";
            // 
            // zona
            // 
            this.zona.Location = new System.Drawing.Point(11, 32);
            this.zona.Name = "zona";
            this.zona.Size = new System.Drawing.Size(260, 20);
            this.zona.TabIndex = 41;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(11, 221);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(122, 26);
            this.cancelar.TabIndex = 40;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(148, 221);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(122, 26);
            this.salvar.TabIndex = 39;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // fechamento
            // 
            this.fechamento.CustomFormat = "";
            this.fechamento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fechamento.Location = new System.Drawing.Point(16, 177);
            this.fechamento.Name = "fechamento";
            this.fechamento.ShowUpDown = true;
            this.fechamento.Size = new System.Drawing.Size(74, 20);
            this.fechamento.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Fechamento";
            // 
            // UrnaCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.fechamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abertura);
            this.Controls.Add(this.secao);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zona);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.salvar);
            this.Name = "UrnaCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrnaCRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker abertura;
        private System.Windows.Forms.TextBox secao;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox zona;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.DateTimePicker fechamento;
        private System.Windows.Forms.Label label1;
    }
}