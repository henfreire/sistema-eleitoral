namespace UrnaEletronica
{
    partial class AdminMain
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
            this.Partido = new System.Windows.Forms.Button();
            this.Candidato = new System.Windows.Forms.Button();
            this.Eleitor = new System.Windows.Forms.Button();
            this.Urna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Partido
            // 
            this.Partido.Location = new System.Drawing.Point(64, 27);
            this.Partido.Name = "Partido";
            this.Partido.Size = new System.Drawing.Size(147, 49);
            this.Partido.TabIndex = 0;
            this.Partido.Text = "Partido";
            this.Partido.UseVisualStyleBackColor = true;
            this.Partido.Click += new System.EventHandler(this.Partido_Click);
            // 
            // Candidato
            // 
            this.Candidato.Location = new System.Drawing.Point(64, 82);
            this.Candidato.Name = "Candidato";
            this.Candidato.Size = new System.Drawing.Size(147, 49);
            this.Candidato.TabIndex = 1;
            this.Candidato.Text = "Candidato";
            this.Candidato.UseVisualStyleBackColor = true;
            this.Candidato.Click += new System.EventHandler(this.Candidato_Click);
            // 
            // Eleitor
            // 
            this.Eleitor.Location = new System.Drawing.Point(64, 192);
            this.Eleitor.Name = "Eleitor";
            this.Eleitor.Size = new System.Drawing.Size(147, 49);
            this.Eleitor.TabIndex = 2;
            this.Eleitor.Text = "Eleitor";
            this.Eleitor.UseVisualStyleBackColor = true;
            this.Eleitor.Click += new System.EventHandler(this.Eleitor_Click);
            // 
            // Urna
            // 
            this.Urna.Location = new System.Drawing.Point(64, 137);
            this.Urna.Name = "Urna";
            this.Urna.Size = new System.Drawing.Size(147, 49);
            this.Urna.TabIndex = 3;
            this.Urna.Text = "Urna";
            this.Urna.UseVisualStyleBackColor = true;
            this.Urna.Click += new System.EventHandler(this.Urna_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Urna);
            this.Controls.Add(this.Eleitor);
            this.Controls.Add(this.Candidato);
            this.Controls.Add(this.Partido);
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Partido;
        private System.Windows.Forms.Button Candidato;
        private System.Windows.Forms.Button Eleitor;
        private System.Windows.Forms.Button Urna;
    }
}