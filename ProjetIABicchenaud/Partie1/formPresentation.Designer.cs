namespace Partie1
{
	partial class formPresentation
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.lbPresentation = new System.Windows.Forms.Label();
            this.btContinuer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPresentation
            // 
            this.lbPresentation.BackColor = System.Drawing.SystemColors.Control;
            this.lbPresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPresentation.Location = new System.Drawing.Point(327, 215);
            this.lbPresentation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPresentation.Name = "lbPresentation";
            this.lbPresentation.Size = new System.Drawing.Size(478, 137);
            this.lbPresentation.TabIndex = 0;
            this.lbPresentation.Text = "Bienvenue à vous! Ce test a pour but de tester vos connaissances dans le module I" +
    "ntelligence Artificielle. Êtes-vous prêt?";
            // 
            // btContinuer
            // 
            this.btContinuer.Location = new System.Drawing.Point(482, 442);
            this.btContinuer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btContinuer.Name = "btContinuer";
            this.btContinuer.Size = new System.Drawing.Size(160, 74);
            this.btContinuer.TabIndex = 1;
            this.btContinuer.Text = "C\'est parti!";
            this.btContinuer.UseVisualStyleBackColor = true;
            this.btContinuer.Click += new System.EventHandler(this.btContinuer_Click);
            // 
            // formPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btContinuer);
            this.Controls.Add(this.lbPresentation);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formPresentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Label lbPresentation;
        private System.Windows.Forms.Button btContinuer;
    }
}

